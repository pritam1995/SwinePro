using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swine_Pro
{
    public partial class Options_Menu : Form
    {
        public Options_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GeneralFeatures().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new IndividualLitter().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new LifetimeLitter().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new NutritionFeeding().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new QualificationBoar().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Vaccination().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new VeterinaryExamination().Show();
        }
    }
}
