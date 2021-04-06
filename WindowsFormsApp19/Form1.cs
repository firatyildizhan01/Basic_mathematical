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

        private double küp(double s1)
        {
            s1 = Convert.ToInt32(textBox1.Text);
            double s5 = Math.Pow(s1, 3);
            return s5;
        }
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
            int q1 = Convert.ToInt32(textBox1.Text);
            int q2 = Convert.ToInt32(textBox2.Text);
            int q3 = Convert.ToInt32(textBox3.Text);

            label1.Text = TOPLAM(q1, q2, q3).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }
    }
}
