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
    public partial class Lab6_view : Form
    {
        public Lab6_view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                generateMatrix(dataGridView4);
            }
            catch (NullReferenceException e1) { MessageBox.Show("Помилка, заповніть всі клітинки."); }
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

        private void generateMatrix(DataGridView dgv)
        {
            string[] arr1 = getArray(dataGridView1);
            string[] arr2 = getArray(dataGridView2);
            string[] arr3 = getArray(dataGridView3);

            for (int i = 0; i < arr1.Length; i++)
            {
                dgv.Rows.Add(new string[] { arr1[i], arr2[i], arr3[i] });
            }
        }

        private void Lab6_view_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();
        }
    }
}
