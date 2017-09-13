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
    public partial class IndividualLitter : Form
    {
        public static string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PritamGhosh\Documents\Visual Studio 2012\Projects\Swine Pro New\Swine Pro\dbSwinePro.mdf;Integrated Security=True;Connect Timeout=30";
        public IndividualLitter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO IndividualLitter" +
                "(Idno,Sex,Sl_no,Sowno,Boarno," +
                "Dateofservice,Natureofservice," +
                "Dateoffarrowing,Dateofweaning," +
                "Interfarrowinginterval,Parity," +
                "Bornmale,Bornfemale,Borntotal," +
                "Litterweightatbirth,Weanedmale," +
                "Weanedfemale,Totalweaned," +
                "Weaningweight,Stillbirth,Dateofabortion)" +
                "VALUES" +
                "(@Idno,@Sex,@Sl_no,@Sowno,@Boarno," +
                "@Dateofservice,@Natureofservice," +
                "@Dateoffarrowing,@Dateofweaning," +
                "@Interfarrowinginterval,@Parity," +
                "@Bornmale,@Bornfemale,@Borntotal," +
                "@Litterweightatbirth,@Weanedmale," +
                "@Weanedfemale,@Totalweaned," +
                "@Weaningweight,@Stillbirth,@Dateofabortion)";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Idno", textBox19.Text.ToUpper());
            command.Parameters.AddWithValue("@Sex", comboBox3.Text);
            command.Parameters.AddWithValue("@Sl_no", textBox1.Text);
            command.Parameters.AddWithValue("@Sowno", textBox2.Text);
            command.Parameters.AddWithValue("@Boarno", textBox3.Text);
            command.Parameters.AddWithValue("@Dateofservice", textBox4.Text);
            command.Parameters.AddWithValue("@Natureofservice", textBox5.Text);
            command.Parameters.AddWithValue("@Dateoffarrowing", textBox6.Text);
            command.Parameters.AddWithValue("@Dateofweaning", textBox7.Text);
            command.Parameters.AddWithValue("@Interfarrowinginterval", textBox8.Text);
            command.Parameters.AddWithValue("@Parity", textBox9.Text);
            command.Parameters.AddWithValue("@Bornmale", textBox10.Text);
            command.Parameters.AddWithValue("@Bornfemale", textBox11.Text);
            command.Parameters.AddWithValue("@Borntotal", textBox12.Text);
            command.Parameters.AddWithValue("@Litterweightatbirth", textBox13.Text);
            command.Parameters.AddWithValue("@Weanedmale", textBox14.Text);
            command.Parameters.AddWithValue("@Weanedfemale", textBox15.Text);
            command.Parameters.AddWithValue("@Totalweaned", textBox16.Text);
            command.Parameters.AddWithValue("@Weaningweight", textBox17.Text);
            command.Parameters.AddWithValue("@Stillbirth", textBox20.Text);
            command.Parameters.AddWithValue("@Dateofabortion", textBox18.Text);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Success");
            this.Close();

        }
    }
}
