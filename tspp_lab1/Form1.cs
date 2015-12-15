using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tspp_lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, Sh;
            x = Convert.ToDouble(textBox1.Text);
            Sh = (Math.Exp(x) - Math.Exp(x-1)) / 2;
            label1.Text = Sh.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, Sh;
            x = Convert.ToDouble(numericUpDown1.Value);
            Sh = (Math.Exp(x) - Math.Exp(x - 1)) / 2;
            label2.Text = Sh.ToString();
        }
    }
}
