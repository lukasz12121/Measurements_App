using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Measurements_App
{
    public partial class AddBenchRecord : Form
    {
        public static int lastBenchID;
        public AddBenchRecord()
        {
            InitializeComponent();
        }

        private bool isDataValid()
        {
            if(numWeight.Value == 0)
            {
                return false;
            }else if (numRepCount.Value == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                string query1 = "SELECT TOP 1 ID_BENCH FROM dbo.BENCH ORDER BY ID_BENCH DESC;";

                using (SqlConnection connection1 = new SqlConnection(Properties.Settings.Default.connString))
                {
                    using (SqlCommand sqlCommand1 = new SqlCommand(query1, connection1))
                    {
                        try
                        {
                            connection1.Open();
                            lastBenchID = (int)sqlCommand1.ExecuteScalar();
                        }
                        catch
                        {
                            lastBenchID = 0;
                        }
                        finally
                        {
                            connection1.Close();
                        }

                    }
                }

                string query2 = "INSERT INTO dbo.BENCH (ID_BENCH,Data_treningu, Ciezar, Powtorzenia) " +
                      "VALUES (@ID_BENCH , @Data_Treningu, @Ciezar, @Powtorzenia)";

                using (SqlConnection connection2 = new SqlConnection(Properties.Settings.Default.connString))
                {
                    using (SqlCommand sqlCommand2 = new SqlCommand(query2, connection2))
                    {

                        sqlCommand2.Parameters.Add(new SqlParameter("@Data_Treningu", SqlDbType.DateTime, 8));
                        sqlCommand2.Parameters["@Data_Treningu"].Value = dtpTrainingDate.Value;

                        sqlCommand2.Parameters.Add(new SqlParameter("@Ciezar", SqlDbType.Decimal, 9));
                        sqlCommand2.Parameters["@Ciezar"].Value = numWeight.Value;

                        sqlCommand2.Parameters.Add(new SqlParameter("@Powtorzenia", SqlDbType.Int, 4));
                        sqlCommand2.Parameters["@Powtorzenia"].Value = numRepCount.Value;

                        sqlCommand2.Parameters.Add(new SqlParameter("@ID_BENCH", SqlDbType.Int, 4)).Value = lastBenchID + 1;

                        try
                        {
                            connection2.Open();
                            sqlCommand2.ExecuteNonQuery();
                            MessageBox.Show("Dodano rekord");
                        }
                        catch
                        {
                            MessageBox.Show("Nie udało się dodać rekordu");
                        }
                        finally
                        {
                            connection2.Close();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola zanim zapiszesz!");
            }
        }
    }
}
