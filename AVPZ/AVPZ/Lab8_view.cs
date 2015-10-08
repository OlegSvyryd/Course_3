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
    public partial class Lab8_view : Form
    {
        public Lab8_view()
        {
            InitializeComponent();
        }

        private const float ALPHA = 0.45f;
        private float[] b = { 2.46f, 7.38f, 11.6f };
        private float[] c = { 1.6f, 0.35f, 6.71f, 9.35f };

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text += "b[j] = " + b[0] + ", " + b[1] + ", " + b[2];
                richTextBox1.Text += "\nc[m] = " + c[0] + ", " + c[1] + ", " + c[2] + ", " + c[3];
                richTextBox1.Text += "\n" + getRes1();
                richTextBox1.Text += "\n-----------------------";
                richTextBox1.Text += "\n" + getRes2();
            }
            catch (NullReferenceException e1)
            {
                MessageBox.Show("Помилка: " + e1.Message);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Помилка: " + e1.Message);
            }
        }

        private float getRes1()
        {
            float f = 0;

            for (int j = 0; j < b.Length; j++)
            {
                for (int m = 0; m < c.Length; m++)
                {
                    f = (float)sqrt(b[j] * sqrt(1 + ((c[m] * ALPHA) / (log(b[j])))));
                }
            }
            return f;
        }

        private float getRes2()
        {
            float f = 0;
            int count = 0;

            for (int j = 0; j < b.Length; j++)
            {
                if((count++) == 0)
                {
                    f = (float)sqrt(b[j] * sqrt(1 + ((c[count] * ALPHA) / (log(b[j])))));
                }
                if ((count++) == 1)
                {
                    f = (float)sqrt(b[j] * sqrt(1 + ((c[count] * ALPHA) / (log(b[j])))));
                }
                if ((count++) == 2)
                {
                    f = (float)sqrt(b[j] * sqrt(1 + ((c[count] * ALPHA) / (log(b[j])))));
                }
                if ((count) == 3)
                {
                    f = (float)sqrt(b[j] * sqrt(1 + ((c[count] * ALPHA) / (log(b[j])))));
                    count = 0;
                }
            }
            return f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Lab8_view_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Dispose();
        }

        private double sqrt(double arg)
        {
            return Math.Sqrt(arg);
        }

        private double log(double arg)
        {
            return Math.Log(arg);
        }
    }
}
