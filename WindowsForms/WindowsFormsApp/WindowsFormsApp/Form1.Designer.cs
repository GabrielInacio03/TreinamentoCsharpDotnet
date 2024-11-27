
namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDataGridview = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licençaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(45, 64);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(135, 20);
            this.lblNomeUsuario.TabIndex = 0;
            this.lblNomeUsuario.Text = "Nome Do Usuário";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(49, 87);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(312, 26);
            this.txtNomeUsuario.TabIndex = 1;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(49, 201);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(312, 77);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "Clicar";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(49, 300);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(312, 107);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "SHOW Formulário";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Items.AddRange(new object[] {
            "Selecione",
            "São Paulo",
            "Rio de Janeiro",
            "Minas Gerais"});
            this.cboEstados.Location = new System.Drawing.Point(49, 147);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(312, 28);
            this.cboEstados.TabIndex = 4;
            this.cboEstados.Text = "-- Selecione --";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(45, 122);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(68, 20);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(401, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(542, 191);
            this.dataGridView1.TabIndex = 6;
            // 
            // lblDataGridview
            // 
            this.lblDataGridview.AutoSize = true;
            this.lblDataGridview.Location = new System.Drawing.Point(397, 87);
            this.lblDataGridview.Name = "lblDataGridview";
            this.lblDataGridview.Size = new System.Drawing.Size(126, 20);
            this.lblDataGridview.TabIndex = 7;
            this.lblDataGridview.Text = "Lista de Clientes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(970, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoTextoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoTextoToolStripMenuItem
            // 
            this.novoTextoToolStripMenuItem.Name = "novoTextoToolStripMenuItem";
            this.novoTextoToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
            this.novoTextoToolStripMenuItem.Text = "Novo Texto";
            this.novoTextoToolStripMenuItem.Click += new System.EventHandler(this.novoTextoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.licençaToolStripMenuItem,
            this.doaçãoToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // licençaToolStripMenuItem
            // 
            this.licençaToolStripMenuItem.Name = "licençaToolStripMenuItem";
            this.licençaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.licençaToolStripMenuItem.Text = "Licença";
            this.licençaToolStripMenuItem.Click += new System.EventHandler(this.licençaToolStripMenuItem_Click);
            // 
            // doaçãoToolStripMenuItem
            // 
            this.doaçãoToolStripMenuItem.Name = "doaçãoToolStripMenuItem";
            this.doaçãoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.doaçãoToolStripMenuItem.Text = "Doacao";
            this.doaçãoToolStripMenuItem.Click += new System.EventHandler(this.doaçãoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 480);
            this.Controls.Add(this.lblDataGridview);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDataGridview;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licençaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

