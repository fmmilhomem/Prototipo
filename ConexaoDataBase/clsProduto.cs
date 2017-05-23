using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexaoDataBase;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace ConexaoDataBase
{
    public class clsProduto
    {
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public string descProduto { get; set; }
        public decimal precProduto { get; set; }
        public decimal descontoPromocao { get; set; }
        public int idCategoria { get; set; }
        public bool ativoProduto { get; set; }
        public int idUsuario { get; set; }
        public int qtdMinEstoque { get; set; }
        public byte[] imagem { get; set; }

        public clsProduto SalvarProduto(string nomeProduto,string descProduto,decimal precProduto, decimal descontoPromocao,int idCategoria,bool ativo,int usuarioId,int qtdMinima,byte[] imagem)
        {
            clsConn conn = new clsConn();
            clsProduto p = null;

            try
            {
                //TODO: INSERT SEM IMAGEM
                string sql = (@"INSERT INTO PRODUTO
                             (nomeProduto,descProduto,precProduto,descontoPromocao,idCategoria,ativoProduto,idUsuario,qtdMinEstoque,imagem)
                             VALUES (@nomeProduto,@descProduto,@precProduto,@descontoPromocao,@idCategoria,@ativo,@idUsuario,@qtdMinima,@imagem)"); 

                SqlConnection cn = clsConn.Conectar();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@nomeProduto", SqlDbType.VarChar).Value = nomeProduto;
                cmd.Parameters.Add("@descProduto", SqlDbType.VarChar).Value = descProduto;
                cmd.Parameters.Add("@precProduto", SqlDbType.Decimal).Value = precProduto;
                cmd.Parameters.Add("@descontoPromocao", SqlDbType.Decimal).Value = descontoPromocao;
                cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;
                cmd.Parameters.Add("@ativo", SqlDbType.Bit).Value = ativo;
                cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                cmd.Parameters.Add("@qtdMinima", SqlDbType.Int).Value = qtdMinima;
                cmd.Parameters.Add("@imagem", SqlDbType.Image).Value = imagem;

                cmd.ExecuteNonQuery();
                cn.Close();
                cn.Dispose();

                //cmd.Parameters.Add("@D");
                /*
                SqlDataReader dr = cmd.ExecuteReader();
                p = new clsProduto();
                dr.Read();

                p.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                p.descProduto = dr.GetString(dr.GetOrdinal("descProduto"));
                p.precProduto = dr.GetDecimal(dr.GetOrdinal("precProduto"));
                p.descontoPromocao = dr.GetDecimal(dr.GetOrdinal("descontoPromocao"));
                p.idCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                p.ativoProduto = dr.GetBoolean(dr.GetOrdinal("ativo"));
                p.idUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                p.qtdMinEstoque = dr.GetInt32(dr.GetOrdinal("qtdMinima"));
                p.qtdMinEstoque = dr.GetInt32(dr.GetOrdinal("qtdMinima"));
                */
            }
            catch (InvalidOperationException e)
            {
                p = null;
            }
            return p;
        }

        public static List<clsProduto> SelecionarProdutos()
        {
            string sql = "SELECT idProduto, nomeProduto, Imagem FROM Produto";
            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();

            List<clsProduto> Produtos = new List<clsProduto>();
            while (dr.Read())
            {
                clsProduto P = new clsProduto();

                P.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                P.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                if (dr["Imagem"] != DBNull.Value)
                    P.imagem = (byte[])dr["Imagem"];
                else
                    P.imagem = new byte[0];

                Produtos.Add(P);
            }

            cn.Close();
            cn.Dispose();

            return Produtos;
        }

        public static string RetornaIMG(int idProduto)
        {
            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = (@"select imagem from Produto where idProduto=@idProduto");
            cmd.Parameters.Add("@idProduto", SqlDbType.Int, 4);

            cmd.Parameters["@idProduto"].Value = idProduto;           

            byte[] vetorImagem = (byte[])cmd.ExecuteScalar();
            string strNomeArquivo = Convert.ToString(DateTime.Now.ToFileTime());
            FileStream fs = new FileStream(strNomeArquivo, FileMode.CreateNew, FileAccess.Write);
            fs.Write(vetorImagem, 0, vetorImagem.Length);
            fs.Flush();
            fs.Close();

            return strNomeArquivo;
        }        
    }
}
