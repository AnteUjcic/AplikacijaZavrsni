using Microsoft.EntityFrameworkCore;
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
    public partial class PregledServisa : Form
    {
        private readonly MechanicContext dbContext;

        public PregledServisa(MechanicContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
        }


        private void btnPregledServisaPregled_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtPregledServisaUpisVIN.Text, out int vehicleID))
                {
                    MessageBox.Show("Unesite ispravan ID vozila.");
                    return;
                }

                var servicesVehicle = dbContext.Services
                    .Where(s => s.IDVehicle == vehicleID)
                    .Join(dbContext.Workers,
                        service => service.OIB,
                        worker => worker.OIB,
                        (service, worker) => new
                        {
                            service.IDVehicle,
                            service.OIB,
                            service.ServiceType,
                            service.DateOfservice,
                            service.KMService,
                            service.NextKMService,
                            worker.WorkerName
                        })
                    .Join(dbContext.Vehicle,
                        joined => joined.IDVehicle,
                        vehicle => vehicle.IDVehicle,
                        (joined, vehicle) => new
                        {
                            joined.IDVehicle,
                            joined.OIB,
                            joined.ServiceType,
                            joined.DateOfservice,
                            joined.KMService,
                            joined.NextKMService,
                            joined.WorkerName,
                            vehicle.Brand
                        })
                    .ToList();

                dataGridView1.DataSource = servicesVehicle;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPregledServisaUpisVIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void PregledServisa_Load(object sender, EventArgs e)
        {

        }
    }
}
