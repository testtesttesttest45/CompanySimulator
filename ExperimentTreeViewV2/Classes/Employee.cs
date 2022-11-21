using System;
using System.Collections.Generic;
using System.Text;

namespace ExperimentTreeViewV2.Classes
{
    [Serializable]
    public class Employee
    {
        private string _uuid; // employee UUID
        private string _name; // employee Name
        private string _reportingOfficer; // Employee parent
        public bool isSecondary { get; set; }
       
        public string EmpRole { get; set; } //employee role
        public string EmpRoleUUID { get; set; } //employee role

        public string ReportingOfficer2 { get; set; } // Employee parent
        public string EmpRole2 { get; set; } //employee role
        public string EmpRoleUUID2 { get; set; } //employee role
        private int _salary;
        

        private EmployeeTreeNode _container; // References the EmployeeTreeNode object that contains the role
        
        private Employee()
        {
        }//end of constructor
        public Employee(Employee copyEmp)
        {
            _uuid = copyEmp.UUID;
            _name = copyEmp.Name;
            _salary = copyEmp.Salary;
            EmpRole = copyEmp.EmpRole;
            EmpRoleUUID = copyEmp.EmpRoleUUID;
            ReportingOfficer2 = copyEmp.ReportingOfficer2;
            EmpRole2 = copyEmp.EmpRole2;
            EmpRoleUUID2 = copyEmp.EmpRoleUUID2;
            isSecondary = copyEmp.isSecondary;

        }//end of copy constructor
        public Employee(string name, int salary, string role, string roleuuid)
        {
            _uuid = General.GenerateUUID();
            _name = name;
            this._salary =salary;
            EmpRole = role;
            EmpRoleUUID = roleuuid;
            EmpRole2 = "";
            EmpRoleUUID2 = "";
            ReportingOfficer2 = "";
            isSecondary = false;
        } // end of constructor
        //end of two constructors
        public EmployeeTreeNode Container
        {
            get { return _container; }
            set { _container = value; }
        }

        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        } // End of UUID property

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;

            }
        } // End of Name property
        public string Parent
        {
            get { return _reportingOfficer; }
            set { _reportingOfficer = value; }
        }
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public void EditRole(string name, int salary)
        {
            _name = name;
            _salary = salary;
        }// End of EditRole method
    }//end of Role class
}//end of namespace

