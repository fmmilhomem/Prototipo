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
        public static SqlConnection Conectar()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.UserID = "sa";
            sb.Password = "123456";
            sb.DataSource = "localhost";
            sb.InitialCatalog = "LOJA";

            SqlConnection cn = new SqlConnection(sb.ConnectionString);
            cn.Open();
            return cn;
        }
    }
}
