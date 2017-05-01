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
        public int qtdProdutoDisponivel { get; set; }

        public clsEstoque Buscar(string codigo)
        {
            clsConn conn = new clsConn();
            clsEstoque e = null;

            try
            {
                string sql = (@"SELECT idProduto FROM estoque where idProduto = @codigo");
                SqlConnection cn = clsConn.Conectar();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@idProduto", SqlDbType.Int).Value = codigo;


                SqlDataReader dr = cmd.ExecuteReader();
                e = new clsEstoque();
                dr.Read();

                e.idProduto = dr.GetInt16(dr.GetOrdinal("idProduto"));


            }
            catch (InvalidOperationException ee)
            {
                e = null;
            }
            return e;
        }
    }
}

