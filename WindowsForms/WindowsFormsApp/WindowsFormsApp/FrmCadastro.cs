using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Models.Exceptions;

namespace WindowsFormsApp
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
            try
            {
                string nome = txtNome.Text;
                int numero = int.Parse(txtNumero.Text);

                if (numero == 0)
                    throw new ErroDeProposito("Numero deve ser maior que 0");


                MessageBox.Show($"Olá {nome}, o valor {numero} + 10 é igual a {numero + 10}");
            }
            catch(ErroDeProposito errp)
            {
                MessageBox.Show("Erro, número deve ser maior que 0");
                Console.WriteLine($"ErroDeProposito: {errp.Message}");
                txtNumero.Focus();
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Erro de Conversão");
                MessageBox.Show("Erro, tipo numero invalido");
                txtNumero.Focus();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Algo inesperado aconteceu! Tente novamente mais tarde");
                Console.WriteLine($"Error.Message: {ex.Message}");
                Console.WriteLine($"Erro.InnerException: {ex.InnerException?.StackTrace}");
                 
                MessageBox.Show($"Algo inesperado aconteceu! Tente novamente mais tarde" +
                    $"\nError.Message: {ex.Message}" );
            }
           
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
