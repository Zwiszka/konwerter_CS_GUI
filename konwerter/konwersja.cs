using System;


namespace konwerter
{
    public partial class Form1
    {
        enum Dlugosc { kilometr, metr, centymetr };
        enum Masa { kilogram, gram, miligram };
        enum Czas { godzina, minuta, sekunda };
        
        void zamianaDlugosci()
        {
            float x = float.Parse(textBox1.Text);
            switch (comboBox1.SelectedIndex)
            {
                case (int) Dlugosc.kilometr:
                    x = x * 1000;
                    break;
                case (int)Dlugosc.metr:
                    break;
                case (int)Dlugosc.centymetr:
                    x = x / 100;
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case (int)Dlugosc.kilometr:
                    x = x / 1000;
                    break;
                case (int)Dlugosc.metr:
                    break;
                case (int)Dlugosc.centymetr:
                    x = x * 100;
                    break;
            }
            wynik.Text = x.ToString();
        }
        void zamianaMasy()
        {
            float x = float.Parse(textBox1.Text);
            switch (comboBox1.SelectedIndex)
            {
                case (int)Masa.kilogram:
                    x = x * 1000;
                    break;
                case (int)Masa.gram:
                    break;
                case (int)Masa.miligram:
                    x = x / 1000;
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case (int)Masa.kilogram:
                    x = x / 1000;
                    break;
                case (int)Masa.gram:
                    break;
                case (int)Masa.miligram:
                    x = x * 1000;
                    break;
            }
            wynik.Text = x.ToString();
        }
        void zamianaCzasu()
        {
            float x = float.Parse(textBox1.Text);
            switch (comboBox1.SelectedIndex)
            {
                case (int)Czas.godzina:
                    x = x * 60;
                    break;
                case (int)Czas.minuta:
                    break;
                case (int)Czas.sekunda:
                    x = x / 60;
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case (int)Czas.godzina:
                    x = x / 60;
                    break;
                case (int)Czas.minuta:
                    break;
                case (int)Czas.sekunda:
                    x = x * 60;
                    break;
            }
            wynik.Text = x.ToString();
        }
        
    }
}
    
