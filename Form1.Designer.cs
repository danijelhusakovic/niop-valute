namespace konverter_valuta
{
    partial class Form1
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
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblValuta = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.cmbValuta = new System.Windows.Forms.ComboBox();
            this.btnPretvori = new System.Windows.Forms.Button();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(16, 51);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(41, 16);
            this.lblIznos.TabIndex = 0;
            this.lblIznos.Text = "Iznos:";
            // 
            // lblValuta
            // 
            this.lblValuta.AutoSize = true;
            this.lblValuta.Location = new System.Drawing.Point(16, 86);
            this.lblValuta.Name = "lblValuta";
            this.lblValuta.Size = new System.Drawing.Size(48, 16);
            this.lblValuta.TabIndex = 1;
            this.lblValuta.Text = "Valuta:";
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(99, 51);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(100, 22);
            this.txtIznos.TabIndex = 2;
            // 
            // cmbValuta
            // 
            this.cmbValuta.FormattingEnabled = true;
            this.cmbValuta.Location = new System.Drawing.Point(99, 77);
            this.cmbValuta.Name = "cmbValuta";
            this.cmbValuta.Size = new System.Drawing.Size(100, 24);
            this.cmbValuta.TabIndex = 3;
            // 
            // btnPretvori
            // 
            this.btnPretvori.Location = new System.Drawing.Point(12, 120);
            this.btnPretvori.Name = "btnPretvori";
            this.btnPretvori.Size = new System.Drawing.Size(75, 23);
            this.btnPretvori.TabIndex = 4;
            this.btnPretvori.Text = "Pretvori";
            this.btnPretvori.UseVisualStyleBackColor = true;
            this.btnPretvori.Click += new System.EventHandler(this.btnPretvori_Click);
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(130, 123);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(11, 16);
            this.lblRezultat.TabIndex = 5;
            this.lblRezultat.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.btnPretvori);
            this.Controls.Add(this.cmbValuta);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.lblValuta);
            this.Controls.Add(this.lblIznos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblValuta;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.ComboBox cmbValuta;
        private System.Windows.Forms.Button btnPretvori;
        private System.Windows.Forms.Label lblRezultat;
    }
}

