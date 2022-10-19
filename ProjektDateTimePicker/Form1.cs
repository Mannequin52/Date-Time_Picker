using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektDateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            DateTime dt1 = button1.Value;

            StringBuilder sb1 = new StringBuilder();

            sb1.Append("Vas datum leta je:\n");

            sb1.Append(dt1.ToShortDateString() + "\n");

            DateTime dt2 = button1.Value;

            sb1.Append("Vase vrijeme polaska je:\n");

            sb1.Append(dt2.ToShortTimeString());

            richTextBox1.AppendText(sb1.ToString());
        }
    }
}
