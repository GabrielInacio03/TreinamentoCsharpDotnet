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
            IniciarCboEstados();
            IniciarDataGridView();
        }
        private void IniciarDataGridView()
        {
            //maneira simples
            //dataGridView1.DataSource = Cliente.ListaDeClientes();

            //maneira complexa
            //dataGridView1.ColumnCount = 2;
            //dataGridView1.Columns[0].Name = "ID";
            //dataGridView1.Columns[1].Name = "Nome";

            //var rows = new List<string[]>();
            //foreach (var item in Cliente.ListaDeClientes())
            //{
            //    string[] row = new string[] { item.Id.ToString(), item.Nome };
            //    rows.Add(row);
            //}

            //foreach (var item in rows)
            //{
            //    dataGridView1.Rows.Add(item);
            //}

            //maneira intermediária
            var data = from cliente in Cliente.ListaDeClientes()
                       //where
                       orderby cliente.Nome
                       select new 
                       {
                           Id = cliente.Id,
                           Nome = cliente.Nome,
                           Cpf = cliente.Cpf
                       };
            dataGridView1.DataSource = data.ToList();
        }
        private void IniciarCboEstados()
        {
            cboEstados.DataSource = Estado.BuscarEstados();
            //cboEstados.Items.Clear();
            //foreach (var item in Estado.BuscarEstados())
            //{
            //    cboEstados.Items.Add(item.ToString());
            //}
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmSobre = new FrmSobre();
            frmSobre.Show();
        }

        private void novoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmTexto = new FrmTexto();
            frmTexto.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLicenca = new FrmLicenca();
            frmLicenca.Show();
        }

        private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmDoacao = new FrmDoacao();
            frmDoacao.Show();
        }
    }
}
