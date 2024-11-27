
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}

