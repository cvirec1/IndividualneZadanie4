using DatabaseCommunication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseCommunication.Properties;

namespace DatabaseCommunication.Repositories
{
    public class DepartmentRepository
    {
        public Department GetDepartmentByID(int departmentID)
        {
            Department department = new Department();
            using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT * FROM [DepartmentStructure].[dbo].[Department]
                                                where DepartmentID = @departmentID";

                        command.Parameters.Add("@departmentID", SqlDbType.Int).Value = departmentID;
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    department.DepartmentID= reader.GetInt32(0);
                                    department.DepartmentName = reader.GetString(1);
                                    department.DepartmentCode = reader.GetString(2);
                                    department.HeadDepartment = reader.GetInt32(3);
                                    department.CompanyLevelData.CompanyLevelID = reader.GetInt32(4);
                                    department.IdCompany = reader.GetInt32(5);
                                    department.EmployeeData.EmployeeID = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6);
                                    
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
            return department;
        }

        public DataSet ViewAllCompany()
        {
            string sqlQuery = @"  SELECT dep.[DepartmentID]		                        
                                ,[DepartmentName]
                                ,[DepartmentCode]	  
	                            ,concat(emp.name,' '
	                            ,emp.surname )as HeadOF
	                            FROM [DepartmentStructure].[dbo].[Department] as dep
	                            left join Employee as emp on dep.employeeID=emp.employeeID
                                where companyLevelID = 1;";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
                {
                    connection.Open();
                    using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
                        adapter.Fill(ds, "Company");
                        DataTable dt = ds.Tables["Company"];
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return ds;
        }

        public DataSet ViewCompany(int companyID)
        {
            string sqlQuery = @"  SELECT dep.[DepartmentID]		                        
                                ,[DepartmentName]
                                ,[DepartmentCode]	  
	                            ,concat(emp.name,' '
	                            ,emp.surname )as HeadOF
	                            FROM [DepartmentStructure].[dbo].[Department] as dep
	                            left join Employee as emp on dep.employeeID=emp.employeeID
                                where dep.[DepartmentID] = @companyID;";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add("@companyID", SqlDbType.Int).Value = companyID;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(ds, "Company");
                        DataTable dt = ds.Tables["Company"];
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return ds;
        }

        public DataSet ViewAllDivision(int companyID)
        {
            string sqlQuery = @"  SELECT dep.[DepartmentID]		                        
                                ,[DepartmentName]
                                ,[DepartmentCode]	  
	                            ,concat(emp.name,' '
	                            ,emp.surname )as HeadOF
	                            FROM [DepartmentStructure].[dbo].[Department] as dep
	                            left join Employee as emp on dep.employeeID=emp.employeeID
                                where companyLevelID = 2 and idcompany = @company;";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add("@company", SqlDbType.Int).Value = companyID;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(ds, "Division");
                        DataTable dt = ds.Tables["Division"];
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return ds;
        }

        public DataSet ViewAllProject(int companyID)
        {
            string sqlQuery = @"  SELECT dep.[DepartmentID]		                        
                                ,[DepartmentName]
                                ,[DepartmentCode]	  
	                            ,concat(emp.name,' '
	                            ,emp.surname )as HeadOF
	                            FROM [DepartmentStructure].[dbo].[Department] as dep
	                            left join Employee as emp on dep.employeeID=emp.employeeID
                                where companyLevelID = 3 and idcompany = @company;";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add("@company", SqlDbType.Int).Value = companyID;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(ds, "Project");
                        DataTable dt = ds.Tables["Project"];
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return ds;
        }

        public DataSet ViewAllDepartment(int companyID)
        {
            string sqlQuery = @"  SELECT dep.[DepartmentID]		                        
                                ,[DepartmentName]
                                ,[DepartmentCode]	  
	                            ,concat(emp.name,' '
	                            ,emp.surname )as HeadOF
	                            FROM [DepartmentStructure].[dbo].[Department] as dep
	                            left join Employee as emp on dep.employeeID=emp.employeeID
                                where companyLevelID = 4 and idcompany = @company;";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add("@company", SqlDbType.Int).Value = companyID;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(ds, "Department");
                        DataTable dt = ds.Tables["Department"];
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return ds;
        }

        public DbEnum.DBResposeType AddCompany(Department department)
        {
            DbEnum.DBResposeType dBRespose;
            using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"insert into department (DepartmentName,DepartmentCode,HeadDepartment,CompanyLevelID,EmployeeID,IDCompany)
                                                output inserted.DepartmentID values (@name,@code,@head,@company,@employee,@IDcompany);";
                        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = department.DepartmentName;
                        command.Parameters.Add("@code", SqlDbType.NVarChar).Value = department.DepartmentCode;
                        command.Parameters.Add("@head", SqlDbType.Int).Value = (object)department.HeadDepartment ?? DBNull.Value;
                        command.Parameters.Add("@company", SqlDbType.Int).Value = department.CompanyLevelData.CompanyLevelID;
                        command.Parameters.Add("@employee", SqlDbType.Int).Value = (object)department.EmployeeData.EmployeeID ?? DBNull.Value;
                        command.Parameters.Add("@IDcompany", SqlDbType.Int).Value = (object)department.IdCompany ?? DBNull.Value;
                        try
                        {
                            int insertedid = (int)command.ExecuteScalar();
                            if (department.IdCompany == null)
                            {
                                UpdateCompanyID(insertedid);
                            }
                            if (insertedid > 0)
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

        public bool UpdateCompanyID(int companyID)
        {
            using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"Update Department
                                                set  IDCompany = @company
                                                where DepartmentID = @departmentID;";
                        
                        command.Parameters.Add("@company", SqlDbType.Int).Value = companyID;
                        command.Parameters.Add("@departmentID", SqlDbType.Int).Value = companyID;

                        try
                        {
                            if (command.ExecuteNonQuery() > 0)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
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
            return false;
        }

        public DbEnum.DBResposeType UpdateCompany(Department department)
        {
            DbEnum.DBResposeType dBRespose;
            using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"Update Department
                                                set DepartmentName = @name,
                                                DepartmentCode = @code,
                                                HeadDepartment = @head,
                                                CompanyLevelID = @company,
                                                EmployeeID = @employee
                                                where DepartmentID = @departmentID;";
                        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = department.DepartmentName;
                        command.Parameters.Add("@code", SqlDbType.NVarChar).Value = department.DepartmentCode;
                        command.Parameters.Add("@head", SqlDbType.Int).Value = (object)department.HeadDepartment ?? DBNull.Value;
                        command.Parameters.Add("@company", SqlDbType.Int).Value = department.CompanyLevelData.CompanyLevelID;
                        command.Parameters.Add("@employee", SqlDbType.Int).Value = (object)department.EmployeeData.EmployeeID ?? DBNull.Value;
                        command.Parameters.Add("@departmentID", SqlDbType.NVarChar).Value = department.DepartmentID;
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

        public List<Department> GetDepartmentList(int id,int companyID)
        {
            List<Department> departments = new List<Department>();
            using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
            {
                try
                {
                    connection.Open();

                    using(SqlCommand command = connection.CreateCommand())
                {
                        command.CommandText = @"SELECT [DepartmentID],[DepartmentName]      
                                                FROM [DepartmentStructure].[dbo].[Department]
                                                where CompanyLevelID = @id and IDcompany = @company";
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        command.Parameters.Add("@company", SqlDbType.Int).Value = companyID;

                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Department department= new Department();
                                    department.DepartmentID = reader.GetInt32(0);
                                    department.DepartmentName = reader.GetString(1);                                    
                                    departments.Add(department);
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
            return departments;
        }

    }
}
