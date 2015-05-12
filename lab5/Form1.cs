using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            textBox3.Clear();
            textBox4.Clear();
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter input string");
            }
            else
            {
                textBox3.Text = stringControlLibrary1.Head(textBox1.Text, textBox2.Text);
                textBox4.Text = stringControlLibrary1.Tail(textBox1.Text, textBox2.Text);
            }
        }
    }
}
