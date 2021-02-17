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

            string query = "SELECT * FROM dbo.POMIARY ORDER BY ID_Pomiaru;";
            dgvMeasurement.DataSource = GetMeasurementResultList(query);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.POMIARY  where data_pomiaru between @StartDate and @EndDate ORDER BY ID_Pomiaru;";
            dgvMeasurement.DataSource = GetMeasurementResultList(query);
        }

        private void MeasurementsWindow_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.POMIARY ORDER BY ID_Pomiaru;";
            dgvMeasurement.DataSource = GetMeasurementResultList(query);

            List<string> list = new List<string>();
            string query2 = "SELECT TOP 1 * FROM dbo.POMIARY ORDER BY Data_pomiaru DESC;";

            list = GetData(query2);
            string date = list[0].Substring(0, 10);
            lDate.Text = "Data: " + date;
            lWeight.Text = "Waga: " + list[1] + "kg";
            lHeight.Text = "Wzrost: " + list[2] + "cm";
            lChest.Text = "Wymiary klatki: " + list[3] + "cm";
            lBiceps.Text = "Wymiary bicepsu: " + list[4] + "cm";
            lStomach.Text = "Wymiary brzucha: " + list[5] + "cm";
            lThigh.Text = "Wymiary uda: " + list[6] + "cm";
            lCalf.Text = "Wymiary łydki: " + list[4] + "cm";
        }

        private DataTable GetMeasurementResultList(String query)
        {
            DataTable measurementResults = new DataTable();
           
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    sqlCommand.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = dtpStartDate.Value.Date;
                    sqlCommand.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = dtpEndDate.Value.Date;
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        measurementResults.Load(reader);
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

            return measurementResults;
        }

        public List<string> GetData(string query)
        {
            List<string> list = new List<string>();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        if (reader.Read())
                        {
                            list.Add(reader["Data_pomiaru"].ToString());
                            list.Add(reader["waga"].ToString());
                            list.Add(reader["wzrost"].ToString());
                            list.Add(reader["pomiar_klatki"].ToString());
                            list.Add(reader["pomiar_bicepsu"].ToString());
                            list.Add(reader["pomiar_brzucha"].ToString());
                            list.Add(reader["pomiar_uda"].ToString());
                            list.Add(reader["pomiar_lydki"].ToString());
                        }
                    }
                    catch
                    {
                        list.Add("0");
                        list.Add("0");
                        list.Add("0");
                        list.Add("0");
                        list.Add("0");
                        list.Add("0");
                        list.Add("0");
                        list.Add("0");
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
            return list;
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {

            List<string> list = new List<string>();
            string query = "SELECT TOP 1 * FROM dbo.POMIARY ORDER BY Data_pomiaru DESC;";
            list = GetData(query);

            float bmi;
            float weight = float.Parse(list[1]);
            float height = int.Parse(list[2]);
            bmi = (float)(weight / (Math.Pow((height/100),2)));
            MessageBox.Show("Twoje BMI wynosi: " + bmi);
        }

        private void btnDropMeasure_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            Int32 selectedCellCount = dgvMeasurement.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (dgvMeasurement.AreAllCellsSelected(true))
                {
                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        if (dgvMeasurement.SelectedCells[i].ColumnIndex.ToString() == "0")
                        {
                            list.Add(dgvMeasurement.SelectedCells[i].Value.ToString());
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        if (dgvMeasurement.SelectedCells[i].ColumnIndex.ToString() == "0")
                        {
                            list.Add(dgvMeasurement.SelectedCells[i].Value.ToString());
                        }
                    }
                }
            }
            string query = "DELETE FROM POMIARY WHERE ID_Pomiaru = @ID;";
            for (int i = 0; i < list.Count; i++)
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4)).Value = list[i];

                        try
                        {
                            connection.Open();
                            sqlCommand.ExecuteNonQuery();
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

            string query2 = "SELECT * FROM dbo.POMIARY ORDER BY ID_Pomiaru;";
            dgvMeasurement.DataSource = GetMeasurementResultList(query2);
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            MeasurementChartWindow measurementChartWindow = new MeasurementChartWindow();
            measurementChartWindow.ShowDialog();
        }
    }
}
