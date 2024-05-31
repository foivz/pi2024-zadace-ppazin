namespace RateYourPlate
{
    partial class FrmNewDailyMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNewMenus = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GlavnoJelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prilog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewMenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNewMenus
            // 
            this.dgvNewMenus.AllowUserToResizeColumns = false;
            this.dgvNewMenus.AllowUserToResizeRows = false;
            this.dgvNewMenus.BackgroundColor = System.Drawing.Color.Indigo;
            this.dgvNewMenus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNewMenus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNewMenus.ColumnHeadersHeight = 30;
            this.dgvNewMenus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Juha,
            this.GlavnoJelo,
            this.Prilog,
            this.Desert});
            this.dgvNewMenus.GridColor = System.Drawing.Color.Violet;
            this.dgvNewMenus.Location = new System.Drawing.Point(94, 198);
            this.dgvNewMenus.Name = "dgvNewMenus";
            this.dgvNewMenus.RowHeadersVisible = false;
            this.dgvNewMenus.RowHeadersWidth = 168;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvNewMenus.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNewMenus.RowTemplate.Height = 30;
            this.dgvNewMenus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvNewMenus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvNewMenus.Size = new System.Drawing.Size(695, 150);
            this.dgvNewMenus.TabIndex = 30;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 130;
            // 
            // Juha
            // 
            this.Juha.HeaderText = "Juha";
            this.Juha.MinimumWidth = 6;
            this.Juha.Name = "Juha";
            this.Juha.Width = 130;
            // 
            // GlavnoJelo
            // 
            this.GlavnoJelo.HeaderText = "Glavno jelo";
            this.GlavnoJelo.MinimumWidth = 6;
            this.GlavnoJelo.Name = "GlavnoJelo";
            this.GlavnoJelo.Width = 130;
            // 
            // Prilog
            // 
            this.Prilog.HeaderText = "Prilog";
            this.Prilog.MinimumWidth = 6;
            this.Prilog.Name = "Prilog";
            this.Prilog.Width = 130;
            // 
            // Desert
            // 
            this.Desert.HeaderText = "Desert";
            this.Desert.MinimumWidth = 6;
            this.Desert.Name = "Desert";
            this.Desert.Width = 130;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::RateYourPlate.Properties.Resources.imeApp_removebg_preview;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(328, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(202, 78);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::RateYourPlate.Properties.Resources._768px_Eo_circle_purple_arrow_left_svg_removebg_preview__2_;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Violet;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 50);
            this.btnBack.TabIndex = 26;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RateYourPlate.Properties.Resources.images_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(421, 403);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 27);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
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
            this.btnSpremi.Location = new System.Drawing.Point(368, 436);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(133, 50);
            this.btnSpremi.TabIndex = 27;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.Purple;
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.LightSteelBlue;
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Purple;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Indigo;
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Purple;
            this.dateTimePicker.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(286, 128);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(279, 27);
            this.dateTimePicker.TabIndex = 29;
            // 
            // FrmNewDailyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(879, 508);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dgvNewMenus);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FrmNewDailyMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj novi meni";
            this.Load += new System.EventHandler(this.FrmNewDailyMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewMenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNewMenus;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juha;
        private System.Windows.Forms.DataGridViewTextBoxColumn GlavnoJelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prilog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desert;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}