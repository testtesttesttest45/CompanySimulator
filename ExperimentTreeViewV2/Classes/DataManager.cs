using System;
using System.Collections.Generic;
using System.Diagnostics;
//namespace for file io
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

//namespace the the Application class
using System.Windows.Forms;

namespace ExperimentTreeViewV2.Classes
{
    [Serializable]
    internal class DataManager : ISerializable
    //******************************** IMPORTANT *********************************************
    //About DataManager
    //You should manage all the employee data, role data and project data by applying code
    //in this DataManager instead of having seperate RoleManager, EmployeeManager and ProjectManager class
    //****************************************************************************************
    {

        RoleTreeNode _roleTreeStructure;
        EmployeeTreeNode _employeeTreeStructure;
        public List<Dictionary<String, String>> ProjectList = new List<Dictionary<String, String>>();
        private string _filePath; // Saved data file path
        //private string _filePath2; // Saved data file path
        public DataManager()
        {
            _filePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Data.dat";
            _roleTreeStructure = new RoleTreeNode(new Role("ROOT"));
            _employeeTreeStructure = new EmployeeTreeNode(new Employee("ROOT", 0,"",""));
        }
        protected DataManager(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");

            this._roleTreeStructure = (RoleTreeNode)info.GetValue("RoleTree", typeof(RoleTreeNode));
            this._employeeTreeStructure = (EmployeeTreeNode)info.GetValue("EmployeeTree", typeof(EmployeeTreeNode));
            try
            {
                this.ProjectList = (List<Dictionary<string, string>>)info.GetValue("ProjectList", typeof(List<Dictionary<string, string>>));
            }
            catch (Exception)
            {
                this.ProjectList = new List<Dictionary<string, string>>();
            }

        }
        public RoleTreeNode GenerateEmptyTreeStructure()
        {
            _roleTreeStructure = new RoleTreeNode(new Role("ROOT"));
            return _roleTreeStructure;
        }
        public EmployeeTreeNode GenerateEmptyEmployeeStructure()
        {
            _employeeTreeStructure = new EmployeeTreeNode(new Employee("ROOT", 0,"ROOT", "ROOT"));
            return _employeeTreeStructure;
        }

        public RoleTreeNode GenerateFakeTreeStructure()
        {
            _roleTreeStructure = new RoleTreeNode(new Role("ROOT"));
            Role role1 = new Role("Clusterhead");
            RoleTreeNode node1 = new RoleTreeNode(role1);
            _roleTreeStructure.AddChildRoleTreeNode(node1);
            Role role2 = new Role("Manager");
            RoleTreeNode node2 = new RoleTreeNode(role2);
            node1.AddChildRoleTreeNode(node2);
            Role role3 = new Role("Project Manager");
            RoleTreeNode node3 = new RoleTreeNode(role3);
            node2.AddChildRoleTreeNode(node3);
            Role role4 = new Role("Project Leader");
            RoleTreeNode node4 = new RoleTreeNode(role4);
            node3.AddChildRoleTreeNode(node4);
            Role role5 = new Role("Backend Developer");
            RoleTreeNode node5 = new RoleTreeNode(role5);
            node4.AddChildRoleTreeNode(node5);
            Role role6 = new Role("Frontend Developer");
            RoleTreeNode node6 = new RoleTreeNode(role6);
            node4.AddChildRoleTreeNode(node6);
            Role role7 = new Role("Data Engineer");
            RoleTreeNode node7 = new RoleTreeNode(role7);
            node4.AddChildRoleTreeNode(node7);
            Role role8 = new Role("System Analyst");
            RoleTreeNode node8 = new RoleTreeNode(role8);
            node4.AddChildRoleTreeNode(node8);

            return _roleTreeStructure;
        }//end of GenerateFakeTreeStructure

        public RoleTreeNode RoleTreeStructure
        {
            get { return _roleTreeStructure; }
            set { _roleTreeStructure = value; }
        }
        public EmployeeTreeNode EmployeeTreeStructure
        {
            get { return _employeeTreeStructure; }
            set { _employeeTreeStructure = value; }
        }
        //public void SaveRoleData()
        //{
        //    this.RoleTreeStructure.SaveToFileBinary(_filePath);
        //}//end of SaveRoleData
        //public void SaveEmployeeData()
        //{
        //    this.EmployeeTreeStructure.SaveToFileBinary(_filePath);
        //}//end of SaveEmployeeData

        //public RoleTreeNode LoadRoleData()
        //{
        //    this.RoleTreeStructure = this.RoleTreeStructure.ReadFromFileBinary(_filePath);
        //    this.RoleTreeStructure.RebuildTreeNodes();
        //    return this.RoleTreeStructure;

        //} //end of LoadRoleData method
        //public EmployeeTreeNode LoadEmployeeData()
        //{
        //    this.EmployeeTreeStructure = this.EmployeeTreeStructure.ReadFromFileBinary(_filePath);
        //    this.EmployeeTreeStructure.RebuildTreeNodes();
        //    return this.EmployeeTreeStructure;

        //}
        //end of LoadEmployeeData method
        public void SaveEntireData()
        {
            SaveToFileBinary(_filePath);

        }
        public void LoadEntireData()
        {
            DataManager dm = ReadFromFileBinary(_filePath);
            this._roleTreeStructure = dm._roleTreeStructure;
            this._employeeTreeStructure = dm._employeeTreeStructure;
            this.ProjectList = dm.ProjectList;
            this.RoleTreeStructure.RebuildTreeNodes();
            this.EmployeeTreeStructure.RebuildTreeNodes();
            // setup the project names
            foreach (Dictionary<String, String> project in this.ProjectList)
            {
                List<EmployeeTreeNode> searchResult = new List<EmployeeTreeNode>();
                this._employeeTreeStructure.SearchByUUID(project["LeaderUUID"], ref searchResult);
                EmployeeTreeNode leader = searchResult[0];
                leader.EmpProjectList.Add(project["ProjectName"]);
                if (leader.ChildEmployeeTreeNodes.Count > 0)
                {
                    for (int i = 0; i < leader.ChildEmployeeTreeNodes.Count; i++)
                    {
                        leader.ChildEmployeeTreeNodes[i].EmpProjectList.Add(project["ProjectName"]);
                    }
                }
                EmployeeTreeNode parentEmp = leader.ParentEmployeeTreeNode;
                while (parentEmp.Employee.EmpRole != "ROOT")
                {
                    parentEmp.EmpProjectList.Add(project["ProjectName"]);
                    parentEmp = parentEmp.ParentEmployeeTreeNode;
                }
            }
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //add the required data to file
            info.AddValue("RoleTree", _roleTreeStructure);
            info.AddValue("EmployeeTree", _employeeTreeStructure);
            info.AddValue("ProjectList", ProjectList);
        }

       
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

        }//end of class RoleManager
        public DataManager ReadFromFileBinary(string filepath)
        {
            try
            {
                Stream stream = new FileStream(@filepath, FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                DataManager root = null;
                if (stream.Length != 0)
                {
                    root = (DataManager)bf.Deserialize(stream);
                }
                stream.Close();

                return root;
            }
            catch (FileNotFoundException)
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
    }//end of namespace
}
