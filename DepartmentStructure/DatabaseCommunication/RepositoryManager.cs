using DatabaseCommunication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCommunication
{
    public static class RepositoryManager
    {
        public static EmployeeRepository EmployeeRepository = new EmployeeRepository();
        public static DepartmentRepository DepartmentRepository = new DepartmentRepository();
        public static CompanyLevelRepository CompanyLevelRepository = new CompanyLevelRepository();
    }
}
