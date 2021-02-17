using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Measurements_App
{
    public partial class DeadLiftChartWindow : Form
    {
        public DeadLiftChartWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeadLiftChartWindow_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.DEAD_LIFT ORDER BY ID_DEAD_LIFT;";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            chartDeadLift.ChartAreas[0].AxisX.Interval = 20;
                            chartDeadLift.Series["Obciążenie"].Points.AddXY(reader["Data_treningu"], reader["Ciezar"]);
                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }

        }
    }
}
