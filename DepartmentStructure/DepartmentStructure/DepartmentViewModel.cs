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

        public DepartmentViewModel()
        {
            NewDepartment = new Department();
        }

        public void AddDepartment()
        {
            ActionResult = _departmentFunction.AddDepartment(NewDepartment);
        }


    }
}
