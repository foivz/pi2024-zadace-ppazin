using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RateYourPlate.Models;
using DBLayer;
using System.Data.Common;
using System.Diagnostics;
using System.Security.Cryptography;

namespace RateYourPlate
{
    public partial class FrmTrazi : Form
    {
        public int brojac = 0;
        public FrmTrazi()
        {
            InitializeComponent();
            FrmTrazi_Load();
            CmbLoad();
        }

        private void FrmTrazi_Load()
        {
            DB.SetConfiguration("PI2324_ppazin22_DB", "PI2324_ppazin22_User", "tR$*PV>_");
            dateTimePicker.Value = DateTime.Now;
            DateTime firstDate = dateTimePicker.Value;
            string formattedDate = firstDate.Date.ToString("yyyy-MM-dd");
            GetDailyMenus(formattedDate);
        }

        private void CmbLoad()
        {
            List<string> menuNames = new List<string>
        {
            "Meni 1",
            "Meni 2",
            "Meni 3"
        };
            cmbMenus.DataSource = menuNames;
        }

        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            DateTime chosenDate = dateTimePicker.Value;
            string formattedDate = chosenDate.Date.ToString("yyyy-MM-dd");
            List<MenuDetails> menuDetailsList = GetDailyMenus(formattedDate);
        }

        private List<MenuDetails> GetDailyMenus(string datum) //radi o hvala ti boze
        {
            Menu dailyMenu = MenuRepository.GetDailyMenus(datum);

            if (dailyMenu != null && dailyMenu.Id != null && dailyMenu.Menu1 != null && dailyMenu.Menu2 != null && dailyMenu.Menu3 != null)
            {
                btnNew.Visible = false;
                lblLink.Visible = false;
                btnIzmjeni.Visible = true;
                btnObrisi.Visible = true;
                dgvMenus.Visible = true;
                lblMeni1.Visible = true;
                lblMeni2.Visible = true;
                lblMeni3.Visible = true;
                MenuDetails menu1 = MenuRepository.GetMenuDetails(dailyMenu.Menu1, "1");
                MenuDetails menu2 = MenuRepository.GetMenuDetails(dailyMenu.Menu2, "2");
                MenuDetails menu3 = MenuRepository.GetMenuDetails(dailyMenu.Menu3, "3");

                List<MenuDetails> menuDetailsList = new List<MenuDetails>();

                menuDetailsList.Add(menu1);
                menuDetailsList.Add(menu2);
                menuDetailsList.Add(menu3);

                dgvMenus.DataSource = menuDetailsList;
                dgvMenus.Columns["Id"].Visible = false;
                dgvMenus.Columns["Juha"].Width = 125;
                dgvMenus.Columns["GlavnoJelo"].Width = 125;
                dgvMenus.Columns["Prilog"].Width = 125;
                dgvMenus.Columns["Desert"].Width = 125;
                dgvMenus.Columns["GlavnoJelo"].HeaderText = "Glavno jelo";
                dgvMenus.Refresh();
                return menuDetailsList;

            }

            else
            {
                bool menu1Existance = true;
                bool menu2Existance = true;
                bool menu3Existance = true;
                string dontExist = ""; 
                
                if (dailyMenu == null)
                {
                    MessageBox.Show("Za odabran datum meniji nisu prethodno definirani.");
                }

                else
                {
                    if (dailyMenu.Menu1 == null)
                    {
                        menu1Existance = false;
                        dontExist = dontExist + "Meni 1";
                    }

                    if (dailyMenu.Menu2 == null)
                    {
                        menu2Existance = false;
                        dontExist = dontExist + " Meni 2 ";
                    }

                    if (dailyMenu.Menu3 == null)
                    {
                        menu3Existance = false;
                        dontExist = dontExist + "Meni 3";
                    }

                    MessageBox.Show("Meniji koji nisu uneseni za odabran datum: " + dontExist);

                    dgvMenus.Visible = false;
                    lblMeni1.Visible = false;
                    lblMeni2.Visible = false;
                    lblMeni3.Visible = false;
                    cmbMenus.Visible = false;
                    btnObrisi.Visible = false;
                    dgvMenus.DataSource = null;
                    lblLink.Visible = true;
                    btnNew.Visible = true;
                    return null;
                }

                dgvMenus.Visible = false;
                lblMeni1.Visible = false;
                lblMeni2.Visible = false;
                lblMeni3.Visible = false;
                cmbMenus.Visible = false;
                btnObrisi.Visible = false;
                btnIzmjeni.Visible = false;
                dgvMenus.DataSource = null;
                lblLink.Visible = true;
                btnNew.Visible = true;
                return null;
            } 
        }


        private void BtnIzmjeni_Click(object sender, EventArgs e)
        {
            DateTime chosenDate = dateTimePicker.Value;
            string formattedDate = chosenDate.Date.ToString("yyyy-MM-dd");
            List<MenuDetails> menuDetailsList = GetDailyMenus(formattedDate);
            int chosenMenu = cmbMenus.SelectedIndex;
            FrmIzmjena newForm = new FrmIzmjena(chosenMenu, menuDetailsList);
            newForm.Show();
            this.Hide();
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string videoId = "qb4D17Ms1p8";
            string youtubeUrl = $"https://www.youtube.com/watch?v={videoId}";

            Process.Start(youtubeUrl);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DateTime chosenDate = dateTimePicker.Value;
            string formattedDate = chosenDate.Date.ToString("yyyy-MM-dd");
            Menu dailyMenu = MenuRepository.GetDailyMenus(formattedDate);
            int idDailyMenu = dailyMenu.Id;
            DeleteFromDb(idDailyMenu);
            MessageBox.Show("Obrisani meniji za datum " + formattedDate);
        }

        private void DeleteFromDb(int id)
        {
            DB.OpenConnection();
            string query = $"DELETE FROM Menu WHERE Id = {id}";
            DB.ExecuteCommand(query);
            DB.CloseConnection();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmNewDailyMenu newForm = new FrmNewDailyMenu();
            newForm.Show();
            this.Hide();
        }
    }
}
