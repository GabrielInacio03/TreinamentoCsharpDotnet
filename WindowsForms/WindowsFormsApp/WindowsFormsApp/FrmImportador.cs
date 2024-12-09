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
    public partial class FrmImportador : Form
    {
        private string[] lines;
        public FrmImportador()
        {
            InitializeComponent();
        }

        private void FrmImportador_Load(object sender, EventArgs e)
        {
            using(var streamReader = File.OpenText(@"C:\workspace\Torneseumprogramador\WindowsForms\dados_importar.txt"))
            {
                lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                progressBar.Maximum = lines.Length;
                progressBar.Minimum = 0;
                
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                progressBar.Value = (i + 1);
                txtImportador.Text += $"{lines[i]} - Importado\n";
                txtImportador.Update();
            }
        }
    }
}
