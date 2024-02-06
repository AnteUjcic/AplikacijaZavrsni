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
    public partial class AdminScreen : Form
    {
        public readonly MechanicContext dbContext;

        public AdminScreen(MechanicContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //brisanje
            RemoveUser removeUser = new RemoveUser(dbContext);
            removeUser.Show();

        }

        private void btnAdminScreenAddUser_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser(dbContext);
            adduser.Show();
        }

        private void btnAdminScreenUserOverview_Click(object sender, EventArgs e)
        {
            UserOverview userOverview = new UserOverview(dbContext);
            userOverview.Show();
        }
    }
}
