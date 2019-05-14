using DatabaseCommunication;
using DatabaseCommunication.Models;
using DepartmentLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStructure
{
    class DepartmentViewModel
    {
        private DepartmentFunction _departmentFunction = new DepartmentFunction();
        public DBResult ActionResult { get; private set; }
        public Department NewDepartment { get; set; }
        public Dictionary<int,string> CompanyLevelList { get; private set; }
        public List<Department> DepartmentList { get; private set; }
        public List<Employee> EmployyeList { get; private set; }
        public int CompanyID { get; set; }


        public DepartmentViewModel()
        {
            NewDepartment = new Department();
            GetAllCompanyLevel();
            GetAllEmployees();
        }

        public void AddDepartment()
        {
            ActionResult = _departmentFunction.AddDepartment(NewDepartment);
        }

        public void GetAllCompanyLevel()
        {
            CompanyLevelList = _departmentFunction.GetAllCompanyLevel();
        }

        public void GetAllDepartments(int id)
        {
            DepartmentList = _departmentFunction.GetAllDepartmentList(id,CompanyID);
        }

        public void GetAllEmployees()
        {
            EmployyeList = _departmentFunction.GetAllEmployeeList();
        }


    }
}
