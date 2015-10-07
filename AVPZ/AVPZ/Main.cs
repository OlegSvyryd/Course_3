using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AVPZ
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void demo(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            demo(new Lab1_view());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            demo(new Lab2_view());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            demo(new Lab3_view());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            demo(new Lab4_view());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            demo(new Lab5_view());
        }
    }
}
