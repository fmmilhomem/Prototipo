using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ConexaoDataBase;

namespace Prototipo
{
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
        }

        private void txtCPF_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }



        private void txtCelular_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            //FormTelasUsuario frm = new FormTelasUsuario();
            //frm.ShowDialog();            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            clsCliente c = new clsCliente();
           //TODO: CRIAR METODO PRA VALIDAR SE ESTÁ CERTO O PREENCHIENTO
           
            c.nomeCompletoCliente = txtNome.Text;
            c.cpfCliente = txtCPF.Text;
            c.emailCliente = txtEmail.Text;
            c.celularCliente = txtCelular.Text;
            c.telComercialCliente = txtTelefoneComercial.Text;
            c.telResidencialCliente = txtTelefoneResidencial.Text;
            c.senhaCliente = txtSenha.Text;
            c.dtNascCliente = dateTimePicker1.Value;
            c.recebeNewsLetter = chkBoxNew.Checked;
            c.Salvar();
            
            MessageBox.Show("SUCESSO! CADASTROU!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListarClientes l = new ListarClientes();
            l.Show();
        }
    }
}

