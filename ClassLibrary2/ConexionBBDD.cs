using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class ConexionBBDD
    {
        private string str = "select descripción from dbo.NotasInformativas";

        private SqlConnection myconn = new SqlConnection(ConfigurationManager.ConnectionStrings["PoC"].ConnectionString);

        public List<string> LeerDatos()
        {
            List<string> result = null;

            SqlCommand myCommand = new SqlCommand(str, myconn);
            try
            {
                myconn.Open();
                SqlDataReader sqlData = myCommand.ExecuteReader();

                while (sqlData.Read())
                {
                    if (result == null )
                    {
                        result = new List<string>();
                    }
                    
                    result.Add(sqlData.GetString(0));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (myconn.State == System.Data.ConnectionState.Open)
                {
                    myconn.Close();
                }
            }

            return result;
        }

    }
}
