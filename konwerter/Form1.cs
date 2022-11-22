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
            

            if (dlugoscButton.Checked)
                zamianaDlugosci();
            else if (masaButton.Checked)
                zamianaMasy();
            else
                zamianaCzasu();
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

        private void dlugoscButton_CheckedChanged(object sender, EventArgs e)
        {
            czyszczenie();
            string[] dlugosctab = { "kilometr", "metr", "centymetr" };
            for (int i = 0; i < dlugosctab.Length; i++)
            {
                comboBox1.Items.Add(dlugosctab[i]);
                comboBox2.Items.Add(dlugosctab[i]);
            }
        }

        private void masaButton_CheckedChanged(object sender, EventArgs e)
        {
            czyszczenie();
            string[] masatab = { "kilogram", "gram", "miligram" };
            for (int i = 0; i < masatab.Length; i++)
            {
                comboBox1.Items.Add(masatab[i]);
                comboBox2.Items.Add(masatab[i]);
            }
        }

        private void czasButton_CheckedChanged(object sender, EventArgs e)
        {
            czyszczenie();
            string[] czastab = { "godzina", "minuta", "sekunda" };
            for (int i = 0; i < czastab.Length; i++)
            {
                comboBox1.Items.Add(czastab[i]);
                comboBox2.Items.Add(czastab[i]);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        void czyszczenie()
        {
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            wynik.ResetText();
        }
    }
}
