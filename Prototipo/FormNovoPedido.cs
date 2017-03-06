using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo
{
    public partial class FormNovoPedido : Form
    {
        public FormNovoPedido()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTelasUsuario frm = new FormTelasUsuario();
            frm.Show();
        }

        private void btnConsultarPedido_Click(object sender, EventArgs e)
        {
            this.Close();
            FormConsultarPedido frm = new FormConsultarPedido();
            frm.Show();
        }
    }
}
