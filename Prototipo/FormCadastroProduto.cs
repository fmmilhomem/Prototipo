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
                p.nomeProduto = txtNome.Text;
                p.descProduto = txtDescricao.Text;
                p.precProduto = Convert.ToDecimal(txtPreco.Text);
                p.idCategoria = Convert.ToInt16(cbCategoria.SelectedValue);
                p.ativoProduto = chkBoxAtivo.Checked;
                if (txtQtdProduto.Text != string.Empty)
                    p.qtdMinEstoque = Convert.ToInt16(txtQtdProduto.Text);
                p.imagem = ConverterImgBytes();
                if(txtDesconto.Text != string.Empty)
                    p.descontoPromocao = Convert.ToDecimal(txtDesconto.Text);
                p.idUsuario = u.idUsuario;

                p.SalvarProduto(p.nomeProduto, p.descProduto, p.precProduto, p.descontoPromocao, p.idCategoria, p.ativoProduto, p.idUsuario, p.qtdMinEstoque, p.imagem);

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

        private void cbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
