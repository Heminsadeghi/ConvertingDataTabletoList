using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertingDataTabletoList.DB
{
    public class DataBaseCommon
    {
        public DataTable GetData(string connectionString, string TableName, string Columns)
        {
            DataTable dtPerson = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "select " + Columns + " from  " + TableName;
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
                try
                {
                    da.Fill(dtPerson);

                }
                catch (Exception ex)
                {
                    con.Close();
                }
            }
            return dtPerson;
        }

    }

}
