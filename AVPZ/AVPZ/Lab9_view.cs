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
    public partial class Lab9_view : Form
    {
        public Lab9_view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generateRndNumbers();
        }

        private void generateRndNumbers()
        {
            dataGridView1.Rows.Add(new string[] { "" + new Random().Next(115), "" + new Random().Next(15), "" + new Random().Next(155), "" + new Random().Next(465), "" + new Random().Next(33), "" + new Random().Next(111) });
            dataGridView1.Rows.Add(new string[] { "" + new Random().Next(5), "" + new Random().Next(52), "" + new Random().Next(14), "" + new Random().Next(2423), "" + new Random().Next(34), "" + new Random().Next(112) });
            dataGridView1.Rows.Add(new string[] { "" + new Random().Next(25), "" + new Random().Next(35), "" + new Random().Next(1422), "" + new Random().Next(123), "" + new Random().Next(35), "" + new Random().Next(174) });
            dataGridView1.Rows.Add(new string[] { "" + new Random().Next(54), "" + new Random().Next(78), "" + new Random().Next(11), "" + new Random().Next(2345), "" + new Random().Next(399), "" + new Random().Next(183) });
            dataGridView1.Rows.Add(new string[] { "" + new Random().Next(43), "" + new Random().Next(678), "" + new Random().Next(167), "" + new Random().Next(21), "" + new Random().Next(3111), "" + new Random().Next(181) });
            dataGridView1.Rows.Add(new string[] { "" + new Random().Next(82), "" + new Random().Next(56), "" + new Random().Next(164), "" + new Random().Next(21), "" + new Random().Next(3565), "" + new Random().Next(18) });
            dataGridView1.Rows.Add(new string[] { "" + new Random().Next(51), "" + new Random().Next(45), "" + new Random().Next(97), "" + new Random().Next(22), "" + new Random().Next(3243), "" + new Random().Next(156) });

            double[][] arr = convertStringArrayToDouble(getArray(dataGridView1));

            double[] maxes = getMax(arr);
            double[] mins = getMin(arr);

            dataGridView2.Rows.Add(new string[] { maxes[0] + "", maxes[1] + "", maxes[2] + "", maxes[3] + "", maxes[4] + "", maxes[5] + "", });
            dataGridView3.Rows.Add(new string[] { mins[0] + "", mins[1] + "", mins[2] + "", mins[3] + "", mins[4] + "", mins[5] + "", });            
        }

        private string[][] getArray(DataGridView dgv)
        {
            string[][] arr = new string[dgv.RowCount - 1][];

            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                arr[i] = new string[dgv.RowCount - 1];
                for (int j = 0; j < 6; j++)
                {
                    arr[i][j] = dgv.Rows[i].Cells[j].Value.ToString();
                }
            }
            return arr;
        }

        private double[][] convertStringArrayToDouble(string[][] matrixString)
        {
            double[][] matrix = new double[matrixString.Length][];
            for (int i = 0; i < matrixString.Length; i++)
            {
                matrix[i] = new double[matrixString[i].Length];
                for (int j = 0; j < matrixString[i].Length - 1; j++)
                {
                    matrix[i][j] = double.Parse(matrixString[i][j]);
                }
            }
            return matrix;
        }

        private double[] getMax(double[][] matrix)
        {
            double[] max = new double[matrix.Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                max[i] = int.MinValue;
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    if (max[i] < matrix[j][i])
                    {
                        max[i] = matrix[j][i];
                    }
                }
            }
            return max;
        }

        private double[] getMin(double[][] matrix)
        {
            double[] min = new double[matrix.Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                min[i] = int.MaxValue;
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    if (min[i] > matrix[j][i])
                    {
                        min[i] = matrix[j][i];
                    }
                }
            }
            return min;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
        }

        private void Lab9_view_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Dispose();
        }
    }
}
