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

namespace Swine_Pro
{
    public partial class VeterinaryExamination : Form
    {
        public static string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PritamGhosh\Documents\Visual Studio 2012\Projects\Swine Pro New\Swine Pro\dbSwinePro.mdf;Integrated Security=True;Connect Timeout=30";
        public VeterinaryExamination()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO VeterinaryExamination" +
                "(Idno,Sex,Slno,ReasonSymptom,DateofTreatment,Medication,Remarks)" +
                "VALUES" +
                "(@Idno,@Sex,@Slno,@ReasonSymptom,@DateofTreatment,@Medication,@Remarks)";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Idno", textBox6.Text.ToUpper());
            command.Parameters.AddWithValue("@Sex", comboBox3.Text);
            command.Parameters.AddWithValue("@Slno", textBox1.Text);
            command.Parameters.AddWithValue("@ReasonSymptom", textBox2.Text);
            command.Parameters.AddWithValue("@DateofTreatment", textBox3.Text);
            command.Parameters.AddWithValue("@Medication", textBox4.Text);
            command.Parameters.AddWithValue("@Remarks", textBox5.Text);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Success");
            this.Close();

        }
    }
}
