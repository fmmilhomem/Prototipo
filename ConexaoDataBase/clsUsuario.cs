using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexaoDataBase;
using System.Data.SqlClient;
using System.Data;

namespace ConexaoDataBase
{
    public class clsUsuario
    {
        public int idUsuario { get; set; }
        public string loginUsuario { get; set; }
        public string senhaUsuario { get; set; }
        public string nomeUsuario { get; set; }
        public string tipoPerfil { get; set; }
        public bool usuarioAtivo { get; set; }


        public clsUsuario LogarDB(string login, string senha)
        {
            clsConn conn = new clsConn();
            clsUsuario u = null;

            try
            {
                string sql = (@"SELECT idUsuario ,loginusuario,senhausuario,tipoperfil from usuario where usuarioativo=1 and loginusuario = @login and senhausuario = @senha");
                SqlConnection cn = clsConn.Conectar();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;

                SqlDataReader dr = cmd.ExecuteReader();
                u = new clsUsuario();
                dr.Read();

                u.loginUsuario = dr.GetString(dr.GetOrdinal("loginUsuario"));
                u.senhaUsuario = dr.GetString(dr.GetOrdinal("senhaUsuario"));
                u.idUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
            }
            catch (InvalidOperationException e)
            {
                u = null;
            }
            return u;
        }

    }
}
