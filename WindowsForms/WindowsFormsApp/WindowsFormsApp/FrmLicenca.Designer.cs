
namespace WindowsFormsApp
{
    partial class FrmLicenca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLicenca));
            this.txtLicenca = new System.Windows.Forms.TextBox();
            this.btnLicenca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLicenca
            // 
            this.txtLicenca.Enabled = false;
            this.txtLicenca.Location = new System.Drawing.Point(119, 176);
            this.txtLicenca.Name = "txtLicenca";
            this.txtLicenca.Size = new System.Drawing.Size(758, 26);
            this.txtLicenca.TabIndex = 0;
            // 
            // btnLicenca
            // 
            this.btnLicenca.Location = new System.Drawing.Point(119, 218);
            this.btnLicenca.Name = "btnLicenca";
            this.btnLicenca.Size = new System.Drawing.Size(758, 69);
            this.btnLicenca.TabIndex = 1;
            this.btnLicenca.Text = "Gerar Licença";
            this.btnLicenca.UseVisualStyleBackColor = true;
            this.btnLicenca.Click += new System.EventHandler(this.btnLicenca_Click);
            // 
            // FrmLicenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 450);
            this.Controls.Add(this.btnLicenca);
            this.Controls.Add(this.txtLicenca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLicenca";
            this.Text = "FrmLicenca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLicenca;
        private System.Windows.Forms.Button btnLicenca;
    }
}