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
    public partial class AllData : Form
    {
        public static string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PritamGhosh\Documents\Visual Studio 2012\Projects\Swine Pro New\Swine Pro\dbSwinePro.mdf;Integrated Security=True;Connect Timeout=30";
        public AllData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from GeneralFeatures where Id_no = @Id_no and Sex= @Sex", con);
            cmd.Parameters.Add("@Id_no", SqlDbType.VarChar).Value = textBox1.Text.ToUpper();
            cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = textBox2.Text.ToUpper();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from IndividualLitter where Idno = @Idno and Sex= @Sex", con);
            cmd.Parameters.Add("@Idno", SqlDbType.VarChar).Value = textBox1.Text.ToUpper();
            cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = textBox2.Text.ToUpper();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from LifetimeLitter where Idno = @Idno and Sex= @Sex", con);
            cmd.Parameters.Add("@Idno", SqlDbType.VarChar).Value = textBox1.Text.ToUpper();
            cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = textBox2.Text.ToUpper();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from NutritionFeeding where Idno = @Idno and Sex= @Sex", con);
            cmd.Parameters.Add("@Idno", SqlDbType.VarChar).Value = textBox1.Text.ToUpper();
            cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = textBox2.Text.ToUpper();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from QualificationBoar where Idno = @Idno and Sex= @Sex", con);
            cmd.Parameters.Add("@Idno", SqlDbType.VarChar).Value = textBox1.Text.ToUpper();
            cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = textBox2.Text.ToUpper();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Vaccination where Idno = @Idno and Sex= @Sex", con);
            cmd.Parameters.Add("@Idno", SqlDbType.VarChar).Value = textBox1.Text.ToUpper();
            cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = textBox2.Text.ToUpper();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from VeterinaryExamination where Idno = @Idno and Sex= @Sex", con);
            cmd.Parameters.Add("@Idno", SqlDbType.VarChar).Value = textBox1.Text.ToUpper();
            cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = textBox2.Text.ToUpper();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
