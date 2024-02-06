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

namespace AplikacijaZavrsni2.Data
{
    public partial class AddUser : Form
    {
        public MechanicContext dbContext;

        public AddUser(MechanicContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
        }
        private long GenerateUniqueID()
        {
            long timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            Random random = new Random();
            int randomNumber = random.Next(1000, 9999);

            long uniqueIDLogin = long.Parse($"{timestamp}{randomNumber}");

            return uniqueIDLogin;
        }

        private void btnAddUserAddUser_Click(object sender, EventArgs e)
        {
            try
            {

                string name = txtAddUserName.Text;
                string surename = txtAddUserSurename.Text;
                long AddUserOIB = Convert.ToInt64(txtAddUserOIB.Text);
                string password = txtAddUserPassword.Text;
                string username = txtAddUserUsername.Text;

                Worker newWorker = new Worker
                {
                    WorkerName = name,
                    WorkerSurname = surename,
                    OIB = AddUserOIB,
                };

                LoginInfo newUser = new LoginInfo
                {

                    IDLogin = GenerateUniqueID(),
                    Username = username,
                    Password = password,
                    OIB = AddUserOIB,

                };

                dbContext.Workers.Add(newWorker);
                dbContext.LoginInfos.Add(newUser);
                dbContext.SaveChanges();

                MessageBox.Show("Korisnik dodan.");

                this.Close();
            }
            catch (Exception ex)
            {
                String innerMessage = (ex.InnerException != null)
                      ? ex.InnerException.Message
                      : "";
                MessageBox.Show(innerMessage);
                MessageBox.Show("Greska: " + ex.Message);
            }
        }

        private void txtAddUserPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddUserUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddUserSurename_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddUserOIB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
