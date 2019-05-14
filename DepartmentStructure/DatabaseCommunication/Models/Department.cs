using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCommunication.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
        public int? HeadDepartment { get; set; }
        public int? IdCompany { get; set; }
        public CompanyLevel CompanyLevelData { get; set; }
        public Employee EmployeeData { get; set; }

        public Department()
        {
            CompanyLevelData = new CompanyLevel();
            EmployeeData = new Employee();
        }
    }
}
