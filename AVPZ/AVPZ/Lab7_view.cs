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
    public partial class Lab7_view : Form
    {
        public Lab7_view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label5.Text = "" + getSum(getArray(dataGridView1), float.Parse(textBox1.Text, CultureInfo.InvariantCulture));
            }
            catch (NullReferenceException e1) { MessageBox.Show("Помилка, заповніть всі клітинки."); }
            catch (FormatException e1) { MessageBox.Show("Помилка, введіть числові дані."); }
            catch (Exception e1) { MessageBox.Show("Помилка: " + e1.Message); }
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

        private float getSum(string[] arr, float a)
        {
            float[] farr = new float[arr.Length];
            float sum = 0;

            for (int i = 0; i < farr.Length; i++)
            {
                farr[i] = float.Parse(arr[i], CultureInfo.InvariantCulture);
                if ((farr[i] < 0) && (Math.Abs(farr[i]) > a))
                {
                    sum += Math.Abs(farr[i]);
                    Console.WriteLine("here: " + sum);
                }
            }
            return sum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataGridView1.Rows.Clear();
            label5.Text = "";
        }

        private void Lab7_view_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Dispose();
        }
    }
}
