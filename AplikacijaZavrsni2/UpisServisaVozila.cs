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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplikacijaZavrsni2
{
    public partial class UpisServisaVozila : Form
    {
        private readonly MechanicContext dbContext;

        public UpisServisaVozila(MechanicContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpisServisa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUpisServisaKMService.Text) ||
                    string.IsNullOrEmpty(txtUpisServisaNextKMService.Text) ||
                    string.IsNullOrEmpty(txtUpisServisaServiceType.Text))
                {
                    MessageBox.Show("Sva polja su obavezna.");
                    return;
                }

                if (!double.TryParse(txtUpisServisaKMService.Text, out double kmService) || !double.TryParse(txtUpisServisaNextKMService.Text, out double nextKmService))
                {
                    MessageBox.Show("Neispravan unos za kilometražu.");
                    return;
                }

                string serviceType = txtUpisServisaServiceType.Text;

                DateTime selectedDate = dateTimePicker1.Value;

                DateOnly dateOfService = new DateOnly(selectedDate.Year, selectedDate.Month, selectedDate.Day);

                int vin = Convert.ToInt32(txtUpisServisaVozilaVINvozila.Text);
                long oib = Convert.ToInt32(txtUpisServisaVozilaUpisServisa.Text);
                Service newService = new Service
                {
                    ServiceType = serviceType,
                    DateOfservice = dateOfService,
                    KMService = kmService,
                    NextKMService = nextKmService,
                    IDVehicle = vin,
                    OIB = oib
                };

                dbContext.Services.Add(newService);
                dbContext.SaveChanges();

                MessageBox.Show("Servis uspješno dodan u bazu podataka.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void txtUpisServisaVozilaUpisServisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUpisServisaVozilaVINvozila_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
