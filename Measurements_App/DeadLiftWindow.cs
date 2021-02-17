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
    public partial class DeadLiftWindow : Form
    {
        public DeadLiftWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRec_Click(object sender, EventArgs e)
        {
            AddDeadLiftRecord addDeadLiftRecord = new AddDeadLiftRecord();
            addDeadLiftRecord.ShowDialog();

            string query = "SELECT * FROM dbo.DEAD_LIFT ORDER BY ID_DEAD_LIFT;";
            dgvDeadLift.DataSource = GetDeadLiftResultList(query);
        }

        private void btnDropRec_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            Int32 selectedCellCount = dgvDeadLift.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (dgvDeadLift.AreAllCellsSelected(true))
                {
                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        if (dgvDeadLift.SelectedCells[i].ColumnIndex.ToString() == "0")
                        {
                            list.Add(dgvDeadLift.SelectedCells[i].Value.ToString());
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        if (dgvDeadLift.SelectedCells[i].ColumnIndex.ToString() == "0")
                        {
                            list.Add(dgvDeadLift.SelectedCells[i].Value.ToString());
                        }
                    }
                }
            }
            string query = "DELETE FROM DEAD_LIFT WHERE ID_DEAD_LIFT = @ID;";
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
            dgvDeadLift.DataSource = GetDeadLiftResultList(query2);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.DEAD_LIFT where data_treningu between @StartDate and @EndDate ORDER BY ID_DEAD_LIFT;";
            dgvDeadLift.DataSource = GetDeadLiftResultList(query);
        }

        private void DeadLiftWindow_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.DEAD_LIFT ORDER BY ID_DEAD_LIFT;";
            dgvDeadLift.DataSource = GetDeadLiftResultList(query);

            List<string> list = new List<string>();

            string query2 = "SELECT TOP 1 * FROM dbo.DEAD_LIFT ORDER BY Ciezar DESC;";

            BenchPressWindow benchPressWindow = new BenchPressWindow();

            list = benchPressWindow.GetData(query2);
            string date = list[0].Substring(0, 10);
            lDate.Text = "Data: " + date;
            lWeight.Text = "Ciężar: " + list[1] + "kg";
            lRepCount.Text = "Ilość powtórzeń: " + list[2];
        }

        private DataTable GetDeadLiftResultList(String query)
        {
            DataTable deadLiftResults = new DataTable();
            
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
                        deadLiftResults.Load(reader);
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

            return deadLiftResults;
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            DeadLiftChartWindow deadLiftChartWindow = new DeadLiftChartWindow();
            deadLiftChartWindow.ShowDialog();
        }
    }
}
