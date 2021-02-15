using System;
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
    public partial class MeasurementsWindow : Form
    {
        public MeasurementsWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddMeasure_Click(object sender, EventArgs e)
        {
            AddMeasurements addMeasurements = new AddMeasurements();
            addMeasurements.ShowDialog();
        }
    }
}
