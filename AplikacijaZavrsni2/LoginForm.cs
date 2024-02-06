using AplikacijaZavrsni2.Data;
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
    public partial class LoginForm : Form
    {

        private readonly MechanicContext dbContext;

        public LoginForm()
        {
            InitializeComponent();
            dbContext = new MechanicContext();
        }

        private void txtLoginUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoginPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new MechanicContext())
                {


                    try
                    {
                        dbContext.Database.OpenConnection();

                        Console.WriteLine("Spojen na bazu.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Greska s povezivanjem na bazu: " + ex.Message);
                    }
                    finally
                    {
                        dbContext.Database.CloseConnection();
                    }
                }


                string username = txtLoginUsername.Text;
                string password = txtLoginPassword.Text;

                if (username == "admin" && password == "1234")
                {

                    AdminScreen adminmode = new Data.AdminScreen(dbContext);

                    adminmode.Show();


                }
                else if (username == "admin")
                {
                    MessageBox.Show("Kriva sifra admina.");
                }
                else
                {
                    var user = dbContext.LoginInfos.FirstOrDefault(li => li.Username == username && li.Password == password);

                    if (user != null)
                    {


                        PocetnaForma userDashboard = new PocetnaForma(dbContext);
                        userDashboard.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kriva šifra ili korisnik.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
