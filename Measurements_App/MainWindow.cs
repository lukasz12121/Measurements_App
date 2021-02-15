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
    public partial class Main_window : Form
    {
        public Main_window()
        {
            InitializeComponent();
        }

        private void btnBenchPress_Click(object sender, EventArgs e)
        {
            BenchPressWindow bench_Press_Window = new BenchPressWindow();
            bench_Press_Window.ShowDialog();
        }

        private void btnSquat_Click(object sender, EventArgs e)
        {
            SquatWindow squat_Window = new SquatWindow();
            squat_Window.ShowDialog();
        }

        private void btnDeadLift_Click(object sender, EventArgs e)
        {
            DeadLiftWindow dead_Lift_Window = new DeadLiftWindow();
            dead_Lift_Window.ShowDialog();
        }

        private void btnMeasurements_Click(object sender, EventArgs e)
        {
            MeasurementsWindow measurements_Window = new MeasurementsWindow();
            measurements_Window.ShowDialog();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
