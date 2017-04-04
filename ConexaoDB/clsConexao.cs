using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConexaoDB
{
    class clsConexao
    {
        public static SqlConnection Conectar()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.UserID = "sa";
            sb.Password = "123456";
            sb.DataSource = "localhost\\SQLEXPRESS";
            sb.InitialCatalog = "LOJA";

            SqlConnection cn = new SqlConnection(sb.ConnectionString);
            cn.Open();
            return cn;
        }
    }
}
