using DatabaseCommunication.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCommunication.Repositories
{
    public class CompanyLevelRepository
    {
        public Dictionary<int,string> DepartmentData { get;private set; }

        public DbEnum.DBResposeType GetCompanyLevelData()
        {
            DepartmentData = new Dictionary<int, string>();
            DbEnum.DBResposeType resposeType;
            using (SqlConnection connection = new SqlConnection(Settings1.Default.ConnString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT [DepartmentID],[DepartmentName]      
                                                FROM [DepartmentStructure].[dbo].[Department]";
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    DepartmentData.Add(reader.GetInt32(0), reader.GetString(1));
                                }
                            }
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
    }
}
