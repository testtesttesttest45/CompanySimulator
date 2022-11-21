using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace ExperimentTreeViewV2.Classes
{
    [Serializable]
    public class EmployeeTreeNode : TreeNode, ISerializable
    {
        private EmployeeTreeNode _parentEmployeeTreeNode; // EmployeeTreeNode type object which describes the "Parent" reporting officer
        private Employee _employee; // To hold the Employee object which describes one employee information
        //A collection of EmployeeTreeNode type objects which describes the "Children"
        private List<EmployeeTreeNode> _children;

        public List<String> EmpProjectList = new List<String>();
        
        public bool isDummy { get; set; }
        public int Revenue { get; set; }
        public EmployeeTreeNode()
        {

        }
        public override object Clone() //override the parent , only way, inherittance
        {
            EmployeeTreeNode cloneTree = (EmployeeTreeNode)base.Clone();
            cloneTree.ParentEmployeeTreeNode = ParentEmployeeTreeNode; // Node, is a reference, we shallow copy, can read dont write.
            cloneTree.Employee = new Employee(_employee); // fully clone the Employee
            cloneTree.ChildEmployeeTreeNodes = ChildEmployeeTreeNodes; // List<Node>, is a reference, we shallow copy, can read dont write.
            UpdateTextDisplay();
            //this.Text = $"{Employee.Name} - {Employee.EmpRole} (S${Employee.Salary})";
            return cloneTree;
        }

        public EmployeeTreeNode(Employee employee)
        {
            _parentEmployeeTreeNode = null;
            _employee = employee;
            _employee.Container = this;
            _children = new List<EmployeeTreeNode>();
            //this.Text = $"{employee.Name} - {employee.EmpRole} (S{employee.Salary:C})" ; // real way for currency
            UpdateTextDisplay();
            // this.Text = $"{employee.Name} - {employee.EmpRole} (S${employee.Salary})";
        } // end of constructor

        public void UpdateTextDisplay()
        {
            if (this.Employee.EmpRole2 != "")
            {
                if (this.Employee.isSecondary)
                {
                    this.Text = $"{this.Employee.Name} - {this.Employee.EmpRole2},{this.Employee.EmpRole} (S${this.Employee.Salary})";
                }
                else
                {
                    this.Text = $"{this.Employee.Name} - {this.Employee.EmpRole}, {this.Employee.EmpRole2} (S${this.Employee.Salary})";
                }
            }
            else
            {
                this.Text = $"{this.Employee.Name} - {this.Employee.EmpRole} (S${this.Employee.Salary})";
            }
        }
        public EmployeeTreeNode ParentEmployeeTreeNode
        {
            get { return _parentEmployeeTreeNode; }
            set { _parentEmployeeTreeNode = value; }
        }
        public Employee Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }
        public List<EmployeeTreeNode> ChildEmployeeTreeNodes
        {
            get { return _children; }
            set { _children = value; }
        }
        public void AddChildEmployeeTreeNode(EmployeeTreeNode employeeNode)
        {
            employeeNode.ParentEmployeeTreeNode = this;
            _children.Add(employeeNode);
            this.Nodes.Add(employeeNode);

        } // End of AddChildEmployeeTreeNode method
        public bool RemoveMyselfFromParent()
        {
            // i gt parent
            if (ParentEmployeeTreeNode != null)
            {
                // disown myself
                ParentEmployeeTreeNode._children.Remove(this);
                ParentEmployeeTreeNode.Nodes.Remove(this);
                return true;
            }
            return false;
        }


        public void EditEmployee(string employeeName, int salary)
        {
            this.Employee.Name = employeeName;
            this.Employee.Salary = salary;
            this.Text = $"{Employee.Name} - {Employee.EmpRole} (S${Employee.Salary})";
        }// end of UpdateEmployee
        public void RebuildTreeNodes()
        {
            UpdateTextDisplay();
            //this.Text = $"{Employee.Name} - {Employee.EmpRole} (S${Employee.Salary})";
            if (this.ChildEmployeeTreeNodes.Count > 0)
            {
                int i = 0;
                for (i = 0; i < this.ChildEmployeeTreeNodes.Count; i++)
                {
                    this.Nodes.Add(this.ChildEmployeeTreeNodes[i]);
                    this.ChildEmployeeTreeNodes[i].ParentEmployeeTreeNode = this;
                    this.ChildEmployeeTreeNodes[i].RebuildTreeNodes();
                }
            }
        }//End of RebuildTreeNodes
        public void SaveToFileBinary(string filepath)
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                Stream stream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);

                bf.Serialize(stream, this);
                stream.Close();

                MessageBox.Show("Data is added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } //End of SaveToFileBinary
        public EmployeeTreeNode ReadFromFileBinary(string filepath)
        {
            try
            {
                Stream stream = new FileStream(@filepath, FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                EmployeeTreeNode root = null;
                if (stream.Length != 0)
                {
                    root = (EmployeeTreeNode)bf.Deserialize(stream);
                }
                stream.Close();

                return root;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Unable to find file.");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }//end of ReadFromFileBinary
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //add the required data to file
            info.AddValue("Employee", _employee);
            info.AddValue("ChildrenEmployeeTreeNodes", _children);
            info.AddValue("ParentEmployeeTreeNode", _parentEmployeeTreeNode);
            info.AddValue("isDummy", isDummy);
        }//end of GetObjectData [ SERIALIZE ]
        protected EmployeeTreeNode(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");
            this.Employee = (Employee)info.GetValue("Employee", typeof(Employee));
            this.Employee.Container = this;
            this.UpdateTextDisplay();
            this.ChildEmployeeTreeNodes = (List<EmployeeTreeNode>)info.GetValue("ChildrenEmployeeTreeNodes", typeof(List<EmployeeTreeNode>));
            this.ParentEmployeeTreeNode = (EmployeeTreeNode)info.GetValue("ParentEmployeeTreeNode", typeof(EmployeeTreeNode));
            // deserialize isDummy 
            this.isDummy = (bool)info.GetValue("isDummy", typeof(bool));

        }//end of EmployeeTreeNode [ DESERIALIZE ]
        public void SearchByUUID(string uuid, ref List<EmployeeTreeNode> foundNodes)
        {
            if (this.ChildEmployeeTreeNodes.Count > 0)//Note: This if block may not be necessary at all. Though the logic works.
            {
                int i = 0;
                for (i = 0; i < this.ChildEmployeeTreeNodes.Count; i++)
                {
                    if (this.ChildEmployeeTreeNodes[i].Employee.UUID == uuid)
                    {  //Base case (Where the method code stops calling itself, 
                       //perform action and finally exit). This avoids infinite loop

                        foundNodes.Add(this.ChildEmployeeTreeNodes[i]);
                    }
                    else
                    { //Recursive case (where the method calls itself)
                      //Each DepartmentNode type object has SearchDeleteById method
                        this.ChildEmployeeTreeNodes[i].SearchByUUID(uuid, ref foundNodes);
                    }
                }
            }
        }//End of SearchByUUID method

        public void GetReportingOfficerByName(string reportingOfficer, ref List<EmployeeTreeNode> reportingOfficers)
        {
            if (this.Employee.Name == "ROOT")
            {
                if (this.ChildEmployeeTreeNodes.Count > 0)
                {
                    int i = 0;
                    for (i = 0; i < this.ChildEmployeeTreeNodes.Count; i++)
                    {
                        this.ChildEmployeeTreeNodes[i].GetReportingOfficerByName(reportingOfficer, ref reportingOfficers);
                    }
                }
                return;
            }

            if (this.ParentEmployeeTreeNode.Employee.Name == reportingOfficer)
            {
                reportingOfficers.Add(ParentEmployeeTreeNode);
            }

            if (this.ChildEmployeeTreeNodes.Count > 0)
            {
                int i = 0;
                for (i = 0; i < this.ChildEmployeeTreeNodes.Count; i++)
                {
                    this.ChildEmployeeTreeNodes[i].GetReportingOfficerByName(reportingOfficer, ref reportingOfficers);
                }
            }
        }
        public void GetAllUniqueRolesAndEmployeeNames(ref Dictionary<String, HashSet<String>> foundNodes)
        {
            if (this.Employee.Name == "ROOT")
            {
                if (this.ChildEmployeeTreeNodes.Count > 0)
                {
                    int i = 0;
                    for (i = 0; i < this.ChildEmployeeTreeNodes.Count; i++)
                    {
                        this.ChildEmployeeTreeNodes[i].GetAllUniqueRolesAndEmployeeNames(ref foundNodes);
                    }
                }
                return;
            }

            if (foundNodes.ContainsKey(this.Employee.EmpRole))
            {
                foundNodes[this.Employee.EmpRole].Add(this.ParentEmployeeTreeNode.Employee.Name);
            }
            else
            {
                foundNodes.Add(this.Employee.EmpRole, new HashSet<String>());
                foundNodes[this.Employee.EmpRole].Add(this.ParentEmployeeTreeNode.Employee.Name);
            }

            if (this.ChildEmployeeTreeNodes.Count > 0)
            {
                int i = 0;
                for (i = 0; i < this.ChildEmployeeTreeNodes.Count; i++)
                {
                    this.ChildEmployeeTreeNodes[i].GetAllUniqueRolesAndEmployeeNames(ref foundNodes);
                }
            }
        }

        // Key = UUID, Value = 
        public void GetAllLeaders(ref List<EmployeeTreeNode> leaderList, RoleTreeNode _roleTreeStructure)
        {
            if (this.Employee.Name == "ROOT")
            {
                if (this.ChildEmployeeTreeNodes.Count > 0)
                {
                    int i = 0;
                    for (i = 0; i < this.ChildEmployeeTreeNodes.Count; i++)
                    {
                        this.ChildEmployeeTreeNodes[i].GetAllLeaders(ref leaderList, _roleTreeStructure);
                    }
                }
                return;
            }
            List<RoleTreeNode> roleTreeNodes = new List<RoleTreeNode>();
            String empRoleId = (this.Employee.isSecondary) ? this.Employee.EmpRoleUUID2 : this.Employee.EmpRoleUUID;

            _roleTreeStructure.SearchByUUID(empRoleId, ref roleTreeNodes);
            if (roleTreeNodes.Count > 0)
            {
                if (roleTreeNodes[0].isLeader)
                { 
                    this.Revenue = this.Employee.Salary; //parent check all child, then add all children salary
                    if (this.ChildEmployeeTreeNodes.Count > 0)
                    {
                        int i = 0;
                        for (i = 0; i < this.ChildEmployeeTreeNodes.Count; i++)
                        {
                            this.Revenue += this.ChildEmployeeTreeNodes[i].Employee.Salary;
                        }
                    }
                    EmployeeTreeNode parentEmp = this.ParentEmployeeTreeNode;
                    while(parentEmp.Employee.EmpRole != "ROOT")
                    {
                        this.Revenue += parentEmp.Employee.Salary; 
                        parentEmp = parentEmp.ParentEmployeeTreeNode;
                    }
                    leaderList.Add(this);
                }
                else
                {
                    if (this.ChildEmployeeTreeNodes.Count > 0)
                    {
                        int i = 0;
                        for (i = 0; i < this.ChildEmployeeTreeNodes.Count; i++)
                        {
                            this.ChildEmployeeTreeNodes[i].GetAllLeaders(ref leaderList, _roleTreeStructure);
                        }
                    }
                }
            }
        }
    }
}
