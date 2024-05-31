using System.Drawing;
using System.Windows.Forms;

namespace RateYourPlate
{
    partial class FrmIzmjena
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMenuIzmjena = new System.Windows.Forms.DataGridView();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuIzmjena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMenuIzmjena
            // 
            this.dgvMenuIzmjena.AllowUserToResizeColumns = false;
            this.dgvMenuIzmjena.AllowUserToResizeRows = false;
            this.dgvMenuIzmjena.BackgroundColor = System.Drawing.Color.Indigo;
            this.dgvMenuIzmjena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenuIzmjena.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenuIzmjena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuIzmjena.GridColor = System.Drawing.Color.Violet;
            this.dgvMenuIzmjena.Location = new System.Drawing.Point(69, 158);
            this.dgvMenuIzmjena.Name = "dgvMenuIzmjena";
            this.dgvMenuIzmjena.RowHeadersVisible = false;
            this.dgvMenuIzmjena.RowHeadersWidth = 165;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMenuIzmjena.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMenuIzmjena.RowTemplate.Height = 50;
            this.dgvMenuIzmjena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvMenuIzmjena.Size = new System.Drawing.Size(668, 90);
            this.dgvMenuIzmjena.TabIndex = 0;
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.Purple;
            this.btnSpremi.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnSpremi.FlatAppearance.BorderSize = 0;
            this.btnSpremi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSpremi.Location = new System.Drawing.Point(336, 369);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(133, 50);
            this.btnSpremi.TabIndex = 1;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::RateYourPlate.Properties.Resources._768px_Eo_circle_purple_arrow_left_svg_removebg_preview__2_;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Violet;
            this.btnBack.Location = new System.Drawing.Point(15, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 50);
            this.btnBack.TabIndex = 6;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::RateYourPlate.Properties.Resources.imeApp_removebg_preview;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(307, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(183, 78);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RateYourPlate.Properties.Resources.images_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(389, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 27);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmIzmjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dgvMenuIzmjena);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "FrmIzmjena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uređivanje";
            this.Load += new System.EventHandler(this.FrmIzmjena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuIzmjena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenuIzmjena;
        private System.Windows.Forms.BindingSource menu1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMeni1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juha1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glavnoJelo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prilog1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desert1DataGridViewTextBoxColumn;
        private Button btnSpremi;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button btnBack;
    }
}