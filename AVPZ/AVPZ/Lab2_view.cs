using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AVPZ.Sources;
using System.Globalization;

namespace AVPZ
{
    public partial class Lab2_view : Form
    {
        public Lab2_view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showResult();
        }

        /**
         * Calculate inputted argument, handle exception and show result
         */
        private void showResult()
        {
            Lab2 calculate = new Lab2();

            try
            {
                calculate.beta = Double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                label11.Text = "" + calculate.check();
            }
            catch (FormatException) { MessageBox.Show("Помилка, введіть число."); }
            catch (ArgumentNullException exc) { MessageBox.Show("" + exc); }
            catch (OverflowException exc) { MessageBox.Show("" + exc); }
            catch (Exception exc) { MessageBox.Show("" + exc.Message); }
        }

        private void Lab2_view_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Dispose();
        }

        /**
         * Handle char input
         */
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '.');
        }

        /**
         * Clear text field
         */
        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }
    }
}
