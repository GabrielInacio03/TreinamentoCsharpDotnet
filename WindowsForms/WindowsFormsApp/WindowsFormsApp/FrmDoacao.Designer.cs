
namespace WindowsFormsApp
{
    partial class FrmDoacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoacao));
            this.lblDoacao = new System.Windows.Forms.Label();
            this.btnDoacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDoacao
            // 
            this.lblDoacao.AutoSize = true;
            this.lblDoacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoacao.Location = new System.Drawing.Point(26, 70);
            this.lblDoacao.Name = "lblDoacao";
            this.lblDoacao.Size = new System.Drawing.Size(391, 29);
            this.lblDoacao.TabIndex = 0;
            this.lblDoacao.Text = "Entre no site para realizar a doação";
            // 
            // btnDoacao
            // 
            this.btnDoacao.Location = new System.Drawing.Point(31, 117);
            this.btnDoacao.Name = "btnDoacao";
            this.btnDoacao.Size = new System.Drawing.Size(386, 51);
            this.btnDoacao.TabIndex = 1;
            this.btnDoacao.Text = "Doação";
            this.btnDoacao.UseVisualStyleBackColor = true;
            this.btnDoacao.Click += new System.EventHandler(this.btnDoacao_Click);
            // 
            // FrmDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoacao);
            this.Controls.Add(this.lblDoacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDoacao";
            this.Text = "FrmDoacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoacao;
        private System.Windows.Forms.Button btnDoacao;
    }
}