using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number;

        private void button1_Click(object sender, EventArgs e)
        {
            
            int inputNum = int.Parse(textBox1.Text);

            if (number==inputNum)
            {
                MessageBox.Show("You found it");
            }
            else if (number>inputNum)
            {
                MessageBox.Show("Bigger");
            }
            else
            {
                MessageBox.Show("Lower");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
           number = rand.Next(0, 10);
        }
    }
}
