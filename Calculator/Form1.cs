using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emotion.Machine;
namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double X = Convert.ToDouble(x.Text);
            fx.Text = Activation.output(X).ToString();
            fy.Text = Math.Round(Activation.derivative(X),2).ToString();

        }
    }
}
