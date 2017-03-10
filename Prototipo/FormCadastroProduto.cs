using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Prototipo
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            FormEstoque frm = new FormEstoque();
            frm.Show();
            this.Hide();
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
                //Le o tamanho do arquivo
                FileInfo file = new FileInfo(abrirArqImg.FileName);

                //Verifica se tem menos de 1MB (1MB em bytes = 1048576)
                if (file.Length <= 1048576)
                    imgBox.ImageLocation = abrirArqImg.FileName;
                else
                    MessageBox.Show("Arquivo Maior que 1 MB!");
            }
        }
    }
}
