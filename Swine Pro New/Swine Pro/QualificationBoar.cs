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
    public partial class QualificationBoar : Form
    {
        public static string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PritamGhosh\Documents\Visual Studio 2012\Projects\Swine Pro New\Swine Pro\dbSwinePro.mdf;Integrated Security=True;Connect Timeout=30";
        public QualificationBoar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DataReport().Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "INSERT INTO QualificationBoar" +
                "(Idno,Sex,Physicalfitness,Dateofonsetoftraining," +
                "Periodoftraining,Trainingscore,Evaluationbasedonseminalcharacteristics," +
                "Suitabilityforinsemination)" +
                "VALUES" +
                "(@Idno,@Sex,@Physicalfitness,@Dateofonsetoftraining," +
                "@Periodoftraining,@Trainingscore,@Evaluationbasedonseminalcharacteristics," +
                "@Suitabilityforinsemination)";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Idno", textBox6.Text.ToUpper());
            command.Parameters.AddWithValue("@Sex", comboBox5.Text);
            command.Parameters.AddWithValue("@Physicalfitness", comboBox1.Text);
            command.Parameters.AddWithValue("@Dateofonsetoftraining", textBox1.Text);
            command.Parameters.AddWithValue("@Periodoftraining", textBox2.Text);
            command.Parameters.AddWithValue("@Trainingscore", comboBox2.Text);
            command.Parameters.AddWithValue("@Evaluationbasedonseminalcharacteristics", comboBox3.Text);
            command.Parameters.AddWithValue("@Suitabilityforinsemination", comboBox4.Text);          

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Success");
            this.Close();
        }
    }
}
