using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum_w4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int i = 0;
        public void Data2()
        {
            tBoxNama2.Text = Form1.Data[i, 0];
            tBoxAlamat2.Text = Form1.Data[i, 1];
            tBoxTelp2.Text = Form1.Data[i, 2];
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Data2();
        }
            
        private void btnNext_Click(object sender, EventArgs e)
        {
            Data2();
            i++;
            if (i > 9)
            {
                MessageBox.Show("Data sudah data terakhir");
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            Data2();
            i--;
            if (i < 0)
            {
                MessageBox.Show("Data sudah data pertama");
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Hide();
            fr1.Show();
        }
    }
}
