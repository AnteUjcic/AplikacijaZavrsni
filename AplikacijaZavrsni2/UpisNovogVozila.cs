using ServisAplikacija.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaZavrsni2
{
    public partial class UpisNovogVozila : Form
    {
        private readonly MechanicContext dbContext;

        public UpisNovogVozila(MechanicContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBrand.Text) ||
                    string.IsNullOrEmpty(txtYear.Text) ||
                    string.IsNullOrEmpty(txtNumberOfWheels.Text) ||
                    string.IsNullOrEmpty(txtEngineType.Text) ||
                    string.IsNullOrEmpty(txtNumberOfDoors.Text) ||
                    string.IsNullOrEmpty(txtBodyStyle.Text) ||
                    string.IsNullOrEmpty(txtDriveType.Text))
                {
                    MessageBox.Show("Sva polja su obavezna.");
                    return;
                }

                if (!int.TryParse(txtYear.Text, out int year) ||
                    !int.TryParse(txtNumberOfWheels.Text, out int numberOfWheels) ||
                    !int.TryParse(txtNumberOfDoors.Text, out int numberOfDoors))
                {
                    MessageBox.Show("Neispravan unos za godinu, broj kotača ili broj vrata.");
                    return;
                }

                int VIN = Convert.ToInt32(txtIDVehicle.Text);
                string marka = txtBrand.Text;
                int godina = Convert.ToInt32(txtYear.Text);
                int brojkotaca = Convert.ToInt32(txtNumberOfWheels.Text);
                string tipmotora = txtEngineType.Text;
                int brojvrata = Convert.ToInt32(txtNumberOfDoors.Text);
                string tipkaroserije = txtBodyStyle.Text;
                string vrstapogona = txtDriveType.Text;

                Vehicle newVehicle = new Vehicle
                {
                    IDVehicle = VIN,
                    Brand = marka,
                    Year = godina,
                    NumberOfWheels = brojkotaca,
                    EngineType = tipmotora,
                    NumberOfDoors = brojvrata,
                    BodyStyle = tipkaroserije,
                    DriveType = vrstapogona
                };

                dbContext.Vehicle.Add(newVehicle);
                dbContext.SaveChanges();

                MessageBox.Show("Vozilo uspješno dodano u bazu podataka.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void txtIDVehicle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumberOfWheels_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEngineType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumberOfDoors_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBodyStyle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDriveType_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
