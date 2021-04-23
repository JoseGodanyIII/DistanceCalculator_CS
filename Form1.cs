using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int speed, time;

            while((int.TryParse(txtSpeed.Text,out time)==false)||(int.TryParse(txtTime.Text, out speed) == false))
            {
                MessageBox.Show("Value enterned must be numeric");
                txtSpeed.Text = "0";
                txtTime.Text = "0";
                txtSpeed.Focus();
            }

            int distance = speed * time;
            txtDistance.Text = string.Format("" + distance);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
