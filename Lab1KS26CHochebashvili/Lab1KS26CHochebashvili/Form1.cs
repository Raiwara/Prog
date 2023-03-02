using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1KS26CHochebashvili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked = true)
            {
                BackgroundImage = Lab1KS26CHochebashvili.Properties.Resources.Image1;
            }
            else
            {
                BackgroundImage = null;
            }
        }

        private void checkBox1_MouseEnter(object sender, EventArgs e)
        {
            flowLayoutPanel1.BackgroundImage = Lab1KS26CHochebashvili.Properties.Resources.Безымянный;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
            flowLayoutPanel1.BackgroundImage = null;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
    public class abc
    {

        public byte var = 9;
        public const long X = 45;
        public string[] array13 = { "PROGA", "MY", "LUYBIMIY", "LESSON" };
        public enum Numbers : int
        {
            a=1,
            b=2,
            c=3

        }


    }
}
