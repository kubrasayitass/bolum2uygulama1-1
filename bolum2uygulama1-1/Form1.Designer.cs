namespace bolum2uygulama1_1
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
            this.lblYas = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYas.Location = new System.Drawing.Point(23, 76);
            this.lblYas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(51, 24);
            this.lblYas.TabIndex = 0;
            this.lblYas.Text = "Yaş:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurum.Location = new System.Drawing.Point(22, 116);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(192, 30);
            this.lblDurum.TabIndex = 1;
            this.lblDurum.Text = "Durum:__________";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(27, 166);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(187, 40);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(72, 74);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(171, 34);
            this.txtYas.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 881);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblYas);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtYas;
    }
}

