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
    public partial class MeasurementChartWindow : Form
    {
        public MeasurementChartWindow()
        {
            InitializeComponent();
        }

        private void MeasurementChartWindow_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.POMIARY ORDER BY ID_Pomiaru;";

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
                            chartMeasurement.ChartAreas[0].AxisX.Interval = 20;
                            chartMeasurement.Series["Pomiar klatki"].Points.AddXY(reader["Data_pomiaru"], reader["pomiar_klatki"]);
                            chartMeasurement.Series["Pomiar bicepsu"].Points.AddXY(reader["Data_pomiaru"], reader["pomiar_bicepsu"]);
                            chartMeasurement.Series["Pomiar brzucha"].Points.AddXY(reader["Data_pomiaru"], reader["pomiar_brzucha"]);
                            chartMeasurement.Series["Pomiar uda"].Points.AddXY(reader["Data_pomiaru"], reader["pomiar_uda"]);
                            chartMeasurement.Series["Pomiar łydki"].Points.AddXY(reader["Data_pomiaru"], reader["pomiar_lydki"]);
                            chartMeasurement.Series["Waga ciała"].Points.AddXY(reader["Data_pomiaru"], reader["waga"]);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
