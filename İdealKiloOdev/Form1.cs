using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İdealKiloOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int boy, yas, yil, kilo, cinsiyet, iKilo;
            float kSayi=0;
            double iKiloD;
            boy = Convert.ToInt32(textBox1.Text);
            yil = Convert.ToInt32(textBox2.Text);
            yas = (2022 - (yil + 1));
            cinsiyet = comboBox1.SelectedIndex;
            if (cinsiyet == 0)
            {
                kSayi = 0.8f;
            }
            else if (cinsiyet == 1)
            {
                kSayi = 0.9f;
            }
            kilo = Convert.ToInt32(textBox4.Text);
            iKiloD = (boy - 100 + yas / 10) * kSayi;
            iKilo=(int)iKiloD;
            textBox5.Text = Convert.ToString(iKilo);
            if (kilo == iKilo)
            {
                label6.Text = "Bravo! İdeal kilodasınız";
            }
            else if (kilo < iKilo)
            {
                label6.Text = "Zayıfsınız, kilo almalısınız ";
            }
            else
            {
                label6.Text = "Kilolusunuz, kilo vermelisiniz ";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
