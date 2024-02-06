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

namespace AplikacijaZavrsni2.Data
{
    public partial class RemoveUser : Form
    {
        private readonly MechanicContext dbContext;

        public RemoveUser(MechanicContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            long oibToRemove = Convert.ToInt64(txtBrisanjeKorisnikaDelete.Text);
            var userToRemove = dbContext.Workers.Include(w => w.LoginInfo).FirstOrDefault(w => w.OIB == oibToRemove);

            if (userToRemove != null)
            {
                if (userToRemove.LoginInfo != null)
                {
                    dbContext.LoginInfos.Remove(userToRemove.LoginInfo);
                }

                dbContext.Workers.Remove(userToRemove);
                dbContext.SaveChanges();
                MessageBox.Show("Korisnik uspjesno uklonjen.");
            }
            else
            {
                MessageBox.Show("Korisnik nije pronaden.");
            }
        }

        private void txtBrisanjeKorisnikaDelete_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
