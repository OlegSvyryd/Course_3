using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AVPZ.Sources.Lab5;
namespace AVPZ
{
    public partial class Lab5_view : Form
    {
        public Lab5_view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showResult();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        /**
         * Calculating
         */
        private void showResult()
        {
            Lab5 calculate = new Lab5();

            try
            {
                richTextBox1.Text = "Root of function: " + calculate.calculate();
            }
            catch (ArgumentNullException exc) { MessageBox.Show("" + exc); }
            catch (OverflowException exc) { MessageBox.Show("" + exc); }
            catch (Exception exc) { MessageBox.Show("" + exc.Message); }
        }

        private void Lab5_view_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Dispose();
        }
    }
}
