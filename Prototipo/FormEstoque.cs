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

        private void txtBoxId_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtBoxNome_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxNome.Text != string.Empty)
                txtBoxId.Enabled = false;
            else
                txtBoxId.Enabled = true;
        }

        private void txtBoxId_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxId.Text != string.Empty)
                txtBoxNome.Enabled = false;
            else
                txtBoxNome.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = 0;
            string idTxt = txtBoxId.Text;
            string nomeProduto = txtBoxNome.Text;
            List<clsEstoque> Estoque = null;

            if (nomeProduto != string.Empty)
            {
                Estoque = clsEstoque.SelecionarProdutoNome(nomeProduto);
            }
            else if (idTxt != string.Empty)
            {                
                id = Convert.ToInt32(idTxt);
                Estoque = clsEstoque.SelecionarProdutoId(id);
            }           
            else 
            {
                Estoque = clsEstoque.SelecionarProdutoId(id);
            }

            DataGridEstoque.DataSource = Estoque;
            DataGridEstoque.Columns["ID"].Width = 15;
            DataGridEstoque.Columns["Produto"].Width = 100;
            DataGridEstoque.Columns["Imagem"].Visible = false;
            DataGridEstoque.Columns["QTD"].Width = 40;
        }

        private void DataGridEstoque_SelectionChanged(object sender, EventArgs e)
        {
            //Zera o campo de qtd
            txtQtd.Text = string.Empty;
            txtQtd.ReadOnly = true;
            btnSalvar.Enabled = false;

            if (DataGridEstoque.SelectedRows.Count > 0)
            {
                btnEditarQtd.Enabled = true;
                if (DataGridEstoque.SelectedRows[0].Cells[1].Value != null)
                {
                    imagem = new byte[0];
                    imagem = (byte[])(DataGridEstoque.SelectedRows[0].Cells["Imagem"].Value);
                    mostraFoto(imagem);
                }
            }
            else
            {
                btnEditarQtd.Enabled = false;
                imgProduto.Image = null;
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

        private void btnEditarQtd_Click(object sender, EventArgs e)
        {
            if (DataGridEstoque.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show(@"Deseja alterar quantidade do produto selecionado?", "Confirmação", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:

                        if (DataGridEstoque.SelectedRows[0].Cells[1].Value != null)
                        {
                            txtQtd.Text = Convert.ToString(DataGridEstoque.SelectedRows[0].Cells["QTD"].Value);
                            txtQtd.ReadOnly = false;                            
                            btnSalvar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Selecione o produto!");
                        }
                        break;
                    default:
                        txtQtd.Text = string.Empty;
                        txtQtd.ReadOnly = true;
                        btnSalvar.Enabled = false;
                        break;
                }
            }
        }

        private void txtQtd_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tpPopUp_Popup(object sender, PopupEventArgs e)
        {
            // Set up the delays for the ToolTip.
            tpPopUp.AutoPopDelay = 5000;
            tpPopUp.InitialDelay = 1000;
            tpPopUp.ReshowDelay = 500;

            // Force the ToolTip text to be displayed whether or not the form is active.
            tpPopUp.ShowAlways = true;
        }

        private void btnEditarQtd_MouseHover(object sender, EventArgs e)
        {
            //Comentario no botão editar
            tpPopUp.SetToolTip(this.btnEditarQtd, "Clique para alterar a quantidade no estoque.");
        }

        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            //Comentario no botão buscar
            tpPopUp.SetToolTip(this.btnBuscar, "Clique para buscar os produtos no estoque, pode pesquisar por nome ou código.");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (DataGridEstoque.SelectedRows[0].Cells[1].Value != null)
            {
                clsEstoque.Salvar(Convert.ToInt32(DataGridEstoque.SelectedRows[0].Cells[0].Value), Convert.ToInt32(txtQtd.Text));
                btnBuscar_Click(sender, e); //REFRESH
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
