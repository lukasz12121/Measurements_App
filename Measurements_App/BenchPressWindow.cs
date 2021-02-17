using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Measurements_App
{
    public partial class BenchPressWindow : Form
    {
        public BenchPressWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRec_Click(object sender, EventArgs e)
        {
            AddBenchRecord addBenchRecord = new AddBenchRecord();
            addBenchRecord.ShowDialog();

            string query = "SELECT * FROM dbo.BENCH ORDER BY ID_BENCH;";
            dgvBench.DataSource = GetBenchResultList(query);
        }

        private void btnDropRec_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            Int32 selectedCellCount = dgvBench.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (dgvBench.AreAllCellsSelected(true))
                {
                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        if (dgvBench.SelectedCells[i].ColumnIndex.ToString() == "0")
                        {
                            list.Add(dgvBench.SelectedCells[i].Value.ToString());
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < selectedCellCount; i++)
                    {                       
                        if(dgvBench.SelectedCells[i].ColumnIndex.ToString() == "0")
                        {
                            list.Add(dgvBench.SelectedCells[i].Value.ToString());
                        }
                    }
                }
            }
            string query = "DELETE FROM BENCH WHERE ID_BENCH = @ID;";
            for (int i = 0; i<list.Count; i++)
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

            string query2 = "SELECT * FROM dbo.BENCH ORDER BY ID_BENCH;";
            dgvBench.DataSource = GetBenchResultList(query2);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            string query = "SELECT * FROM dbo.BENCH  where data_treningu between @StartDate and @EndDate ORDER BY ID_BENCH;";
            dgvBench.DataSource = GetBenchResultList(query);

        }

        private void BenchPressWindow_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.BENCH ORDER BY ID_BENCH;";
            dgvBench.DataSource = GetBenchResultList(query);

            List<string> list = new List<string>();
            string query2 = "SELECT TOP 1 * FROM dbo.BENCH ORDER BY Ciezar DESC;";
            list = GetData(query2);
            string date = list[0].Substring(0,10);
            lDate.Text = "Data: " + date;
            lWeight.Text = "Ciężar: " + list[1]+"kg";
            lRepCount.Text = "Ilość powtórzeń: " + list[2];
        }


        public DataTable GetBenchResultList(String query)
        {
            DataTable benchPressResults = new DataTable();


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
                        benchPressResults.Load(reader);
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

            return benchPressResults;
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
                            list.Add(reader["Data_treningu"].ToString());
                            list.Add(reader["Ciezar"].ToString());
                            list.Add(reader["Powtorzenia"].ToString());
                        }
                    }
                    catch
                    {
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

        private void btnChart_Click(object sender, EventArgs e)
        {
            BenchChartForm benchChartForm = new BenchChartForm();
            benchChartForm.ShowDialog();
        }
    }
}
