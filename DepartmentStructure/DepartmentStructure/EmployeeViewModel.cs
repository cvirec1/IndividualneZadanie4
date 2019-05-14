using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseCommunication;
using DatabaseCommunication.Models;
using DepartmentLogic;

namespace DepartmentStructure
{
    public class EmployeeViewModel
    {
        private DepartmentFunction _departmentFunction = new DepartmentFunction();
        public Employee Employee { get; private set; }
        public Employee NewEmployee { get; set; }
        public DBResult ActionResult { get; private set; }
        public List<Department> DepartmentList { get; private set; }
        public int CompanyID { get; set; }

        private int _companyLevel = 4;
        public EmployeeViewModel(int employeeID)
        {
            Employee = _departmentFunction.GetEmployeeByID(employeeID);
        }

        public EmployeeViewModel()
        {
            NewEmployee = new Employee();
        }

        public void GetEmployeeByID(int employeeID)
        {
            Employee = _departmentFunction.GetEmployeeByID(employeeID);
        }

        public void AddEmployee()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(NewEmployee.Name+".");
            sb.Append(NewEmployee.Surname);
            sb.Append("@job.sk");
            NewEmployee.Mail = sb.ToString();
            ActionResult = _departmentFunction.AddEmployee(NewEmployee);
        }

        public void UpdateEmployee()
        {
            ActionResult = _departmentFunction.UpdateEmployee(Employee);
        }

        public void GetAllDepartments()
        {
            DepartmentList = _departmentFunction.GetAllDepartmentList(_companyLevel, CompanyID);
        }
    }
}
