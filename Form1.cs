using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceiling_Fan
{
    public partial class Form1 : Form
    {
        CeilingFan currentFan;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentFan = new CeilingFan();
            lblSpeedOutput.Text = string.Format(currentFan.GetSpeed().ToString());
            lblDirectionOutput.Text = string.Format(currentFan.GetDirection());
        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {
            lblSpeedOutput.Text = string.Format(currentFan.IncreaseSpeed().ToString());
        }

        private void btnDirection_Click(object sender, EventArgs e)
        {
            lblDirectionOutput.Text = string.Format(currentFan.ChangeDirection());
        }
    }
}
