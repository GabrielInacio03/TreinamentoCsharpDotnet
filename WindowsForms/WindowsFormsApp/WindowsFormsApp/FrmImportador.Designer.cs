
namespace WindowsFormsApp
{
    partial class FrmImportador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnImportar = new System.Windows.Forms.Button();
            this.lblimportar = new System.Windows.Forms.Label();
            this.txtImportador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(148, 143);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(541, 79);
            this.progressBar.TabIndex = 1;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(209, 456);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(403, 82);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "IMPORTAR";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // lblimportar
            // 
            this.lblimportar.AutoSize = true;
            this.lblimportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimportar.Location = new System.Drawing.Point(71, 87);
            this.lblimportar.Name = "lblimportar";
            this.lblimportar.Size = new System.Drawing.Size(715, 37);
            this.lblimportar.TabIndex = 3;
            this.lblimportar.Text = "Clique no botão importar para atualizar os dados";
            // 
            // txtImportador
            // 
            this.txtImportador.Location = new System.Drawing.Point(148, 245);
            this.txtImportador.Multiline = true;
            this.txtImportador.Name = "txtImportador";
            this.txtImportador.Size = new System.Drawing.Size(541, 188);
            this.txtImportador.TabIndex = 4;
            // 
            // FrmImportador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 550);
            this.Controls.Add(this.txtImportador);
            this.Controls.Add(this.lblimportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.progressBar);
            this.Name = "FrmImportador";
            this.Text = "FrmImportador";
            this.Load += new System.EventHandler(this.FrmImportador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Label lblimportar;
        private System.Windows.Forms.TextBox txtImportador;
    }
}