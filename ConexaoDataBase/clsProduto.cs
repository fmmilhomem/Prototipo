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
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal Desconto { get; set; }
        public int IDCategoria { get; set; }
        public string Categoria { get; set; }
        public string Ativo { get; set; }
        public int IDUsuario { get; set; }
        public int QTDMinEstoque { get; set; }
        public byte[] Imagem { get; set; }

        public string Salvar()
        {
            string msg = null;
            clsConn conn = new clsConn();
            clsProduto p = null;
            bool inserir = (this.ID == 0);

            try
            {
                SqlConnection cn = clsConn.Conectar();
                SqlCommand cmd = cn.CreateCommand();

                if (inserir)
                {
                    cmd.CommandText = (@"INSERT INTO PRODUTO
                                   (nomeProduto,descProduto,precProduto,descontoPromocao,idCategoria,ativoProduto,idUsuario,qtdMinEstoque,imagem)
                                   VALUES (@Nome,@Descricao,@Preco,@Desconto,@IDCategoria,@Ativo,@IDUsuario,@QTDMinEstoque,@Imagem)");
                }
                else
                {
                    cmd.CommandText = (@"UPDATE PRODUTO
                                         SET nomeProduto = @Nome,
                                             descProduto = @Descricao,
                                             precProduto = @Preco,
                                             descontoPromocao = @Desconto,
                                             idCategoria = @IDCategoria,
                                             ativoProduto = @Ativo,
                                             idUsuario = @IDUsuario,
                                             qtdMinEstoque = @QTDMinEstoque,
                                             imagem = @Imagem
                                             WHERE idproduto = @ID");

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                }

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = this.Nome;
                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = this.Descricao;
                cmd.Parameters.Add("@Preco", SqlDbType.Decimal).Value = this.Preco;
                cmd.Parameters.Add("@Desconto", SqlDbType.Decimal).Value = this.Desconto;
                cmd.Parameters.Add("@IDCategoria", SqlDbType.Int).Value = this.IDCategoria;
                cmd.Parameters.Add("@Ativo", SqlDbType.Bit).Value = this.Ativo;
                cmd.Parameters.Add("@IDUsuario", SqlDbType.Int).Value = this.IDUsuario;
                cmd.Parameters.Add("@QTDMinEstoque", SqlDbType.Int).Value = this.QTDMinEstoque;
                cmd.Parameters.Add("@Imagem", SqlDbType.Image).Value = this.Imagem;

                cmd.ExecuteNonQuery();
                cn.Close();
                cn.Dispose();
                msg = "Salvo com sucesso!";
            }
            catch (InvalidOperationException e)
            {
                msg = e.Message;
            }
            return msg;
        }

        public string Deletar()
        {
            string msg=null;
            clsConn conn = new clsConn();

            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            if (ID > 10)
            {
                cmd.CommandText = (@"DELETE FROM produto
                                 WHERE idproduto = @ID

                                 DELETE FROM estoque
                                 WHERE idproduto = @ID");

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                try
                {
                    cmd.ExecuteNonQuery();
                    msg = "Produto deletado com sucesso!";
                }
                catch (SqlException e)
                {

                }
            }else
            {
                msg = "Não pode deletar os 10 primeiros!";
            }
            cn.Close();
            cn.Dispose();
            return msg;
        }

        public static List<clsProduto> SelecionarProdutoNome(string nomeProduto)
        {
            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            string sql = @"SELECT P.idProduto, 
                           P.nomeProduto, 
                           P.descProduto,
                           P.precProduto,
                           P.descontoPromocao,
                           P.idcategoria,
                           C.nomeCategoria,
                           P.ativoProduto,
                           P.idUsuario,
                           P.qtdMinEstoque,
                           P.Imagem FROM Produto AS P
                           INNER JOIN categoria AS C ON P.idcategoria = C.idcategoria
                           WHERE P.nomeProduto LIKE  '%'+ @nomeProduto + '%'";

            cmd.Parameters.Add("@nomeProduto", SqlDbType.VarChar).Value = nomeProduto;
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader();

            List<clsProduto> Produtos = new List<clsProduto>();
            try
            {

                while (dr.Read())
                {
                    clsProduto p = new clsProduto();

                    p.ID = dr.GetInt32(dr.GetOrdinal("idProduto"));
                    p.Nome = dr.GetString(dr.GetOrdinal("nomeProduto"));
                    p.Preco = dr.GetDecimal(dr.GetOrdinal("precProduto"));
                    if (!dr.IsDBNull(dr.GetOrdinal("descontoPromocao")))
                        p.Desconto = dr.GetDecimal(dr.GetOrdinal("descontoPromocao"));
                    else
                        p.Desconto = 0;
                    p.IDCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                    p.Categoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                    p.Ativo = dr.GetString(dr.GetOrdinal("ativoProduto"));
                    if (!dr.IsDBNull(dr.GetOrdinal("idUsuario")))
                        p.IDUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                    if (!dr.IsDBNull(dr.GetOrdinal("qtdMinEstoque")))
                        p.QTDMinEstoque = dr.GetInt32(dr.GetOrdinal("qtdMinEstoque"));
                    else
                        p.QTDMinEstoque = 0;
                    if (dr["Imagem"] != DBNull.Value)
                        p.Imagem = (byte[])dr["Imagem"];
                    else
                        p.Imagem = new byte[0];

                    Produtos.Add(p);
                }
            }
            catch (SqlException e)
            {
                //return Produtos = null;
            }
            return Produtos;
        }

        public static List<clsProduto> SelecionarProdutos()
        {
            string sql = @"SELECT P.idProduto, 
                           P.nomeProduto, 
                           P.descProduto,
                           P.precProduto,
                           P.descontoPromocao,
                           P.idcategoria,
                           C.nomeCategoria,
                           P.ativoProduto,
                           P.idUsuario,
                           P.qtdMinEstoque,
                           P.Imagem FROM Produto AS P
                           INNER JOIN categoria AS C ON P.idcategoria = C.idcategoria";

            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();

            List<clsProduto> Produtos = new List<clsProduto>();
            try
            {
                while (dr.Read())
                {
                    clsProduto p = new clsProduto();

                    p.ID = dr.GetInt32(dr.GetOrdinal("idProduto"));
                    p.Nome = dr.GetString(dr.GetOrdinal("nomeProduto"));
                    p.Preco = dr.GetDecimal(dr.GetOrdinal("precProduto"));
                    if (!dr.IsDBNull(dr.GetOrdinal("descontoPromocao")))
                        p.Desconto = dr.GetDecimal(dr.GetOrdinal("descontoPromocao"));
                    else
                        p.Desconto = 0;
                    p.IDCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                    p.Categoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                    p.Ativo = dr.GetString(dr.GetOrdinal("ativoProduto"));
                    if (!dr.IsDBNull(dr.GetOrdinal("idUsuario")))
                        p.IDUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                    if (!dr.IsDBNull(dr.GetOrdinal("qtdMinEstoque")))
                        p.QTDMinEstoque = dr.GetInt32(dr.GetOrdinal("qtdMinEstoque"));
                    else
                        p.QTDMinEstoque = 0;
                    if (dr["Imagem"] != DBNull.Value)
                        p.Imagem = (byte[])dr["Imagem"];
                    else
                        p.Imagem = new byte[0];

                    Produtos.Add(p);
                }
            }
            catch (SqlException e)
            {
                //return Produtos = null;
            }
            return Produtos;
        }

    }
}
