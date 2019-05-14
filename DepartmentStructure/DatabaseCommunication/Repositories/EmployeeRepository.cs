using DatabaseCommunication.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseCommunication.Properties;
using System.Diagnostics;
using System.Data;

namespace DatabaseCommunication.Repositories
{
    public class EmployeeRepository
    {

        public Employee GetEmployeeByID(int employeeID)
        {
            Employee employee = new Employee();
            using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT * FROM Employee
                                            WHERE EmployeeID = @EmployeeID";

                        command.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = employeeID;
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    employee.EmployeeID = reader.GetInt32(0);
                                    employee.Title = reader.GetString(1);
                                    employee.Name = reader.GetString(2);
                                    employee.Surname = reader.GetString(3);
                                    employee.Phone = reader.GetString(4);
                                    employee.Mail = reader.GetString(5);
                                    employee.DepartmentID = reader.GetInt32(6);
                                }
                            }
                        }

                        catch (SqlException e)
                        {
                            Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                            Debug.WriteLine(e.ToString());
                        }

                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                    return employee;
                }                
            }
            return employee;
        }

        /// <summary>
        /// Method to add new Employee.
        /// </summary>
        /// <param name="newEmployee"></param>
        /// <returns></returns>
        public DbEnum.DBResposeType AddEmployee(Employee newEmployee)
        {
            DbEnum.DBResposeType dBRespose;
            using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"INSERT INTO Employee (Title,Name,Surname,Phone,Mail,DepartmentID)
                                                VALUES (@title,@name,@surname,@phone,@mail,@department);

                                                SELECT @@IDENTITY";
                        command.Parameters.Add("@title", SqlDbType.NVarChar).Value = (object)newEmployee.Title ?? DBNull.Value;
                        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = newEmployee.Name;
                        command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = newEmployee.Surname;
                        command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = newEmployee.Phone;
                        command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = newEmployee.Mail;
                        command.Parameters.Add("@department", SqlDbType.Int).Value = (object)newEmployee.DepartmentID ?? DBNull.Value;

                        try
                        {
                            if (command.ExecuteNonQuery() > 0)
                            {
                                dBRespose = DbEnum.DBResposeType.OK;
                            }
                            else
                            {
                                dBRespose = DbEnum.DBResposeType.NotOK;
                            }                            
                        }

                        catch (SqlException e)
                        {
                            Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                            Debug.WriteLine(e.ToString());
                            dBRespose = DbEnum.DBResposeType.SQLError;
                        }
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                    dBRespose = DbEnum.DBResposeType.ConnectionError;
                }                
            }
            return dBRespose;
        }

        public DataSet ViewAllEmployee(int companyID)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @" SELECT em.[EmployeeID]
                                        ,[Title]
                                        ,[Name]
                                        ,[Surname]
                                        ,[Phone]
                                        ,[Mail]
                                        ,em.[DepartmentID]
                                        FROM [DepartmentStructure].[dbo].[Employee] as em
										join Department as d on em.departmentid = d.departmentid
                                        where IDcompany = @company;";
                        command.Parameters.Add("@company", SqlDbType.Int).Value = companyID;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(ds, "Employee");
                        DataTable dt = ds.Tables["Employee"];
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return ds;
        }

        /// <summary>
        /// Method to update Employee.
        /// </summary>
        /// <param name="newEmployee"></param>
        /// <returns></returns>
        public DbEnum.DBResposeType UpdateEmployee(Employee newEmployee)
        {
            DbEnum.DBResposeType resposeType;
            using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"Update Employee
                                                set Title = @title,
                                                Name = @name,
                                                Surname = @surname,
                                                Phone = @phone,
                                                Mail = @mail,
                                                DepartmentID = @department
                                                where EmployeeID = @employeeID";

                        command.Parameters.Add("@title", SqlDbType.NVarChar).Value = (object)newEmployee.Title ?? DBNull.Value;
                        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = newEmployee.Name;
                        command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = newEmployee.Surname;
                        command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = newEmployee.Phone;
                        command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = newEmployee.Mail;
                        command.Parameters.Add("@department", SqlDbType.Int).Value = newEmployee.DepartmentID;
                        command.Parameters.Add("@employeeID", SqlDbType.Int).Value = newEmployee.EmployeeID;
                        try
                        {
                            if (command.ExecuteNonQuery() > 0)
                            {
                                resposeType = DbEnum.DBResposeType.OK;
                            }
                            else
                            {
                                resposeType = DbEnum.DBResposeType.NotOK;
                            }
                        }

                        catch (SqlException e)
                        {
                            Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                            Debug.WriteLine(e.ToString());
                            resposeType = DbEnum.DBResposeType.SQLError;
                        }
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                    resposeType = DbEnum.DBResposeType.ConnectionError;
                }

            }
            return resposeType;
        }

        /// <summary>
        /// Method to delete employee.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public DbEnum.DBResposeType DeleteEmployee(int employeeID)
        {
            DbEnum.DBResposeType resposeType;
            using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"Delete from Employee where EmployeeID = @employeeID;";
                        command.Parameters.Add("@employeeID", SqlDbType.Int).Value =employeeID;                        
                        try
                        {
                            if (command.ExecuteNonQuery() > 0)
                            {
                                resposeType = DbEnum.DBResposeType.OK;
                            }
                            else
                            {
                                resposeType = DbEnum.DBResposeType.NotOK;
                            }
                        }

                        catch (SqlException e)
                        {
                            Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                            Debug.WriteLine(e.ToString());
                            resposeType = DbEnum.DBResposeType.SQLError;
                        }
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                    resposeType = DbEnum.DBResposeType.ConnectionError;
                }      
            }
            return resposeType;
        }

        public List<Employee> GetEmployeeList()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT [EmployeeID],[Name],[Surname]      
                                                FROM [DepartmentStructure].[dbo].[Employee]";

                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Employee employee= new Employee();
                                    employee.EmployeeID = reader.GetInt32(0);
                                    employee.Name = reader.GetString(1);
                                    employee.Surname = reader.GetString(2);
                                    employees.Add(employee);
                                }
                            }
                        }

                        catch (SqlException e)
                        {
                            Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                            Debug.WriteLine(e.ToString());

                        }

                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                }
            }
            return employees;
        }
    }
}
