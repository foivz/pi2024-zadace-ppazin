using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RateYourPlate.Models;
using DBLayer;

namespace RateYourPlate
{
    public partial class FrmIzmjena : Form
    {
        public int menu;
        public List<MenuDetails> menuDetails;
        public FrmIzmjena(int chosenMenu, List<MenuDetails> menuDetailsList)
        {
            InitializeComponent();
            menu = chosenMenu;
            this.menuDetails = menuDetailsList;
        }

        private void FrmIzmjena_Load(object sender, EventArgs e)
        {
            List<MenuDetails> chosenMenu = MenuSwitch(menu, menuDetails);
            dgvMenuIzmjena.DataSource = chosenMenu;
            dgvMenuIzmjena.Columns["Id"].Visible = false;
            dgvMenuIzmjena.Columns["Juha"].Width = 125;
            dgvMenuIzmjena.Columns["GlavnoJelo"].Width = 125;
            dgvMenuIzmjena.Columns["Prilog"].Width = 125;
            dgvMenuIzmjena.Columns["Desert"].Width = 125;
            dgvMenuIzmjena.Columns["GlavnoJelo"].HeaderText = "Glavno jelo";
            dgvMenuIzmjena.Refresh();
        }

        public List<MenuDetails> MenuSwitch(int index, List<MenuDetails> menuDetails)
        {
            switch(index)
            {
                case 0:
                    List<MenuDetails> menu1 = new List<MenuDetails>();
                    menu1.Add(menuDetails[0]);
                    return menu1;  
                case 1:
                    List<MenuDetails> menu2 = new List<MenuDetails>();
                    menu2.Add(menuDetails[1]);
                    return menu2;    
                case 2:
                    List<MenuDetails> menu3 = new List<MenuDetails>();
                    menu3.Add(menuDetails[2]);
                    return menu3;
                default: return menuDetails;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            List<MenuDetails> changedMenus = new List<MenuDetails>();

            foreach (DataGridViewRow row in dgvMenuIzmjena.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool allValuesPresent = true;
                    string missingFields = "";

                    for (int i = 0; i <= 4; i++)
                    {
                        if (row.Cells[i].Value == null || row.Cells[i].Value.ToString() == "")
                        {
                            string stupac = "";
                            allValuesPresent = false;
                            switch(i)
                            {
                                case 1: stupac = "juhu"; break;
                                case 2: stupac = "glavno jelo"; break;
                                case 3: stupac = "prilog"; break;
                                case 4: stupac = "desert"; break;
                            }
                            missingFields += $"Nedostaju podatci za {stupac}.\n";
                        }
                    }

                    if (allValuesPresent)
                    {
                        MenuDetails meni = new MenuDetails
                        {
                            Id = (int)row.Cells[0].Value,
                            Juha = row.Cells[1].Value.ToString(),
                            GlavnoJelo = row.Cells[2].Value.ToString(),
                            Prilog = row.Cells[3].Value.ToString(),
                            Desert = row.Cells[4].Value.ToString(),
                        };

                        changedMenus.Add(meni);

                        UpdateDb(meni);
                    }
                    else
                    {
                        MessageBox.Show("Niste unjeli sve potrebne podatka!\n" + missingFields);
                    }
                }
            }
        }

        private void UpdateDb(MenuDetails meni)
        {
            int index = menu + 1;  
            string Id = meni.Id.ToString();
            string menuIndex = $"Menu{index}";
            string juhaIndex = $"juha{index}";
            string glavnoJeloIndex = $"glavnoJelo{index}";
            string prilogIndex = $"prilog{index}";
            string desertIndex = $"desert{index}";
            string IdMeniIndex = $"IdMeni{index}";
            DB.OpenConnection();
            string query = $"UPDATE {menuIndex} SET {juhaIndex} = '{meni.Juha}', {glavnoJeloIndex} = '{meni.GlavnoJelo}', {prilogIndex} = '{meni.Prilog}', {desertIndex} = '{meni.Desert}' WHERE {IdMeniIndex} = {Id}";
            DB.ExecuteCommand(query);
            DB.CloseConnection();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmTrazi newForm = new FrmTrazi();
            newForm.Show();
            this.Hide();
        }
    }
}
