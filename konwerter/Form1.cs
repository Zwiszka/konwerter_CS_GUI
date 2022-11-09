using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace konwerter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox1.Items.Add("kilometr");
            comboBox1.Items.Add("metr");
            comboBox1.Items.Add("centymetr");
            comboBox2.Items.Add("kilometr");
            comboBox2.Items.Add("metr");
            comboBox2.Items.Add("centymetr");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox1.Items.Add("kilogram");
            comboBox1.Items.Add("gram");
            comboBox1.Items.Add("miligram");
            comboBox2.Items.Add("kilogram");
            comboBox2.Items.Add("gram");
            comboBox2.Items.Add("miligram");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox1.Items.Add("godzina");
            comboBox1.Items.Add("minuta");
            comboBox1.Items.Add("sekunda");
            comboBox2.Items.Add("godzina");
            comboBox2.Items.Add("minuta");
            comboBox2.Items.Add("sekunda");
        }
    }
    
}
