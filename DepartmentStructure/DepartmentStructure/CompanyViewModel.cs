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
    public class CompanyViewModel
    {
        private DepartmentFunction _departmentFunction = new DepartmentFunction();
        
        public DBResult ActionResult { get; private set; }
                

        public DataSet GetAllCompanies()
        {
            return _departmentFunction.GetAllCompanies();
        }

        
    }
}
