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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmAritmetikcs islemformu = new FrmAritmetikcs();
            islemformu.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmResimlerSesler form2 = new FrmResimlerSesler();
            form2.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmEslestirKelime formkelimeeslestir = new FrmEslestirKelime();
            formkelimeeslestir.Show();
        }
    }
}
