using DatabaseCommunication.Properties;
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

        //public static void SetConnectionString(string serverName)
        //{
        //    var ret = Settings1.Default.ConnString.Split(' ');
        //    ret[2] = serverName +";" ;
        //    StringBuilder sb = new StringBuilder();
        //    foreach(var item in ret)
        //    {
        //        sb.Append(item);
        //        sb.Append(" ");
        //    }
            
        //}
    }
}
