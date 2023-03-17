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
    public partial class FrmResimlerSesler : Form
    {
        public FrmResimlerSesler()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("KÖPEK");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KOYUN");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KEDİ");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İNEK");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOROZ");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ÖRDEK");
        }
    }
}
