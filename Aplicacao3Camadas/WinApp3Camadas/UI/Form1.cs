using Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Nome = txtNome.Text;
            user.Telefone = txtTelefone.Text;
            user.Cpf = txtCpf.Text;


            user.Gravar();
            MessageBox.Show("Usuário salvo com sucesso!");
        }
    }
}
