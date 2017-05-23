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
using System.IO;

namespace Prototipo
{
    public partial class FormEstoque : Form
    {
        byte[] imagem;

        public FormEstoque()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxId_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;

                /*if (txtBoxNome.Text != string.Empty)
                    txtBoxId.Enabled = false;
                else
                    txtBoxId.Enabled = true;*/
            }
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
            int id = 0;
            string idTxt = txtBoxId.Text;

            if (idTxt != string.Empty)
            {                
                id = Convert.ToInt32(idTxt);
            }           

            List<clsEstoque> Estoque = clsEstoque.SelecionarProdutoId(id);
            DataGridEstoque.DataSource = Estoque;
            DataGridEstoque.Columns["Imagem"].Visible = false;
            DataGridEstoque.Columns["nomeProduto"].Width = 100;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        /*private void DataGridEstoque_SelectionChanged(object sender, EventArgs e)
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
        }*/

        private void DataGridEstoque_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridEstoque.SelectedRows.Count > 0)
            {
                if (DataGridEstoque.SelectedRows[0].Cells[1].Value != null)
                {
                    imagem = new byte[0];
                    imagem = (byte[])(DataGridEstoque.SelectedRows[0].Cells["Imagem"].Value);
                    mostraFoto(imagem);
                }
            }
        }

        private void mostraFoto(Byte[] dados)
        {
            if (dados.Length > 0)
            {
                MemoryStream mem = new MemoryStream(dados);
                imgProduto.Image = Image.FromStream(mem);
            }
            else
            {
                imgProduto.Image = null;
            }
        }

        private void txtBoxId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
