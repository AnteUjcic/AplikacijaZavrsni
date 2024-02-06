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
    public partial class PocetnaForma : Form
    {
        private readonly MechanicContext dbContext;

        public PocetnaForma(MechanicContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Upis novog vozla
            UpisNovogVozila upis = new UpisNovogVozila(dbContext);
            upis.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Brisanje vozila
            BrisanjeVozila brisanje = new BrisanjeVozila(dbContext);
            brisanje.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Upis servisa vozila
            UpisServisaVozila serivs = new UpisServisaVozila(dbContext);
            serivs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Pregled vozila
            PregledVozila pregled = new PregledVozila(dbContext);
            pregled.Show();

        }

        private void btnPocetnaFormaPregledServisa_Click(object sender, EventArgs e)
        {
            PregledServisa pregled = new PregledServisa(dbContext);

            pregled.Show();


        }
    }
}
