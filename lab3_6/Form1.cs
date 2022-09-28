using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double func (double x)
        {
           return 2 * Math.Sqrt(x) - x - 0.5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = Convert.ToInt32(numericUpDown1.Value); i <= Convert.ToInt32(numericUpDown2.Value); i++)
            {
                sum = sum + func(i);
            }
            textBox1.Text = String.Format("{0:f5}", sum);
        }
    }
}
