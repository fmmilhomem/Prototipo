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
        public int ID { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public bool Ativo { get; set; }


        public clsUsuario LogarDB(string login, string senha)
        {
            clsConn conn = new clsConn();
            clsUsuario u = null;


            string sql = (@"SELECT idUsuario, loginusuario, senhausuario, tipoperfil 
                            FROM usuario 
                            WHERE usuarioativo=1 AND loginusuario = @login AND senhausuario = @senha");
            try
            {
                SqlConnection cn = clsConn.Conectar();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;

                SqlDataReader dr = cmd.ExecuteReader();
                u = new clsUsuario();
                dr.Read();

                u.Usuario = dr.GetString(dr.GetOrdinal("loginUsuario"));
                u.Senha = dr.GetString(dr.GetOrdinal("senhaUsuario"));
                u.ID = dr.GetInt32(dr.GetOrdinal("idUsuario"));
      
                cn.Close();
                cn.Dispose();
            }
            catch (InvalidOperationException e)
            {
                u = null;
            }

            return u;
        }

        public static List<clsUsuario> ConsultarUsuario()
        {
            string sql = @"SELECT idusuario, nomeusuario ,loginusuario, senhausuario, tipoperfil, usuarioativo
                           FROM usuario";
            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsUsuario> Usuarios = new List<clsUsuario>();

            try
            {                
                dr.Read();

                while (dr.Read())
                {
                    clsUsuario u = new clsUsuario(); //Criar uma nova Lista
                    u.ID = dr.GetInt32(dr.GetOrdinal("idusuario"));
                    u.Nome = dr.GetString(dr.GetOrdinal("nomeusuario"));
                    u.Usuario = dr.GetString(dr.GetOrdinal("loginusuario"));
                    u.Senha = dr.GetString(dr.GetOrdinal("senhausuario"));
                    u.Tipo = dr.GetString(dr.GetOrdinal("tipoperfil"));
                    if (!dr.IsDBNull(dr.GetOrdinal("usuarioativo")))
                    {
                        u.Ativo = dr.GetBoolean(dr.GetOrdinal("usuarioativo"));
                    }
                    Usuarios.Add(u);
                }                         
                cn.Close();
                cn.Dispose();                
            }
            catch (InvalidOperationException e)
            {
                //
            }
            return Usuarios;            
        }
    }
}
