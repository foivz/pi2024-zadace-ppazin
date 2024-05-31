using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DBLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RateYourPlate
{
    public partial class FrmNewDailyMenu : Form
    {
        public DateTime datum;
        public FrmNewDailyMenu()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmTrazi newForm = new FrmTrazi();
            newForm.Show();
            this.Hide();
        }

        private void FrmNewDailyMenu_Load(object sender, EventArgs e)
        {
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            List<MenuDetails> list = new List<MenuDetails>();
            MenuDetails menu1 = new MenuDetails();
            MenuDetails menu2 = new MenuDetails();
            MenuDetails menu3 = new MenuDetails();
            int brojac = 0;
            Random random = new Random();

            foreach (DataGridViewRow row in dgvNewMenus.Rows)
            {
                brojac = brojac + 1;
                
                if (!row.IsNewRow)
                {
                    MenuDetails meni = new MenuDetails
                    {
                        Id = random.Next(),
                        Juha = row.Cells["Juha"].Value.ToString(),
                        GlavnoJelo = row.Cells["GlavnoJelo"].Value.ToString(),
                        Prilog = row.Cells["Prilog"].Value.ToString(),
                        Desert = row.Cells["Desert"].Value.ToString(),
                    };

                    // Add the MyData object to the list
                    list.Add(meni);
                }
            }

            if (brojac < 3)
            {
                MessageBox.Show("Potrebno je unesti tri menija.");
                list.Clear();
            }
            else
            {
                menu1 = list[0];
                menu2 = list[1];
                menu3 = list[2];
                UpdateDbMenus(menu1, menu2, menu3);
                Menu dailyMenu = new Menu();
                dailyMenu.Id = random.Next();
                dailyMenu.Menu1 = menu1.Id;
                dailyMenu.Menu2 = menu2.Id;
                dailyMenu.Menu3 = menu3.Id;
                dailyMenu.Datum = dateTimePicker.Value;
                UpdateDbDailyMenus(dailyMenu);
                MessageBox.Show("Dnevni meni unesen!");
            }


        }

        private void UpdateDbMenus(MenuDetails menu1, MenuDetails menu2, MenuDetails menu3)
        {
            DB.OpenConnection();
            string query1 = $"INSERT INTO Menu1 (IdMeni1, juha1, glavnoJelo1, prilog1, desert1) VALUES ({menu1.Id}, '{menu1.Juha}', '{menu1.GlavnoJelo}', '{menu1.Prilog}', '{menu1.Desert}')";
            DB.ExecuteCommand(query1);
            DB.CloseConnection();
            DB.OpenConnection();
            string query2 = $"INSERT INTO Menu2 (IdMeni2, juha2, glavnoJelo2, prilog2, desert2) VALUES ({menu2.Id}, '{menu2.Juha}', '{menu2.GlavnoJelo}', '{menu2.Prilog}', '{menu2.Desert}')";
            DB.ExecuteCommand(query2);
            DB.CloseConnection();
            DB.OpenConnection();
            string query3 = $"INSERT INTO Menu3 (IdMeni3, juha3, glavnoJelo3, prilog3, desert3) VALUES ( {menu3.Id}, '{menu3.Juha}', '{menu3.GlavnoJelo}', '{menu3.Prilog}', '{menu3.Desert}')";
            DB.ExecuteCommand(query3);
            DB.CloseConnection();
        }

        private void UpdateDbDailyMenus(Menu dailyMenu)
        {
            DB.OpenConnection();
            string formattedDate = dailyMenu.Datum.Date.ToString("yyyy-MM-dd");
            string query = $"INSERT INTO Menu (Id, IdMeni1, IdMeni2, IdMeni3, datum) VALUES ({dailyMenu.Id}, {dailyMenu.Menu1}, {dailyMenu.Menu2}, {dailyMenu.Menu3}, '{formattedDate}')";
            DB.ExecuteCommand(query);
            DB.CloseConnection();
        }
    }
}
