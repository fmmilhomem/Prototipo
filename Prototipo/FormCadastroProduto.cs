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

        private void imgBox_DoubleClick(object sender, EventArgs e)
        {
            if (abrirArqImg.ShowDialog() == DialogResult.OK)
            {               
                string fileName = abrirArqImg.FileName;                

                //Le o tamanho do arquivo
                FileInfo file = new FileInfo(fileName);
                long tamanhoArquivoImagem = file.Length;

                //Verifica se tem menos de 1MB (1MB em bytes = 1048576)
                if (file.Length <= 1048576)
                {
                    imgBox.Image = Image.FromFile(fileName);
                    FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                    byte[] vetorImagens = new byte[Convert.ToInt32(tamanhoArquivoImagem)];
                    int iBytesRead = fs.Read(vetorImagens, 0, Convert.ToInt32(tamanhoArquivoImagem));
                    fs.Close();
                }
                else
                {
                    MessageBox.Show("Arquivo Maior que 1 MB!");
                }
            }
        }

        private void bntCategoria_Click(object sender, EventArgs e)
        {
            FormCategoria f = new FormCategoria();
            f.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clsProduto p = new clsProduto();

            if (txtNome.Text != string.Empty &&
                txtPreco.Text != string.Empty &&
                cbCategoria.Text != string.Empty)
            {
                p.Nome = txtNome.Text;
                p.Descricao = txtDescricao.Text;
                p.Preco = Convert.ToDecimal(txtPreco.Text);
                p.IDCategoria = Convert.ToInt16(cbCategoria.SelectedValue);
                p.Ativo = Convert.ToString(chkBoxAtivo.Checked);
                if (txtQtdProduto.Text != string.Empty)
                    p.QTDMinEstoque = Convert.ToInt16(txtQtdProduto.Text);
                p.Imagem = ConverterImgBytes();
                if(txtDesconto.Text != string.Empty)
                    p.Desconto = Convert.ToDecimal(txtDesconto.Text);
                p.IDUsuario = u.ID;

                p.Salvar();
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos necessários! (*)");
            }
        }

        private byte[] ConverterImgBytes()
        {
            //Cria objeto para conversão
            ImageConverter c = new ImageConverter();

            //Envia o objeto convertido para variavel ByteArray
            byte[] imgByte = (byte[])c.ConvertTo(imgBox.Image, typeof(byte[]));
            
            return imgByte;
        }

        private void cbCategoria_DropDown(object sender, EventArgs e)
        {
            CarregarCategoria();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!DataGridProduto.Visible)
            {
                DataGridProduto.Visible = true;

                List<clsProduto> Produto = null;
                Produto = clsProduto.SelecionarProdutos();

                DataGridProduto.DataSource = Produto;
                DataGridProduto.Columns["ID"].Width = 20;
                DataGridProduto.Columns["Nome"].Width = 85;                
                DataGridProduto.Columns["Preco"].Width = 30;
                DataGridProduto.Columns["Desconto"].Width = 30;
                DataGridProduto.Columns["Desconto"].Width = 30;

                DataGridProduto.Columns["Ativo"].Visible = false;
                DataGridProduto.Columns["Descricao"].Visible = false;
                DataGridProduto.Columns["QTDMinEstoque"].Visible = false;                
                DataGridProduto.Columns["IDUsuario"].Visible = false;
                DataGridProduto.Columns["Imagem"].Visible = false;
            }
            else
            {
                DataGridProduto.Visible = false;
            }
        }

        private void DataGridProduto_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridProduto.SelectedRows.Count > 0)
            {
                if (DataGridProduto.SelectedRows[0].Cells[1].Value != null)
                {
                    btnEditar.Enabled = true;
                    imagem = new byte[0];
                    imagem = (byte[])(DataGridProduto.SelectedRows[0].Cells["Imagem"].Value);
                    mostraFoto(imagem);
                }
            }
            else
            {
                imgBox.Image = null;
                btnEditar.Enabled = false;
            }
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (DataGridProduto.Visible)
            {
                DataGridProduto.Visible = false;
                txtNome.Text = Convert.ToString(DataGridProduto.SelectedRows[0].Cells["Nome"].Value);
                txtDescricao.Text = Convert.ToString(DataGridProduto.SelectedRows[0].Cells["Descricao"].Value);
                txtPreco.Text = Convert.ToString(DataGridProduto.SelectedRows[0].Cells["Preco"].Value);
                txtQtdProduto.Text = Convert.ToString(DataGridProduto.SelectedRows[0].Cells["QTDMinEstoque"].Value);
                //chkBoxAtivo.Checked = (bool) DataGridProduto.SelectedRows[0].Cells["Ativo"].Value;
            }
            else
            {
                DataGridProduto.Visible = true;
            }
        }
    }
}
