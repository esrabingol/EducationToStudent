using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationToStudent
{
    public partial class FrmAritmetikcs : Form
    {
        public FrmAritmetikcs()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int puan = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            int yanıt;
            if (label2.Text == "+")
            {
                yanıt = Convert.ToInt32(label1.Text) + Convert.ToInt32(label3.Text);
                label7.Text = yanıt.ToString();

            }
            if (label2.Text == "-")
            {
                yanıt = Convert.ToInt32(label1.Text) - Convert.ToInt32(label3.Text);
                label7.Text = yanıt.ToString();

            }
            if (label2.Text == "*")
            {
                yanıt = Convert.ToInt32(label1.Text) * Convert.ToInt32(label3.Text);
                label7.Text = yanıt.ToString();

            }
            if (label2.Text == "/")
            {
                yanıt = Convert.ToInt32(label1.Text) / Convert.ToInt32(label3.Text);
                label7.Text = yanıt.ToString();

            }

            if (label7.Text == textBox1.Text)
            {
                label6.Text = "Tebrikler";
                puan = puan + 10;
                label9.Text = puan.ToString();
            }
            else if (label7.Text != textBox1.Text)
            {
                label6.Text = "Tekrar Deneyiniz";
                puan = puan - 10;
                label9.Text = puan.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int a = rastgele.Next(1, 10);
            int b = rastgele.Next(1, 10);
            int c = rastgele.Next(1, 5);

            label1.Text = a.ToString();
            label3.Text = b.ToString();
            
            if ( c ==1)
            {
                label2.Text = "+";
            }
            if (c == 2)
            {
                label2.Text = "-";
            }
            if (c == 3)
            {
                label2.Text = "*";
            }
            if (c == 4)
            {
                label2.Text = "/";
            }




        }
    }
}
