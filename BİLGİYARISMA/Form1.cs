using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BİLGİYARISMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        int soruno = 0, dogru = 0, yanlis = 0;

   
        string basarili;

        private void button1_Click(object sender, EventArgs e)
        {
            if (soruno > 2) { button5.Text = "SONUÇLAR"; }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            // basarili = button1.Text;
            if (button1.Text == basarili)
            {
                dogru++;
                labeldogru.Text = Convert.ToString(dogru);
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelyanlis.Text = Convert.ToString(yanlis);
                pictureBox2.Visible = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (soruno > 2) { button5.Text = "SONUÇLAR"; }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            // basarili = button2.Text;

            if (button2.Text == basarili)
            {
                dogru++;
                labeldogru.Text = Convert.ToString(dogru);
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelyanlis.Text = Convert.ToString(yanlis);
                pictureBox2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (soruno > 2) { button5.Text = "SONUÇLAR"; }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            // basarili = button3.Text;

            if (button3.Text == basarili)
            {
                dogru++;
                labeldogru.Text = Convert.ToString(dogru);
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelyanlis.Text = Convert.ToString(yanlis);
                pictureBox2.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (soruno > 2) { button5.Text = "SONUÇLAR"; }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            // basarili = button4.Text;

            if (button4.Text == basarili)
            {
                dogru++;
                labeldogru.Text = Convert.ToString(dogru);
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelyanlis.Text = Convert.ToString(yanlis);
                pictureBox2.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible= false;

   
            soruno++;
            labelsoru.Text = Convert.ToString(soruno);
            if (soruno==1)
            {
                richTextBox1.Text = "3+2 sonucu nedir?";
                button1.Text = "3";
                button2.Text = "4";
                button3.Text = "5";
                button4.Text = "6";
                basarili = "5";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "3+3 sonucu nedir?";
                button1.Text = "3";
                button2.Text = "4";
                button3.Text = "5";
                button4.Text = "6";
                basarili = "6";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "3*1 sonucu nedir?";
                button1.Text = "3";
                button2.Text = "4";
                button3.Text = "5";
                button4.Text = "6";
                basarili = "3";

            }
            if (soruno > 3)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                richTextBox1.Text = " TEST BAŞARIYLA TAMAMLANDI \n DOĞRU SAYISI : " + dogru + "\n" + " YANLIŞ SAYISI : "+ yanlis;

            }






        }

     

    }
}
