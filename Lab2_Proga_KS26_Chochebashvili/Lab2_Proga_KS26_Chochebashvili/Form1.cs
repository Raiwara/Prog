using System;
using System.IO;
using System.Windows.Forms;

namespace Lab2_Proga_KS26_Chochebashvili
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            string path = @"C:\Users\choch\source\repos\Lab2_Proga_KS26_Chochebashvili\Lab2_Proga_KS26_Chochebashvili\Form1.cs";
            dataGridView1.Rows.Add(2);
            string dt = File.GetLastWriteTime(path).ToString();
            label1.Text = dt;
            string strVersion = Application.ProductVersion.ToString();
            label2.Text = strVersion;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            double y = 0.5;
            string C1 = "CO";
            string C2 = "CO2";
            double w1 = 0.049;
            double w2 = 0.225;
            dataGridView1.Rows[0].Cells[0].Value = (C1, C2);
            dataGridView1.Rows[0].Cells[1].Value = Z(w1, w2, y);
            textBox1.Text = ("Z = ", Z(w1, w2, y)).ToString();
        }
         
        public void button3_Click(object sender, EventArgs e)
        {
            double y = 0.5;
            string C1 = "CO2";
            string C2 = "CH4";
            double w1 = 0.225;
            double w2 = 0.008;
            dataGridView1.Rows[2].Cells[0].Value = (C1, C2);
            dataGridView1.Rows[2].Cells[1].Value = Z(w1, w2, y);
            textBox1.Text = ("Z = ", Z(w1, w2, y)).ToString();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            double y = 0.5;
            string C1 = "CO";
            string C2 = "CH4";
            double w1 = 0.049;
            double w2 = 0.008;

            dataGridView1.Rows[1].Cells[0].Value = (C1, C2);
            dataGridView1.Rows[1].Cells[1].Value = Z(w1, w2, y);
            textBox1.Text = ("Z = ", Z(w1, w2, y)).ToString();
        }

        public static double Z(double w1, double w2, double y)
        {
            double Z = Math.Round((0.291 - 0.08 * ((w1 * y) + (w2 * y))),6);

            return Z;
        }
    }
}