using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoDataBase
{
    class clsConn
    {
        //CONEXÃO LOCAL
        public static SqlConnection Conectar()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.UserID = "sa";
            sb.Password = "123456";
            sb.DataSource = "FISCHER2016NEW\\SQLEXPRESS";
            sb.InitialCatalog = "LOJA";

            SqlConnection cn = new SqlConnection(sb.ConnectionString);
            cn.Open();
            return cn;
        }
        /*
        //CONEXÃO AZURE
        public static SqlConnection Conectar()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.UserID = "TSI";
            sb.Password = "SistemasInternet123";
            sb.DataSource = "hippo-pi.database.windows.net";
            sb.InitialCatalog = "hippo";

            SqlConnection cn = new SqlConnection(sb.ConnectionString);
            try
            {
                cn.Open();
            }
            catch (SqlException e)
            {
                //
            }
            return cn;
        }*/
         
    }
}
