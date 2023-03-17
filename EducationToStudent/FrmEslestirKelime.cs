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
    public partial class FrmEslestirKelime : Form
    {
        public FrmEslestirKelime()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "KEDİ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "KÖPEK";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "AT";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "KUŞ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "İNEK";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = "BIRD";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = "CAT";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = "DOG";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = "COW";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = "HORSE";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text == "KEDİ" && label2.Text == "CAT")
            {
                button1.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Green;
                button9.BackColor = Color.Green;

            }
            else if (label1.Text == "KEDİ" && label2.Text != "CAT")
            {
                button1.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Red;
                button9.BackColor = Color.Red;

            }
                if (label1.Text == "KÖPEK" && label2.Text == "DOG")
            {
                button2.Enabled = false;
                button8.Enabled = false;
                button2.BackColor = Color.Green;
                button8.BackColor = Color.Green;
            }
            else if(label1.Text == "KÖPEK" && label2.Text != "DOG")
            {
                button2.Enabled = false;
                button8.Enabled = false;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
          
            if (label1.Text == "AT" && label2.Text == "HORSE")
            {
                button3.Enabled = false;
                button6.Enabled = false;
                button3.BackColor = Color.Green;
                button6.BackColor = Color.Green;
            }
             else if (label1.Text == "AT" && label2.Text != "HORSE")
            {
                button3.Enabled = false;
                button6.Enabled = false;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }


            if (label1.Text == "KUŞ" && label2.Text == "BIRD")
            {
                button4.Enabled = false;
                button10.Enabled = false;
                button4.BackColor = Color.Green;
                button10.BackColor = Color.Green;
            }
            else if (label1.Text == "KUŞ" && label2.Text != "BIRD")
            {
                button4.Enabled = false;
                button10.Enabled = false;
                button4.BackColor = Color.Red;
                button10.BackColor = Color.Red;
            }


            if (label1.Text == "İNEK" && label2.Text == "COW")
            {
                button5.Enabled = false;
                button7.Enabled = false;
                button5.BackColor = Color.Green;
                button7.BackColor = Color.Green;
            }
           else  if (label1.Text == "İNEK" && label2.Text != "COW")
            {
                button5.Enabled = false;
                button7.Enabled = false;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }

        }
    }
}
