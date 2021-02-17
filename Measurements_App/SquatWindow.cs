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

            string query = "SELECT * FROM dbo.SQUAT ORDER BY ID_SQUAT;";
            dgvSquat.DataSource = GetSquatResultList(query);
        }

        private void btnDropRec_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            Int32 selectedCellCount = dgvSquat.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (dgvSquat.AreAllCellsSelected(true))
                {
                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        if (dgvSquat.SelectedCells[i].ColumnIndex.ToString() == "0")
                        {
                            list.Add(dgvSquat.SelectedCells[i].Value.ToString());
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        if (dgvSquat.SelectedCells[i].ColumnIndex.ToString() == "0")
                        {
                            list.Add(dgvSquat.SelectedCells[i].Value.ToString());
                        }
                    }
                }
            }
            string query = "DELETE FROM SQUAT WHERE ID_SQUAT = @ID;";
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

            string query2 = "SELECT * FROM dbo.SQUAT ORDER BY ID_SQUAT;";
            dgvSquat.DataSource = GetSquatResultList(query2);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.SQUAT where data_treningu between @StartDate and @EndDate ORDER BY ID_SQUAT;";
            dgvSquat.DataSource = GetSquatResultList(query);

        }

        private void SquatWindow_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.SQUAT ORDER BY ID_SQUAT;";
            dgvSquat.DataSource = GetSquatResultList(query);

            List<string> list = new List<string>();

            string query2 = "SELECT TOP 1 * FROM dbo.SQUAT ORDER BY Ciezar DESC;";

            BenchPressWindow benchPressWindow = new BenchPressWindow();

            list = benchPressWindow.GetData(query2);
            string date = list[0].Substring(0, 10);
            lDate.Text = "Data: " + date;
            lWeight.Text = "Ciężar: " + list[1] + "kg";
            lRepCount.Text = "Ilość powtórzeń: " + list[2];
        }

        private DataTable GetSquatResultList(String query)
        {
            DataTable squatResults = new DataTable();
            

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
                        squatResults.Load(reader);
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

            return squatResults;
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            SquatChartWindow squatChartWindow = new SquatChartWindow();
            squatChartWindow.ShowDialog();
        }
    }
}
