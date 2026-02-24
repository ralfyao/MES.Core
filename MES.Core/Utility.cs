using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core
{
    public class Utility
    {

        public static DataSet getDataSet(string connStr, string strSQL)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand sqlCommand = conn.CreateCommand();
                    sqlCommand.CommandText = strSQL;
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public static string ConvertDate(string data)
        {
            return !string.IsNullOrEmpty(data) ? DateTime.ParseExact(data, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy/MM/dd") : "";
        }
    }
}
