﻿using ServisAplikacija.Data;
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
    public partial class UserOverview : Form
    {
        private readonly MechanicContext dbContext;

        public UserOverview(MechanicContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUserOverviewShow_Click(object sender, EventArgs e)
        {
            var allWorkers = dbContext.Workers.ToList();

            dataGridView1.DataSource = allWorkers;

            dataGridView1.Columns["OIB"].Visible = false;
        }
    }
}