using System;
using System.Drawing;
using System.Windows.Forms;

namespace RateYourPlate
{
    partial class FrmTrazi
    {
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BtnPretrazi = new System.Windows.Forms.Button();
            this.lblMeni1 = new System.Windows.Forms.Label();
            this.lblMeni3 = new System.Windows.Forms.Label();
            this.lblMeni2 = new System.Windows.Forms.Label();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.dgvMenus = new System.Windows.Forms.DataGridView();
            this.menu1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meni1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menu2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meni2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menu3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meni3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMenus = new System.Windows.Forms.ComboBox();
            this.menuBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meni1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meni2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meni3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.Purple;
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.LightSteelBlue;
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Purple;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Indigo;
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Purple;
            this.dateTimePicker.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(38, 39);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(279, 27);
            this.dateTimePicker.TabIndex = 0;
            // 
            // BtnPretrazi
            // 
            this.BtnPretrazi.BackColor = System.Drawing.Color.Purple;
            this.BtnPretrazi.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.BtnPretrazi.FlatAppearance.BorderSize = 0;
            this.BtnPretrazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPretrazi.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPretrazi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnPretrazi.Location = new System.Drawing.Point(351, 31);
            this.BtnPretrazi.Name = "BtnPretrazi";
            this.BtnPretrazi.Size = new System.Drawing.Size(120, 50);
            this.BtnPretrazi.TabIndex = 1;
            this.BtnPretrazi.Text = "Pretraži";
            this.BtnPretrazi.UseVisualStyleBackColor = false;
            this.BtnPretrazi.Click += new System.EventHandler(this.BtnPretrazi_Click);
            // 
            // lblMeni1
            // 
            this.lblMeni1.AutoSize = true;
            this.lblMeni1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeni1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMeni1.Location = new System.Drawing.Point(134, 219);
            this.lblMeni1.Name = "lblMeni1";
            this.lblMeni1.Size = new System.Drawing.Size(62, 17);
            this.lblMeni1.TabIndex = 2;
            this.lblMeni1.Text = "Meni 1";
            // 
            // lblMeni3
            // 
            this.lblMeni3.AutoSize = true;
            this.lblMeni3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeni3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMeni3.Location = new System.Drawing.Point(134, 297);
            this.lblMeni3.Name = "lblMeni3";
            this.lblMeni3.Size = new System.Drawing.Size(62, 17);
            this.lblMeni3.TabIndex = 3;
            this.lblMeni3.Text = "Meni 3";
            // 
            // lblMeni2
            // 
            this.lblMeni2.AutoSize = true;
            this.lblMeni2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeni2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMeni2.Location = new System.Drawing.Point(134, 257);
            this.lblMeni2.Name = "lblMeni2";
            this.lblMeni2.Size = new System.Drawing.Size(62, 17);
            this.lblMeni2.TabIndex = 4;
            this.lblMeni2.Text = "Meni 2";
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.BackColor = System.Drawing.Color.Purple;
            this.btnIzmjeni.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnIzmjeni.FlatAppearance.BorderSize = 0;
            this.btnIzmjeni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnIzmjeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmjeni.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmjeni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIzmjeni.Location = new System.Drawing.Point(732, 433);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(120, 50);
            this.btnIzmjeni.TabIndex = 21;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = false;
            this.btnIzmjeni.Click += new System.EventHandler(this.BtnIzmjeni_Click);
            // 
            // dgvMenus
            // 
            this.dgvMenus.ReadOnly = true;
            this.dgvMenus.AllowUserToAddRows = false;
            this.dgvMenus.AllowUserToDeleteRows = false;
            this.dgvMenus.AllowUserToResizeColumns = false;
            this.dgvMenus.AllowUserToResizeRows = false;
            this.dgvMenus.BackgroundColor = System.Drawing.Color.Indigo;
            this.dgvMenus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMenus.ColumnHeadersHeight = 30;
            this.dgvMenus.GridColor = System.Drawing.Color.Violet;
            this.dgvMenus.Location = new System.Drawing.Point(218, 175);
            this.dgvMenus.Name = "dgvMenus";
            this.dgvMenus.RowHeadersVisible = false;
            this.dgvMenus.RowHeadersWidth = 110;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMenus.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMenus.RowTemplate.Height = 40;
            this.dgvMenus.Size = new System.Drawing.Size(501, 150);
            this.dgvMenus.TabIndex = 23;
            // 
            // cmbMenus
            // 
            this.cmbMenus.DataSource = this.menuBindingSource2;
            this.cmbMenus.DisplayMember = "IdMeni1";
            this.cmbMenus.Location = new System.Drawing.Point(565, 448);
            this.cmbMenus.Name = "cmbMenus";
            this.cmbMenus.Size = new System.Drawing.Size(143, 25);
            this.cmbMenus.TabIndex = 26;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // lblLink
            // 
            this.lblLink.ActiveLinkColor = System.Drawing.Color.White;
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblLink.Location = new System.Drawing.Point(202, 237);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(569, 20);
            this.lblLink.TabIndex = 27;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "Ukoliko nemate inspiracije za novi meni, kliknite ovdje!";
            this.lblLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.Purple;
            this.btnObrisi.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnObrisi.Location = new System.Drawing.Point(26, 433);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(120, 50);
            this.btnObrisi.TabIndex = 28;
            this.btnObrisi.Text = "Obriši sve";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Purple;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNew.Location = new System.Drawing.Point(506, 31);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(120, 50);
            this.btnNew.TabIndex = 29;
            this.btnNew.Text = "Novi meni";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FrmTrazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(879, 508);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.cmbMenus);
            this.Controls.Add(this.dgvMenus);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.lblMeni2);
            this.Controls.Add(this.lblMeni3);
            this.Controls.Add(this.lblMeni1);
            this.Controls.Add(this.BtnPretrazi);
            this.Controls.Add(this.dateTimePicker);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FrmTrazi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraživanje";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meni1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meni2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meni3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button BtnPretrazi;
        private System.Windows.Forms.Label lblMeni1;
        private System.Windows.Forms.Label lblMeni3;
        private System.Windows.Forms.Label lblMeni2;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.DataGridView dgvMenus;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private System.Windows.Forms.BindingSource meni1BindingSource;
        private System.Windows.Forms.BindingSource meni2BindingSource;
        private System.Windows.Forms.BindingSource meni3BindingSource;
        private System.Windows.Forms.BindingSource menu1BindingSource;
        private System.Windows.Forms.BindingSource menu2BindingSource;
        private System.Windows.Forms.BindingSource menu3BindingSource;
        private System.Windows.Forms.ComboBox cmbMenus;
        private System.Windows.Forms.BindingSource menuBindingSource1;
        private System.Windows.Forms.BindingSource menuBindingSource2;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private DataGridViewTextBoxColumn juha1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn glavnoJelo1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prilog1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn desert1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn juha2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn glavnoJelo2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prilog2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn desert2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn juha3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn glavnoJelo3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prilog3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn desert3DataGridViewTextBoxColumn;
        private LinkLabel lblLink;
        private Button btnObrisi;
        private Button btnNew;
    }
}