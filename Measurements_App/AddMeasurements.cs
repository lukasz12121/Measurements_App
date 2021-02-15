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
    public partial class AddMeasurements : Form
    {
        public static int lastMeasurement;

        public AddMeasurements()
        {
            InitializeComponent();
        }
        private bool isDataValid()
        {
            if(numBodyHeight.Value == 0)
            {
                return false;
            }
            else if(numBodyWeight.Value == 0)
            {
                return false;
            }
            else if(numChestMeasure.Value == 0)
            {
                return false;
            }
            else if (numBicepsMeasure.Value == 0)
            {
                return false;
            }
            else if (numStomachMeasure.Value == 0)
            {
                return false;
            }
            else if (numThightMeasure.Value == 0)
            {
                return false;
            }
            else if (numCalfMeasure.Value == 0)
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
                string query1 = "SELECT TOP 1 ID_Pomiaru FROM dbo.POMIARY ORDER BY ID_Pomiaru DESC;";

                using (SqlConnection connection1 = new SqlConnection(Properties.Settings.Default.connString))
                {
                    using (SqlCommand sqlCommand1 = new SqlCommand(query1, connection1))
                    {
                        try
                        {
                            connection1.Open();
                            lastMeasurement = (int)sqlCommand1.ExecuteScalar();
                        }
                        catch
                        {
                            lastMeasurement = 0;
                        }
                        finally
                        {
                            connection1.Close();
                        }
                    }
                }

                string query2 = "INSERT INTO dbo.POMIARY (ID_Pomiaru, Data_pomiaru, pomiar_klatki, pomiar_bicepsu, pomiar_brzucha, pomiar_uda, pomiar_lydki, waga, wzrost) " +
                      "VALUES (@ID_Pomiaru , @Data_pomiaru, @pomiar_klatki, @pomiar_bicepsu, @pomiar_brzucha, @pomiar_uda, @pomiar_lydki, @waga, @wzrost)";

                using (SqlConnection connection2 = new SqlConnection(Properties.Settings.Default.connString))
                {
                    using (SqlCommand sqlCommand2 = new SqlCommand(query2, connection2))
                    {

                        sqlCommand2.Parameters.Add(new SqlParameter("@ID_Pomiaru", SqlDbType.Int, 4)).Value = lastMeasurement + 1;

                        sqlCommand2.Parameters.Add(new SqlParameter("@Data_pomiaru", SqlDbType.DateTime, 8));
                        sqlCommand2.Parameters["@Data_pomiaru"].Value = dtpMeasure.Value;

                        sqlCommand2.Parameters.Add(new SqlParameter("@pomiar_klatki", SqlDbType.Float, 9));
                        sqlCommand2.Parameters["@pomiar_klatki"].Value = numChestMeasure.Value;

                        sqlCommand2.Parameters.Add(new SqlParameter("@pomiar_bicepsu", SqlDbType.Float, 4));
                        sqlCommand2.Parameters["@pomiar_bicepsu"].Value = numBicepsMeasure.Value;

                        sqlCommand2.Parameters.Add(new SqlParameter("@pomiar_brzucha", SqlDbType.Float, 4));
                        sqlCommand2.Parameters["@pomiar_brzucha"].Value = numStomachMeasure.Value;

                        sqlCommand2.Parameters.Add(new SqlParameter("@pomiar_uda", SqlDbType.Float, 4));
                        sqlCommand2.Parameters["@pomiar_uda"].Value = numThightMeasure.Value;

                        sqlCommand2.Parameters.Add(new SqlParameter("@pomiar_lydki", SqlDbType.Float, 4));
                        sqlCommand2.Parameters["@pomiar_lydki"].Value = numCalfMeasure.Value;

                        sqlCommand2.Parameters.Add(new SqlParameter("@waga", SqlDbType.Float, 4));
                        sqlCommand2.Parameters["@waga"].Value = numBodyWeight.Value;

                        sqlCommand2.Parameters.Add(new SqlParameter("@wzrost", SqlDbType.Int, 4));
                        sqlCommand2.Parameters["@wzrost"].Value = numBodyHeight.Value;

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
