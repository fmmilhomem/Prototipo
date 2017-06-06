using ConexaoDataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Prototipo
{
    public partial class FormCadastroProduto : Form
    {
        private clsUsuario u;
        private byte[] imagem;

        public FormCadastroProduto(clsUsuario u)
        {
            InitializeComponent();
            this.u = u;

            if (u.Tipo != "A")
            {
                List<clsUsuario> Usuario = null;

                DataGridProduto.DataSource = Usuario;
                txtNome.ReadOnly = true;
                txtDescricao.ReadOnly = true;
                txtPreco.ReadOnly = true;
                txtQtdProduto.ReadOnly = true;
                txtDesconto.ReadOnly = true;
                btnEditar.Visible = false;
                btnDeletar.Visible = false;
                btnSalvar.Enabled = true;
                chkBoxAtivo.Enabled = false;
                btnCategoria.Enabled = false;
            }
        }

        private void CarregarCategoria()
        {
            DataTable dtResultado = clsCategoria.SelecionarCategoriaNome();
            cbCategoria.DataSource = null;
            cbCategoria.DataSource = dtResultado;
            cbCategoria.DisplayMember = "nomeCategoria";
            cbCategoria.ValueMember = "idCategoria";
            cbCategoria.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
        }

        private byte[] ConverterImgBytes()
        {
            //Cria objeto para conversão
            ImageConverter c = new ImageConverter();

            //Envia o objeto convertido para variavel ByteArray
            byte[] imgByte = (byte[])c.ConvertTo(imgBox.Image, typeof(byte[]));

            return imgByte;
        }

        private void mostraFoto(Byte[] dados)
        {
            if (dados.Length > 0)
            {
                MemoryStream mem = new MemoryStream(dados);
                imgBox.Image = Image.FromStream(mem);
            }
            else
            {
                imgBox.Image = null;
            }
        }

        private void imgBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Arquivos de imagem (*.jpg)|*.jpg";

            if (file.ShowDialog() == DialogResult.OK)
            {
                string fileName = abrirArqImg.FileName;
                if (file.CheckFileExists)
                {
                    imagem = File.ReadAllBytes(file.FileName);
                    mostraFoto(imagem);
                }
                else
                {
                    imagem = new byte[0];
                    MessageBox.Show("Arquivo Inválido! Tente novamente...");
                }
            }
        }

        private void cbCategoria_DropDown(object sender, EventArgs e)
        {
            CarregarCategoria();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            FormEstoque frm = new FormEstoque();
            frm.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            //FormTelasUsuario frm = new FormTelasUsuario();
            //frm.Show();
        }

        private void bntCategoria_Click(object sender, EventArgs e)
        {
            FormCategoria f = new FormCategoria();
            f.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {            

            if (!(string.IsNullOrEmpty(txtNome.Text)) &&
                !(string.IsNullOrEmpty(txtPreco.Text)) &&
                !(cbCategoria.SelectedItem == null))
            {
                clsProduto p = new clsProduto();

                p.Ativo = Convert.ToString(chkBoxAtivo.Checked);
                if (btnEditar.Enabled)
                {
                    p.ID = Convert.ToInt32(DataGridProduto.SelectedRows[0].Cells["ID"].Value);
                }
                p.Nome = txtNome.Text;
                p.Descricao = txtDescricao.Text;
                p.IDCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                p.Preco = Convert.ToDecimal(txtPreco.Text);
                if (txtDesconto.Text != string.Empty)
                    p.Desconto = Convert.ToDecimal(txtDesconto.Text);
                if (txtQtdProduto.Text != string.Empty)
                    p.QTDMinEstoque = Convert.ToInt16(txtQtdProduto.Text);
                p.Imagem = ConverterImgBytes();
                p.IDUsuario = u.ID;

                p.Salvar();
                MessageBox.Show("Produto salvo com sucesso!");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos necessários! (*)");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<clsProduto> Produto;
            if (!DataGridProduto.Visible)
            {
                DataGridProduto.Visible = true;
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    Produto = clsProduto.SelecionarProdutos();
                }
                else
                {
                    Produto = clsProduto.SelecionarProdutoNome(txtNome.Text);
                }
                LayoutGrid(Produto);
            }
            else
            {
                DataGridProduto.DataSource = null;
                DataGridProduto.Visible = false;
                txtNome.Clear();
                txtDescricao.Clear();
                txtPreco.Clear();
                cbCategoria.DataSource = null;
                cbCategoria.Items.Remove(cbCategoria.SelectedItem);
                txtPreco.Clear();
                txtDesconto.Clear();
                txtQtdProduto.Clear();
            }
        }        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (DataGridProduto.Visible)
            {
                btnDeletar.Enabled = false;
                DataGridProduto.Visible = false;
            }
            else
            {
                btnDeletar.Enabled = true;
                DataGridProduto.Visible = true;
            }
        }        

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            clsProduto p = new clsProduto();

            if (DataGridProduto.SelectedRows.Count > 0)
            {
                if (DataGridProduto.SelectedRows[0].Cells[1].Value != null)
                {
                    p.ID = Convert.ToInt32(DataGridProduto.SelectedRows[0].Cells["ID"].Value);
                    p.Deletar();
                    MessageBox.Show("Deletado com sucesso!");
                    DataGridProduto.Visible = false;
                    txtNome.Clear();
                    btnBuscar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Selecione um produto!");
                }
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if ((txtNome.Text != string.Empty) && (btnEditar.Visible == true))
            {
                chkBoxAtivo.Enabled = true;
                txtDescricao.Enabled = true;
                cbCategoria.Enabled = true;
                txtPreco.Enabled = true;
                txtDesconto.Enabled = true;
                txtQtdProduto.Enabled = true;
                imgBox.Enabled = true;
                btnSalvar.Enabled = true;
            }
            else
            {
                chkBoxAtivo.Enabled = false;
                txtDescricao.Enabled = false;
                cbCategoria.Enabled = false;
                txtPreco.Enabled = false;
                txtDesconto.Enabled = false;
                txtQtdProduto.Enabled = false;
                imgBox.Enabled = false;
                btnSalvar.Enabled = false;
            }
        }

        private void txtQtdProduto_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        
        private void DataGridProduto_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridProduto.SelectedRows.Count > 0)
            {
                if (DataGridProduto.SelectedRows[0].Cells[1].Value != null)
                {
                    btnEditar.Enabled = true;
                    btnDeletar.Enabled = true;

                    txtNome.Text = DataGridProduto.SelectedRows[0].Cells["Nome"].Value.ToString();

                    if (DataGridProduto.SelectedRows[0].Cells["Ativo"].Value.ToString() == "1")
                    {
                        chkBoxAtivo.Checked = true;
                    }
                    else
                    {
                        chkBoxAtivo.Checked = false;
                    }
                    if (DataGridProduto.SelectedRows[0].Cells["Descricao"].Value != null)
                    {
                        txtDescricao.Text = Convert.ToString(DataGridProduto.SelectedRows[0].Cells["Descricao"].Value);
                    }
                    txtPreco.Text = Convert.ToString(DataGridProduto.SelectedRows[0].Cells["Preco"].Value);
                    if (DataGridProduto.SelectedRows[0].Cells["Desconto"].Value != null)
                    {
                        txtDesconto.Text = DataGridProduto.SelectedRows[0].Cells["Desconto"].Value.ToString();
                    }
                    txtQtdProduto.Text = Convert.ToString(DataGridProduto.SelectedRows[0].Cells["QTDMinEstoque"].Value);
                    if (DataGridProduto.SelectedRows[0].Cells["Categoria"].Value != null)
                    {
                        cbCategoria.DataSource = null;
                        cbCategoria.Items.Remove(cbCategoria.SelectedItem);
                        cbCategoria.ValueMember = DataGridProduto.SelectedRows[0].Cells["IDCategoria"].Value.ToString();
                        cbCategoria.Items.Add(DataGridProduto.SelectedRows[0].Cells["Categoria"].Value.ToString());
                        cbCategoria.SelectedIndex = 0;
                    }                
                    imagem = new byte[0];
                    imagem = (byte[])(DataGridProduto.SelectedRows[0].Cells["Imagem"].Value);
                    mostraFoto(imagem);
                }
            }
            else
            {
                imgBox.Image = null;
                btnEditar.Enabled = false;
                btnDeletar.Enabled = false;
            }
        }

        private void LayoutGrid(List <clsProduto> Produto)
        {
            DataGridProduto.DataSource = Produto;
            DataGridProduto.Columns["Nome"].Width = 60;
            DataGridProduto.Columns["Preco"].Width = 20;
            DataGridProduto.Columns["Desconto"].Width = 20;
            DataGridProduto.Columns["Categoria"].Width = 40;

            DataGridProduto.Columns["ID"].Visible = false;
            DataGridProduto.Columns["Ativo"].Visible = false;
            DataGridProduto.Columns["Descricao"].Visible = false;
            DataGridProduto.Columns["QTDMinEstoque"].Visible = false;
            DataGridProduto.Columns["IDCategoria"].Visible = false;
            DataGridProduto.Columns["IDUsuario"].Visible = false;
            DataGridProduto.Columns["Imagem"].Visible = false;
        }
    }
}
