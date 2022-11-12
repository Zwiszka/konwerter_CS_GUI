using System;


namespace konwerter
{
    public partial class Form1
    {
        void zamianaDlugosci()
        {
            var x = int.Parse(textBox1.Text);
            float y = 0;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            label5.Text = "" + x;
                            break;
                        case 1:
                            y = x * 1000;
                            label5.Text = "" + y;
                            break;
                        case 2:
                            y = (float)x * 100000;
                            label5.Text = "" + y;
                            break;
                    }
                    break;
                case 1:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            y = (float)x / 1000;
                            label5.Text = "" + y;
                            break;
                        case 1:
                            label5.Text = "" + x;
                            break;
                        case 2:
                            y = x * 100;
                            label5.Text = "" + y;
                            break;
                    }
                    break;
                case 2:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            y = (float)x / 100000;
                            label5.Text = "" + y;
                            break;
                        case 1:
                            y = (float)x / 100;
                            label5.Text = "" + y;
                            break;
                        case 2:
                            label5.Text = "" + x;
                            break;
                    }
                    break;
            }
        }
        void zamianaMasy()
        {
            var x = int.Parse(textBox1.Text);
            float y = 0;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            label5.Text = "" + x;
                            break;
                        case 1:
                            y = x * 1000;
                            label5.Text = "" + y;
                            break;
                        case 2:
                            y = (float)x * 100000;
                            label5.Text = "" + y;
                            break;
                    }
                    break;
                case 1:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            y = (float)x / 1000;
                            label5.Text = "" + y;
                            break;
                        case 1:
                            label5.Text = "" + x;
                            break;
                        case 2:
                            y = x * 1000;
                            label5.Text = "" + y;
                            break;
                    }
                    break;
                case 2:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            y = (float)x / 1000000;
                            label5.Text = "" + y;
                            break;
                        case 1:
                            y = (float)x / 1000;
                            label5.Text = "" + y;
                            break;
                        case 2:
                            label5.Text = "" + x;
                            break;
                    }
                    break;
            }
        }
        void zamianaCzasu()
        {
            var x = int.Parse(textBox1.Text);
            float y = 0;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            label5.Text = "" + x;
                            break;
                        case 1:
                            y = x * 60;
                            label5.Text = "" + y;
                            break;
                        case 2:
                            y = (float)x * 3600;
                            label5.Text = "" + y;
                            break;
                    }
                    break;
                case 1:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            y = (float)x / 60;
                            label5.Text = "" + y;
                            break;
                        case 1:
                            label5.Text = "" + x;
                            break;
                        case 2:
                            y = x * 60;
                            label5.Text = "" + y;
                            break;
                    }
                    break;
                case 2:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            y = (float)x / 3600;
                            label5.Text = "" + y;
                            break;
                        case 1:
                            y = (float)x / 60;
                            label5.Text = "" + y;
                            break;
                        case 2:
                            label5.Text = "" + x;
                            break;
                    }
                    break;
            }
        }


    }
}
    
