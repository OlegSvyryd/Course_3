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
    public partial class Lab1_view : Form
    {
        public Lab1_view()
        {
            InitializeComponent();
        }

        /**
         * Show result(click event)
         */
        private void button1_Click_1(object sender, EventArgs e)
        {
            showResult();
        }

        /**
         * Calculate inputted argument, handle exception and show result
         */
        private void showResult()
        {
            Lab1 calculate = new Lab1();

            try
            {
                calculate.inputValue = Double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                label11.Text = "" + calculate.calculateInput();
            }
            catch (FormatException) { MessageBox.Show("Помилка, введіть число."); }
            catch (ArgumentNullException exc) { MessageBox.Show("" + exc); }
            catch (OverflowException exc) { MessageBox.Show("" + exc); }
        }

        /**
         * Set var values in labels
         */
        private void generateInitialValues(double t, float a, byte w, double c)
        {
            label3.Text = t.ToString();
            label5.Text = a.ToString();
            label7.Text = w.ToString();
            label9.Text = c.ToString();
        }

        /**
         * Initialize vars and call generateInitialValues
         */
        private void Lab1_view_Shown(object sender, EventArgs e)
        {
            Lab1 calculate = new Lab1();
            calculate.initializeVariables();
            generateInitialValues(Lab1.T, calculate.a, calculate.w, calculate.c);
        }

        private void Lab1_view_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Dispose();
        }

        /**
         * Handle char input
         */
        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
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
