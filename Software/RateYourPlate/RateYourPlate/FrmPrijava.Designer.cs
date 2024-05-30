using System.Drawing;
using System.Windows.Forms;

namespace RateYourPlate
{
    partial class FrmPrijava
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

        private void InitializeComponent()
        {
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblKorIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackgroundImage = global::RateYourPlate.Properties.Resources.imeApp_removebg_preview;
            this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbLogo.Location = new System.Drawing.Point(155, 42);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(295, 101);
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // lblKorIme
            // 
            this.lblKorIme.AutoSize = true;
            this.lblKorIme.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorIme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKorIme.Location = new System.Drawing.Point(176, 183);
            this.lblKorIme.Name = "lblKorIme";
            this.lblKorIme.Size = new System.Drawing.Size(190, 23);
            this.lblKorIme.TabIndex = 1;
            this.lblKorIme.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLozinka.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLozinka.Location = new System.Drawing.Point(176, 277);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(106, 23);
            this.lblLozinka.TabIndex = 2;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // txtKorIme
            // 
            this.txtKorIme.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorIme.ForeColor = System.Drawing.Color.Indigo;
            this.txtKorIme.Location = new System.Drawing.Point(175, 218);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(258, 30);
            this.txtKorIme.TabIndex = 3;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLozinka.ForeColor = System.Drawing.Color.Indigo;
            this.txtLozinka.Location = new System.Drawing.Point(175, 312);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(258, 30);
            this.txtLozinka.TabIndex = 4;
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.Purple;
            this.btnPrijava.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnPrijava.FlatAppearance.BorderSize = 0;
            this.btnPrijava.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijava.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrijava.Location = new System.Drawing.Point(250, 380);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(102, 35);
            this.btnPrijava.TabIndex = 5;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.BtnPrijava_Click);
            // 
            // FrmPrijava
            // 
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(607, 458);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorIme);
            this.Controls.Add(this.pcbLogo);
            this.Name = "FrmPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblKorIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnPrijava;
    }
}