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
    public partial class Lab11_view : Form
    {
        public Lab11_view()
        {
            InitializeComponent();
        }

        private const int X = 5;
        private const int Y0 = 2;

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Lab11_view_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Корінь рівняння: " + getResult(getY(X));
        }

        private float getY(int x)
        {
            return (float)(pow(sqrt(x), 3) + ( (pow(sqrt(x + 2), 3)) / (1 - pow(sqrt(x - 3), 3)) ));
        }

        private float getResult(float y)
        {
            float yi1 = 0;

            while (true)
            {
                yi1 = (2 * pow(y, 3) + X) / (3 * pow(y, 2));

                if (Math.Abs(yi1 - y) < pow(10.0, -5.0))
                    break;

                y = yi1;
            }
            return y;
        }

        private float sqrt(double arg)
        {
            return (float)Math.Sqrt(arg);
        }

        private float pow(double arg, double power)
        {
            return (float)Math.Pow(arg, power);
        }
    }
}
