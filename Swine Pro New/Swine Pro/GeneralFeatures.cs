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
    public partial class GeneralFeatures : Form
    {
        public static string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PritamGhosh\Documents\Visual Studio 2012\Projects\Swine Pro New\Swine Pro\dbSwinePro.mdf;Integrated Security=True;Connect Timeout=30";
        public GeneralFeatures()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void form4label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new QualificationBoar().Show();
            this.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "INSERT INTO GeneralFeatures" +
                "(Id_no,Sex,Breed,Date_of_birth,Dam_no," +
                "Sire_no,Grand_sire,Grand_dam," +
                "Co_litter_size_of_birth,Colour_and_making," +
                "Genetic_abnormality_disorder,Date_of_weaning," +
                "Age_at_weaning,Weaning_Weight,Date_of_separation," +
                "Date_of_castration,Date_of_sexual_maturity_puberty," +
                "Weight_at_sexual_maturity,Weight_at_six_months," +
                "Weight_at_eight_months,Conformation_at_eight_months," +
                "Date_of_sale_transfer,Weight_at_sale_transfer,Book_Value," +
                "Amount_realized,Date_of_death,Post_mortem_findings,Cause_of_death)" +
                "VALUES" +
                "(@Id_no,@Sex,@Breed,@Date_of_birth,@Dam_no," +
                "@Sire_no,@Grand_sire,@Grand_dam," +
                "@Co_litter_size_of_birth,@Colour_and_making," +
                "@Genetic_abnormality_disorder,@Date_of_weaning," +
                "@Age_at_weaning,@Weaning_Weight,@Date_of_separation," +
                "@Date_of_castration,@Date_of_sexual_maturity_puberty," +
                "@Weight_at_sexual_maturity,@Weight_at_six_months," +
                "@Weight_at_eight_months,@Conformation_at_eight_months," +
                "@Date_of_sale_transfer,@Weight_at_sale_transfer,@Book_Value," +
                "@Amount_realized,@Date_of_death,@Post_mortem_findings,@Cause_of_death)";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@Id_no", textBox1.Text.ToUpper());
            command.Parameters.AddWithValue("@Sex", comboBox3.Text.ToUpper());
            command.Parameters.AddWithValue("@Breed", textBox2.Text);
            command.Parameters.AddWithValue("@Date_of_birth", textBox3.Text);
            command.Parameters.AddWithValue("@Dam_no", textBox4.Text);
            command.Parameters.AddWithValue("@Sire_no", textBox5.Text);
            command.Parameters.AddWithValue("@Grand_sire", textBox6.Text);
            command.Parameters.AddWithValue("@Grand_dam", textBox7.Text);
            command.Parameters.AddWithValue("@Co_litter_size_of_birth", textBox8.Text);
            command.Parameters.AddWithValue("@Colour_and_making", textBox9.Text);
            command.Parameters.AddWithValue("@Genetic_abnormality_disorder", comboBox1.Text);
            command.Parameters.AddWithValue("@Date_of_weaning", textBox18.Text);
            command.Parameters.AddWithValue("@Age_at_weaning", textBox17.Text);
            command.Parameters.AddWithValue("@Weaning_Weight", textBox16.Text);
            command.Parameters.AddWithValue("@Date_of_separation", textBox15.Text);
            command.Parameters.AddWithValue("@Date_of_castration", textBox14.Text);
            command.Parameters.AddWithValue("@Date_of_sexual_maturity_puberty", textBox13.Text);
            command.Parameters.AddWithValue("@Weight_at_sexual_maturity", textBox12.Text);
            command.Parameters.AddWithValue("@Weight_at_six_months", textBox11.Text);
            command.Parameters.AddWithValue("@Weight_at_eight_months", textBox10.Text);
            command.Parameters.AddWithValue("@Conformation_at_eight_months", comboBox2.Text);
            command.Parameters.AddWithValue("@Date_of_sale_transfer", textBox19.Text);
            command.Parameters.AddWithValue("@Reason_for_sale_transfer", textBox20.Text);
            command.Parameters.AddWithValue("@Weight_at_sale_transfer", textBox21.Text);
            command.Parameters.AddWithValue("@Book_value", textBox25.Text);
            command.Parameters.AddWithValue("@Amount_realized", textBox26.Text);
            command.Parameters.AddWithValue("@Date_of_death", textBox22.Text);
            command.Parameters.AddWithValue("@Post_mortem_findings", textBox23.Text);
            command.Parameters.AddWithValue("@Cause_of_death", textBox24.Text);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Success");
            this.Close();
        }
    }
}
