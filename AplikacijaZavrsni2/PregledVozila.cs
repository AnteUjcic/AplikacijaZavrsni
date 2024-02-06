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
    public partial class PregledVozila : Form
    {
        private readonly MechanicContext dbContext;

        public PregledVozila(MechanicContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
        }

        private void btnPregledVozila_Click(object sender, EventArgs e)
        {
            try
            {
                var allVehicles = dbContext.Vehicle.ToList();
                dataGridView1.DataSource = allVehicles;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
