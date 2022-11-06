using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
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

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, KetQua;

            if (txtA.Text != String.Empty || txtB.Text != String.Empty)
            {
                a = int.Parse(txtA.Text);
                b = int.Parse(txtB.Text);
                KetQua = a + b;
                txtKetQua.Text = KetQua.ToString(); 
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a, b, KetQua;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            KetQua = a - b;
            txtKetQua.Text = KetQua.ToString();
        }
    }
}
