﻿using System;
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


            string sql = (@"SELECT idUsuario, nomeusuario, loginusuario, senhausuario, tipoperfil 
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
                u.Nome = dr.GetString(dr.GetOrdinal("nomeUsuario"));
                u.Tipo = dr.GetString(dr.GetOrdinal("tipoPerfil"));

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
                //return Usuarios = null; 
            }
            return Usuarios;            
        }

        public static List<clsUsuario> ConsultarPorUsuario(string Usuario)
        {
            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            string sql = @"SELECT idusuario, nomeusuario ,loginusuario, senhausuario, tipoperfil, usuarioativo
                           FROM usuario WHERE loginusuario = @Usuario";

            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usuario;
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsUsuario> Usuarios = new List<clsUsuario>();

            try
            {
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
                //return Usuarios = null; 
            }
            return Usuarios;
        }

        public void Salvar()
        {
            bool inserir = (this.ID == 0);

            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            if (inserir)
                cmd.CommandText = @"INSERT INTO usuario 
                                    (nomeusuario, loginusuario, senhausuario, tipoperfil, usuarioativo)
                                    VALUES 
                                    (@Nome, @Usuario, @Senha, @Tipo, @Ativo)";
            else
            {
                cmd.CommandText = @"UPDATE usuario 
                                    SET nomeusuario = @Nome, 
                                    loginusuario = @Usuario, 
                                    senhausuario = @Senha, 
                                    tipoperfil = @Tipo, 
                                    usuarioativo = @Ativo
                                    WHERE idusuario = @ID";

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            }

            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = this.Nome;
            cmd.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = this.Usuario;
            cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = this.Senha;
            cmd.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = this.Tipo;
            cmd.Parameters.Add("@Ativo", SqlDbType.Bit).Value = this.Ativo;
            cmd.ExecuteNonQuery();

            if (inserir)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT @@Identity";
                this.ID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            cn.Close();
            cn.Dispose();
        }

        public void Deletar()
        {
            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = @"DELETE FROM usuario 
                                WHERE idusuario = @ID";

            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {

            }
            cn.Close();
            cn.Dispose();
        }
    }
}
