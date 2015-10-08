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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = getRes1();
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

        private string getRes1()
        {
            string output = null;
            float[][] fi = new float[3][];
            fi[0] = new float[4];
            fi[1] = new float[4];
            fi[2] = new float[4];
            float[] b = new float[3];
            float[] c = new float[4];

            for (int j = 0; j < 3; j++)
            {
                b[j] = j+1;
            }

            Console.WriteLine();

            for (int m = 0; m < 4; m++)
            {
                c[m] = m+1;
            }

            for (int j = 0; j < 3; j++)
            {
                for (int m = 0; m < 4; m++)
                {
                    fi[j][m] = (float)sqrt(b[j] * sqrt(1 + ((c[m] * ALPHA) / (log(b[j])) )));
                    output += fi[j][m] + " \n";
                }
            }
            return output;
        }

        private string getRes11()
        {
            string output = null;
            float[][] fi = new float[3][];
            fi[0] = new float[4];
            fi[1] = new float[4];
            fi[2] = new float[4];
            float[] b = { 2.46f, 7.38f, 11.6f };
            float[] c = { 1.6f, 0.35f, 6.71f, 9.35f };

            for (int j = 0; j < 3; j++)
            {
                /*
                {
                    fi[j][m] = (float)sqrt(b[j] * sqrt(1 + ((c[m] * ALPHA) / (log(b[j])))));
                    output += fi[j][m] + " \n";
                }
                 */
            }
            return output;
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
