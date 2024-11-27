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

namespace WindowsFormsApp
{
    public partial class FrmTexto : Form
    {
        public FrmTexto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }
        private void SalvarArquivo()
        {
            var texto = txtTexto.Text;
            var dataAtual = DateTime.Now.ToString("yyyy-MM-dd");
            var path = @"C:\workspace\Torneseumprogramador\WindowsForms\arq_"+ dataAtual+".txt";

            File.WriteAllText(path, texto);

            MessageBox.Show("Arquivo salvo com sucesso!");
        }
    }
}
