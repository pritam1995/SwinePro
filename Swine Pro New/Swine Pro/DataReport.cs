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
    public partial class DataReport : Form
    {
        public DataReport()
        {
            InitializeComponent();
        }

        private void form2button1_Click(object sender, EventArgs e)
        {
            new EnterUpdate().Show();
            this.Close();
        }

        private void form2button2_Click(object sender, EventArgs e)
        {
            new AllData().Show();
            this.Close();
        }
    }
}
