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
        public string Ativo { get; set; }
        public int IDUsuario { get; set; }
        public int QTDMinEstoque { get; set; }
        public byte[] Imagem { get; set; }

        public void Salvar()
        {
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
                    cmd.CommandText = (@"UPDATE  PRODUTO
                           SET (nomeProduto = @Nome
                                descProduto = @Descricao,
                                precProduto = @Preco,
                                descontoPromocao = @Desconto,
                                idCategoria = @IDCategoria,
                                ativoProduto = @Ativo,
                                idUsuario = @IDUsuario,
                                qtdMinEstoque = @QTDMinEstoque,
                                imagem = @Imagem)
                            WHERE idusuario = @ID");

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                }

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Nome;
                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = Descricao;
                cmd.Parameters.Add("@Preco", SqlDbType.Decimal).Value = Preco;
                cmd.Parameters.Add("@Desconto", SqlDbType.Decimal).Value = Desconto;
                cmd.Parameters.Add("@IDCategoria", SqlDbType.Int).Value = IDCategoria;
                cmd.Parameters.Add("@Ativo", SqlDbType.Bit).Value = Ativo;
                cmd.Parameters.Add("@IDUsuario", SqlDbType.Int).Value = IDUsuario;
                cmd.Parameters.Add("@QTDMinEstoque", SqlDbType.Int).Value = QTDMinEstoque;
                cmd.Parameters.Add("@Imagem", SqlDbType.Image).Value = Imagem;

                cmd.ExecuteNonQuery();
                cn.Close();
                cn.Dispose();
                /*
                cmd.Parameters.Add("@D");
                
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
                //
            }
        }

        public static List<clsProduto> SelecionarProdutos()
        {
            string sql = @"SELECT idProduto, 
                           nomeProduto, 
                           descProduto,
                           precProduto,
                           descontoPromocao,
                           idCategoria,
                           ativoProduto,
                           idUsuario,
                           qtdMinEstoque,
                           Imagem FROM Produto";

            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            
            List<clsProduto> Produtos = new List<clsProduto>();
            try {
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
                    p.Ativo = dr.GetString(dr.GetOrdinal("ativoProduto"));
                    if(!dr.IsDBNull(dr.GetOrdinal("idUsuario")))
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
            catch(SqlException e)
            {
                //return Produtos = null;
            }
            return Produtos;
        }       
    }
}
