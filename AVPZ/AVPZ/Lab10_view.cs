using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace AVPZ
{
    public partial class Lab10_view : Form
    {
        public Lab10_view()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            label6.Text = "";
            label7.Text = "";
        }

        private string[] getArray(DataGridView dgv)
        {
            string[] arr = new string[dgv.ColumnCount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = dgv.Rows[0].Cells[i].Value.ToString();
            }
            return arr;
        }

        private float getMaxLength(string[] arrX, string[] arrY, float baseX, float baseY)
        {
            float[] farrX = new float[arrX.Length];
            float[] farrY = new float[arrY.Length];
            float max = int.MinValue;
            bool isFirstInit = false;

            for (int i = 0; i < farrX.Length; i++)
            {
                farrX[i] = float.Parse(arrX[i], CultureInfo.InvariantCulture);
                farrY[i] = float.Parse(arrY[i], CultureInfo.InvariantCulture);
                if (!isFirstInit)
                {
                    max = sqrt(pow(farrX[i] - farrY[i], 2) + pow(baseX - baseY, 2));
                    isFirstInit = true;
                }
                if (max < sqrt(pow(farrX[i] - farrY[i], 2) + pow(baseX - baseY, 2)))
                {
                    max = sqrt(pow(farrX[i] - farrY[i], 2) + pow(baseX - baseY, 2));
                }
            }
            return max;
        }

        private float getSum(string[] arrX, string[] arrY, float baseX, float baseY)
        {
            float[] farrX = new float[arrX.Length];
            float[] farrY = new float[arrY.Length];
            float sum = 0;
            

            for (int i = 0; i < farrX.Length; i++)
            {
                farrX[i] = float.Parse(arrX[i], CultureInfo.InvariantCulture);
                farrY[i] = float.Parse(arrY[i], CultureInfo.InvariantCulture);
                sum += sqrt(pow(farrX[i] - farrY[i], 2) + pow(baseX - baseY, 2));
            }
            return sum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label6.Text += " " + getSum(getArray(dataGridView1), getArray(dataGridView2), float.Parse(textBox1.Text, CultureInfo.InvariantCulture), float.Parse(textBox2.Text, CultureInfo.InvariantCulture));
                label7.Text += " " + getMaxLength(getArray(dataGridView1), getArray(dataGridView2), float.Parse(textBox1.Text, CultureInfo.InvariantCulture), float.Parse(textBox2.Text, CultureInfo.InvariantCulture));
            }
            catch (NullReferenceException e1) { MessageBox.Show("Помилка, заповніть всі клітинки."); }
            catch (FormatException e1) { MessageBox.Show("Помилка, введіть числові дані."); }
            catch (Exception e1) { MessageBox.Show("Помилка: " + e1.Message); }
        }

        private void Lab10_view_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Dispose();
        }

        private float sqrt(double arg)
        {
            return (float)Math.Sqrt(arg);
        }

        private float pow(double arg, double power)
        {
            return (float)Math.Pow(arg, power);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '.');
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '.');
        }
    }
}
