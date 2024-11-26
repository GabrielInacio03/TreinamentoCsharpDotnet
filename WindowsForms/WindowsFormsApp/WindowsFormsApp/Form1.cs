using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string nomeUsuario = "Gabriel Inácio";
            txtNomeUsuario.Text = nomeUsuario;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var formshow = new FormShow();
            formshow.Show();
        }
    }
}
