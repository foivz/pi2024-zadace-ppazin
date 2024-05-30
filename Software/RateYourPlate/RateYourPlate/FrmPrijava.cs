using RateYourPlate;
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

namespace RateYourPlate
{
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            string username = txtKorIme.Text;
            string password = txtLozinka.Text;

            if (PrijavaRepository.CheckUser(username))
            {
                if (PrijavaRepository.CheckPass(password))
                {
                    FrmTrazi newForm = new FrmTrazi();

                    newForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Neispravna lozinka.");
                }

            }
            else
            {
                MessageBox.Show("Podatci neispravni.");
            }
        }
    }
}
