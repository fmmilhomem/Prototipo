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
        //public  Imagem { get; set; }

        public clsProduto SalvarProduto(string nomeProduto,string descProduto,decimal precProduto, decimal descontoPromocao,int idCategoria,bool ativo,int usuarioId,int qtdMinima)
        {
            clsConn conn = new clsConn();
            clsProduto p = null;

            try
            {
                //TODO: INSERT SEM IMAGEM
                string sql = (@"INSERT INTO PRODUTO
                             (nomeProduto,descProduto,precProduto,descontoPromocao,idCategoria,ativoProduto,idUsuario,qtdMinEstoque,imagem)
                             VALUES (@nomeProduto,@descProduto,@precProduto,@descontoPromocao,@idCategoria,@ativo,@idUsuario,@qtdMinima,null)
                        "); 
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
                
                //cmd.Parameters.Add("@D")

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
            }
            catch (InvalidOperationException e)
            {
                p = null;
            }
            return p;
        }

        public void SalvarProduto(object nomeProduto, object descProduto, object precProduto, object descontoPromocao, object idCategoria, object ativo, object usuarioId, object qtdMinima)
        {
            throw new NotImplementedException();
        }
    }
}
