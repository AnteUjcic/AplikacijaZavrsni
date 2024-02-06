using Microsoft.EntityFrameworkCore;
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
    public partial class BrisanjeVozila : Form
    {
        private readonly MechanicContext dbContext;

        public BrisanjeVozila(MechanicContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
        }

        private void txtBrisanjeVozilaBrisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                int vehicleIdToDelete = Convert.ToInt16(txtBrisanjeVozilaBrisi.Text);

              

                var vehicleToDelete = dbContext.Vehicle
                    .FirstOrDefault(v => v.IDVehicle == vehicleIdToDelete);

                if (vehicleToDelete != null)
                {
                    var relatedServices = dbContext.Services
                  .Where(s => s.IDVehicle == vehicleIdToDelete).ToList();
                    dbContext.Services.RemoveRange(relatedServices);

                    dbContext.Vehicle.Remove(vehicleToDelete);
                    dbContext.SaveChanges();

                    MessageBox.Show("Vozilo uspješno uklonjeno iz baze podataka.");
                    this.Close(); 

                }
                else
                {
                    MessageBox.Show("Vozilo nije pronađeno.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }
    }
}
