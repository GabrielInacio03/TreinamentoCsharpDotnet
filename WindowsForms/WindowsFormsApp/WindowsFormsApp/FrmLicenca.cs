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
    public partial class FrmLicenca : Form
    {
        public FrmLicenca()
        {
            InitializeComponent();
        }

        private void btnLicenca_Click(object sender, EventArgs e)
        {
            var guid = new Guid().ToString();
            txtLicenca.Text = guid;
        }
    }
}
