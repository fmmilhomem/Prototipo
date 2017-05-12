using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConexaoDataBase
{
    public class clsCategoria
    {
        public int idCategoria { get; set; }
        public string nomeCategoria { get; set; }
        public string descCategoria { get; set; }

        //Faz desse objeto um Singleton
        private static clsCategoria referencia;

        public static clsCategoria getInstance()
        {
            if (referencia == null)
                referencia = new clsCategoria();

            return referencia;
        }

        public static DataTable SelecionarCategoriaNome()
        {
            DataTable dtResultado = new DataTable();

            try
            {
                string sql = (@"SELECT idCategoria, nomeCategoria FROM categoria");
                SqlConnection cn = clsConn.Conectar();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;

                SqlDataReader dr = cmd.ExecuteReader();

                dtResultado.Clear();//limpa a table antes de preenche-la                  
                dtResultado.Load(dr);

                cn.Close();
                cn.Dispose();
            }
            catch (Exception e)
            {

            }
            return dtResultado;
         }

        public static string SelecionarCategoriaDesc(string nomeCategoria)
        {
            string descCategoria = "";
            try
            {
                string sql = (@"SELECT ISNULL(descCategoria, 'Não possui.') AS descCategoria FROM categoria WHERE nomeCategoria = @nomeCategoria");
                SqlConnection cn = clsConn.Conectar();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@nomeCategoria", SqlDbType.VarChar).Value = nomeCategoria;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    descCategoria = dr.GetString(dr.GetOrdinal("descCategoria"));
                }
                cn.Close();
                cn.Dispose();
            }
            catch (Exception e)
            {

            }
            return descCategoria;
        }

        public static int SelecionarCategoriaId(string nomeCategoria)
        {
            int idCategoria = 0;
            try
            {
                string sql = (@"SELECT idCategoria FROM categoria WHERE nomeCategoria = @nomeCategoria");
                SqlConnection cn = clsConn.Conectar();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@nomeCategoria", SqlDbType.VarChar).Value = nomeCategoria;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    idCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                }

                cn.Close();
                cn.Dispose();
            }
            catch (Exception e)
            {

            }
            return idCategoria;
        }

        public void Salvar(int idCategoria)
        {
            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "UPDATE categoria " +
                              "SET nomeCategoria = @nomeCategoria, " +
                              "descCategoria = @descCategoria " +
                              "WHERE idCategoria = @idCategoria";
            cmd.Parameters.Add("idCategoria", SqlDbType.Int).Value = idCategoria;

            cmd.Parameters.Add("@nomeCategoria", SqlDbType.VarChar, 50).Value = this.nomeCategoria;
            if(this.descCategoria != "")
                cmd.Parameters.Add("@descCategoria", SqlDbType.NVarChar, 50).Value = this.descCategoria;
            else
                cmd.Parameters.Add("@descCategoria", DBNull.Value); //Enviando valor null

            cmd.ExecuteNonQuery();

            cn.Close();
            cn.Dispose();
        }

        public void Cadastrar()
        {
            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "INSERT INTO categoria " +
                                "(nomeCategoria, descCategoria)" +
                                "VALUES " +
                                "(@nomeCategoria, @descCategoria)";         

            cmd.Parameters.Add("@nomeCategoria", SqlDbType.VarChar, 50).Value = this.nomeCategoria;
            if (this.descCategoria != "")
                cmd.Parameters.Add("@descCategoria", SqlDbType.NVarChar, 50).Value = this.descCategoria;
            else
                cmd.Parameters.Add("@descCategoria", DBNull.Value); //Enviando valor null
            cmd.ExecuteNonQuery();

            cn.Close();
            cn.Dispose();
        }

        public static void Deletar(int idCategoria)
        {
            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "DELETE FROM categoria " +
                              "WHERE idCategoria = @idCategoria";
            cmd.Parameters.Add("idCategoria", SqlDbType.Int).Value = idCategoria;

            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
        }
    }
}

