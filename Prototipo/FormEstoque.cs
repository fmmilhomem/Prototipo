using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexaoDataBase;

namespace Prototipo
{
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxId_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxId.Text != string.Empty)
                txtBoxNome.Enabled = false;
            else
                txtBoxNome.Enabled = true;
        }

        private void txtBoxNome_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxNome.Text != string.Empty)
                txtBoxId.Enabled = false;
            else
                txtBoxId.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idProduto = "";
            string nomeProduto = "";

            if ((txtBoxId.Text != string.Empty) || (txtBoxNome.Text != string.Empty))
                idProduto = txtBoxId.Text;
                nomeProduto = txtBoxNome.Text;

            if (txtBoxId.Enabled == true)
            {
                //METODO PARA BUSCAR PARA O 
                List<clsEstoque> est = clsEstoque.SelecionarProdutoId(idProduto);
                DataGridEstoque.DataSource = est;
                //DataGridEstoque.Columns[0].Visible = false;
            }else
            {
                //METODO PARA BUSCAR PELO NOME DO PRODUTO
                List<clsEstoque> est = clsEstoque.SelecionarProdutoNome(nomeProduto);
                DataGridEstoque.DataSource = est;
                //DataGridEstoque.Columns[0].Visible = false;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void DataGridEstoque_SelectionChanged(object sender, EventArgs e)
        {
            string strNomeArquivo = null;

            if (DataGridEstoque.SelectedRows.Count > 0)
            {
                int id = int.Parse(DataGridEstoque.SelectedRows[0].Cells[0].Value.ToString());
               
                //if(DataGridEstoque.SelectedRows[0].Cells[0].Value.ToString())
                strNomeArquivo = clsProduto.RetornaIMG(id);
                                
               // if (Image.FromFile(strNomeArquivo))
                    imgProduto.Image = Image.FromFile(strNomeArquivo);
            }
        }
    }
}
