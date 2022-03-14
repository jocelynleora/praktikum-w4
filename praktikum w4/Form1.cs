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
    public partial class Form1 : Form
    {
        public static string[,] Data = new string[10,3];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Form2 fr2 = new Form2();

        public void btnSimpan_Click(object sender, EventArgs e)
        {
            Data[i, 0] = tBoxNama.Text;
            Data[i ,1] = tBoxAlamat.Text;
            Data[i, 2] = tBoxTelp.Text;
            i++;
            if(i > 10)
            {
                MessageBox.Show("Data telah penuh!");
            }
        }

        public static string SetValueFortboxNama = "";
        public static string SetValueFortboxAlamat = "";
        public static string SetValueFortboxTelp = "";

        private  void btnLihat_Click(object sender, EventArgs e)
        {
           
                SetValueFortboxNama = tBoxNama.Text;
                SetValueFortboxAlamat = tBoxAlamat.Text;
                SetValueFortboxTelp = tBoxTelp.Text;
                this.Hide();
                fr2.ShowDialog();            
        }

        private void tBoxAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxTelp_TextChanged(object sender, EventArgs e)
        {
                if (System.Text.RegularExpressions.Regex.IsMatch(tBoxTelp.Text, "  ^ [0-9]"))
                {
                    tBoxTelp.Text = "";
                }
        }

        private void tBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAlamat_Click(object sender, EventArgs e)
        {

        }

        private void lblTelp_Click(object sender, EventArgs e)
        {

        }
    }
}