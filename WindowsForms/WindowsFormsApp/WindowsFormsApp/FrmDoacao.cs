﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FrmDoacao : Form
    {
        public FrmDoacao()
        {
            InitializeComponent();
        }

        private void btnDoacao_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.torneseumprogramador.com.br/");
        }
    }
}
