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
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public int qtdProdutoDisponivel { get; set; }

        public static List<clsEstoque> SelecionarProduto(int idProduto)
        {
            List<clsEstoque> Estoque = null;
            try
            {
                string sql = (@"SELECT E.idProduto, P.nomeProduto, ISNULL(E.qtdProdutoDisponivel, '') AS qtdProdutoDisponivel FROM estoque AS E INNER JOIN produto AS P ON E.idProduto = P.idProduto 
                                WHERE E.idProduto = @idProduto");

                SqlConnection cn = clsConn.Conectar();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@idProduto", SqlDbType.Int).Value = idProduto;

                SqlDataReader dr = cmd.ExecuteReader();
                Estoque = new List<clsEstoque>();
                while (dr.Read())
                {
                    clsEstoque e = new clsEstoque();
                    e.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                    e.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                    e.qtdProdutoDisponivel = dr.GetInt32(dr.GetOrdinal("qtdProdutoDisponivel"));
                    Estoque.Add(e);
                }
                
            }
            catch (Exception e)
            {
               
            }
            return Estoque;
        }

        public static List<clsEstoque> SelecionarProduto()
        {
            List<clsEstoque> Estoque = null;
            try
            {
                string sql = (@"SELECT E.idProduto, P.nomeProduto, ISNULL(E.qtdProdutoDisponivel, '') AS qtdProdutoDisponivel FROM estoque AS E INNER JOIN produto AS P ON E.idProduto = P.idProduto");

                SqlConnection cn = clsConn.Conectar();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;

                SqlDataReader dr = cmd.ExecuteReader();
                Estoque = new List<clsEstoque>();
                while (dr.Read())
                {
                    clsEstoque e = new clsEstoque();
                    e.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                    e.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                    e.qtdProdutoDisponivel = dr.GetInt32(dr.GetOrdinal("qtdProdutoDisponivel"));
                    Estoque.Add(e);
                }

            }
            catch (Exception e)
            {

            }
            return Estoque;
        }
    }
}

