﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Measurements_App
{
    public partial class SquatWindow : Form
    {
        public SquatWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRec_Click(object sender, EventArgs e)
        {
            AddSquatRecord addSquatRecord = new AddSquatRecord();
            addSquatRecord.ShowDialog();
        }

        private void btnDropRec_Click(object sender, EventArgs e)
        {

        }
    }
}
