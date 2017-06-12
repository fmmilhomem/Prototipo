using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConexaoDataBase
{
    public class clsEstoque
    {
        public int ID { get; set; }
        public string Produto { get; set; }
        public int QTD { get; set; }
        public byte[] imagem { get; set; }

        public static List<clsEstoque> SelecionarProdutoId(int idProduto)
        {
            List<clsEstoque> Estoque = null;
            string sql = null;
            try
            {
                SqlConnection cn = clsConn.Conectar();
                SqlCommand cmd = cn.CreateCommand();

                if (idProduto == 0)
                {
                    sql = (@"SELECT P.idProduto AS idProduto,
                                    P.nomeProduto  AS nomeProduto, 
                                    E.qtdProdutoDisponivel AS qtd, 
                                    P.imagem AS Imagem FROM Produto AS P
                                    INNER JOIN estoque AS E ON P.idProduto = E.idProduto");
                }
                else
                {
                    sql = (@"SELECT P.idProduto AS idProduto,
                                    P.nomeProduto  AS nomeProduto, 
                                    E.qtdProdutoDisponivel AS qtd, 
                                    P.imagem AS Imagem 
                                    FROM Produto AS P
                                    INNER JOIN estoque AS E ON P.idProduto = E.idProduto 
                                    WHERE P.idProduto = @idProduto");

                    cmd.Parameters.Add("@idProduto", SqlDbType.VarChar).Value = idProduto;
                }
                
                cmd.CommandText = sql;                

                SqlDataReader dr = cmd.ExecuteReader();
                Estoque = new List<clsEstoque>();
                
                while (dr.Read())
                {
                    clsEstoque e = new clsEstoque();
                    e.ID = dr.GetInt32(dr.GetOrdinal("idProduto"));
                    e.Produto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                    e.QTD = dr.GetInt32(dr.GetOrdinal("qtd"));
                    if (dr["Imagem"] != DBNull.Value)
                        e.imagem = (byte[])dr["Imagem"];
                    else
                        e.imagem = new byte[0];
                    Estoque.Add(e);
                }
                
            }
            catch (Exception e)
            {
               
            }
            return Estoque;
        }

        public static List<clsEstoque> SelecionarProdutoNome(string nomeProduto)
        {
            List<clsEstoque> Estoque = null;
            try
            {
                SqlConnection cn = clsConn.Conectar();
                SqlCommand cmd = cn.CreateCommand();

                string sql = (@"SELECT P.idProduto AS idProduto,
                                    P.nomeProduto  AS nomeProduto, 
                                    E.qtdProdutoDisponivel AS qtd, 
                                    P.imagem AS Imagem 
                                    FROM Produto AS P
                                    INNER JOIN estoque AS E ON P.idProduto = E.idProduto                                     
                                    WHERE nomeProduto LIKE '%' + @nomeProduto + '%'");              

                cmd.Parameters.Add("@nomeProduto", SqlDbType.VarChar).Value = nomeProduto;
                cmd.CommandText = sql;

                SqlDataReader dr = cmd.ExecuteReader();
                Estoque = new List<clsEstoque>();

                while (dr.Read())
                {
                    clsEstoque e = new clsEstoque();
                    e.ID = dr.GetInt32(dr.GetOrdinal("idProduto"));
                    e.Produto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                    e.QTD = dr.GetInt32(dr.GetOrdinal("qtd"));
                    if (dr["Imagem"] != DBNull.Value)
                        e.imagem = (byte[])dr["Imagem"];
                    else
                        e.imagem = new byte[0];
                    Estoque.Add(e);
                }
            }
            catch (Exception e)
            {

            }
            return Estoque;
        }

        public static string Salvar(int idProduto, int qtdProdutoDisponivel)
        {
            string msg = null;

            string sql = (@"UPDATE estoque SET
                            qtdProdutoDisponivel = @qtdProdutoDisponivel
                            WHERE idProduto = @idProduto");

            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();           

            cmd.Parameters.Add("@qtdProdutoDisponivel", SqlDbType.Int).Value = qtdProdutoDisponivel;
            cmd.Parameters.Add("@idProduto", SqlDbType.Int).Value = idProduto;
            cmd.CommandText = sql;

            try
            {
                cmd.ExecuteNonQuery();
                msg = "Salvo com sucesso!";
            }
            catch (SqlException e)
            {
                msg = e.Message;
            }
            cn.Dispose();
            cn.Close();

            return msg;
        }
    }
}

