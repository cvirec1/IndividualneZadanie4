using DatabaseCommunication;
using DatabaseCommunication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentLogic
{
    public class DepartmentFunction
    {
        public Employee GetEmployeeByID(int employeeID)
        {
            return RepositoryManager.EmployeeRepository.GetEmployeeByID(employeeID);
        }

        public DBResult AddEmployee(Employee employee)
        {
            DBResult result = new DBResult();
            result.DBResultEnum = RepositoryManager.EmployeeRepository.AddEmployee(employee);
            switch (result.DBResultEnum)
            {
                case DbEnum.DBResposeType.OK:
                    result.DBResultMessage = "Succes add new employee.";
                    break;
                case DbEnum.DBResposeType.ConnectionError:
                    result.DBResultMessage = "Connection error. Please check your SQL connection!";
                    break;
                case DbEnum.DBResposeType.SQLError:
                    result.DBResultMessage = "SQL query syntax problem!";
                    break;
                default:
                    break;
            }
            return result;
        }

        public DBResult UpdateEmployee(Employee employee)
        {
            DBResult result = new DBResult();
            result.DBResultEnum = RepositoryManager.EmployeeRepository.UpdateEmployee(employee);
            switch (result.DBResultEnum)
            {
                case DbEnum.DBResposeType.OK:
                    result.DBResultMessage = "Succes update employee.";
                    break;
                case DbEnum.DBResposeType.ConnectionError:
                    result.DBResultMessage = "Connection error. Please check your SQL connection!";
                    break;
                case DbEnum.DBResposeType.SQLError:
                    result.DBResultMessage = "SQL query syntax problem!";
                    break;
                default:
                    break;
            }
            return result;
        }

        public DBResult DeleteEmployee(int employeeID)
        {
            DBResult result = new DBResult();
            result.DBResultEnum = RepositoryManager.EmployeeRepository.DeleteEmployee(employeeID);
            switch (result.DBResultEnum)
            {
                case DbEnum.DBResposeType.OK:
                    result.DBResultMessage = "Succes delete employee" +
                        ".";
                    break;
                case DbEnum.DBResposeType.ConnectionError:
                    result.DBResultMessage = "Connection error. Please check your SQL connection!";
                    break;
                case DbEnum.DBResposeType.SQLError:
                    result.DBResultMessage = "SQL query syntax problem!";
                    break;
                default:
                    break;
            }
            return result;
        }

        public DataSet GetAllCompanies()
        {
            return RepositoryManager.DepartmentRepository.ViewAllCompany();
        }

        public DBResult AddDepartment(Department department)
        {
            DBResult result = new DBResult();
            result.DBResultEnum = RepositoryManager.DepartmentRepository.AddCompany(department);
            switch (result.DBResultEnum)
            {
                case DbEnum.DBResposeType.OK:
                    result.DBResultMessage = "Succes add new company.";
                    break;
                case DbEnum.DBResposeType.ConnectionError:
                    result.DBResultMessage = "Connection error. Please check your SQL connection!";
                    break;
                case DbEnum.DBResposeType.SQLError:
                    result.DBResultMessage = "SQL query syntax problem!";
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
