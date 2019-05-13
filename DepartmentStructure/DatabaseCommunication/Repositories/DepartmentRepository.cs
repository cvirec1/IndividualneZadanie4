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

        public DataSet ViewAllDivision(int companyID)
        {
            string sqlQuery = @"  SELECT dep.[DepartmentID]		                        
                                ,[DepartmentName]
                                ,[DepartmentCode]	  
	                            ,concat(emp.name,' '
	                            ,emp.surname )as HeadOF
	                            FROM [DepartmentStructure].[dbo].[Department] as dep
	                            left join Employee as emp on dep.employeeID=emp.employeeID
                                where companyLevelID = 2 and headdepartment = @companyID;";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
                {
                    connection.Open();
                    using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
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

        public DataSet ViewAllProject(int divisionID)
        {
            string sqlQuery = @"  SELECT dep.[DepartmentID]		                        
                                ,[DepartmentName]
                                ,[DepartmentCode]	  
	                            ,concat(emp.name,' '
	                            ,emp.surname )as HeadOF
	                            FROM [DepartmentStructure].[dbo].[Department] as dep
	                            left join Employee as emp on dep.employeeID=emp.employeeID
                                where companyLevelID = 3 and headdepartment = @divisionID;";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
                {
                    connection.Open();
                    using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
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

        public DataSet ViewAllDepartment(int projectID)
        {
            string sqlQuery = @"  SELECT dep.[DepartmentID]		                        
                                ,[DepartmentName]
                                ,[DepartmentCode]	  
	                            ,concat(emp.name,' '
	                            ,emp.surname )as HeadOF
	                            FROM [DepartmentStructure].[dbo].[Department] as dep
	                            left join Employee as emp on dep.employeeID=emp.employeeID
                                where companyLevelID = 4 and headdepartment = @projectID;";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
                {
                    connection.Open();
                    using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
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
                        command.CommandText = @"insert into department (DepartmentName,DepartmentCode,CompanyLevelID)
                                                values (@name,@code,1);";
                        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = department.DepartmentName;
                        command.Parameters.Add("@code", SqlDbType.NVarChar).Value = department.DepartmentCode;
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

    }
}
