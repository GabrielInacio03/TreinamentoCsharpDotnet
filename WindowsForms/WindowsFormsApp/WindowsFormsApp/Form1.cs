using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Models;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string nomeUsuario = "Usuário: Gabriel Inácio, do estado de "+ ((Estado)cboEstados.SelectedItem).Id;
            txtNomeUsuario.Text = nomeUsuario;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var formshow = new FormShow();
            formshow.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Inicializando o Formulário");
            cboEstados.Items.Clear();
            foreach (var item in Estado.BuscarEstados())
            {
                cboEstados.Items.Add(item.ToString());
            }
        }
    }
}
