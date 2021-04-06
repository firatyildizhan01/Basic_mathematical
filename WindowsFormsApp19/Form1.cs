using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        int s1;
        int s2;
        int s3;
        public int TOPLAM(int s1,int s2,int s3)
        {
            int s4 = s1 + s2 + s3;
            return s4;
        }

        private int çarpım(int s1, int s2,int s3)
        {
            int a4 = s1*s2*s3;
            return a4;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = TOPLAM(10, 20,45).ToString();
            label2.Text = çarpım(14, 12, 17).ToString();
        }
    }
}
