using DatabaseCommunication;
using DatabaseCommunication.Models;
using DepartmentLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStructure
{
    class MainViewModel
    {
        private DepartmentFunction _departmentFunction = new DepartmentFunction();
        public Employee Employee { get; private set; }
        public Employee NewEmployee { get; set; }
        public DBResult ActionResult { get; private set; }
        public int CompanyID{ get; set; }
        //public int DivisionID { get; set; }
        //public int ProjectID { get; set; }
        public int DepartmentID { get; set; }

        public DataSet GetAllEmployees()
        {
            return _departmentFunction.GetAllEmployees(CompanyID);
        }

        public DataSet GetCompany()
        {
            return _departmentFunction.GetCompany(CompanyID);
        }

        public DataSet GetAllDivision()
        {
            return _departmentFunction.GetAllDivision(CompanyID);
        }

        public DataSet GetAllProject()
        {
            return _departmentFunction.GetAllProject(CompanyID);
        }

        public DataSet GetAllDepartment()
        {
            return _departmentFunction.GetAllDepartment(CompanyID);
        }

        public void DeleteEmployee(int employeeID)
        {
            ActionResult = _departmentFunction.DeleteEmployee(employeeID);
        }
    }
}
