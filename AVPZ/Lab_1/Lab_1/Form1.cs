using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Lab_1.src;
using System.Globalization;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**
         * Show result(click event)
         */ 
        private void button1_Click(object sender, EventArgs e)
        {
            showResult();
        }

        /**
         * Calculate inputted argument, handle exception and show result
         */
        private void showResult()
        {
            Calculate calculate = new Calculate();
            
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
        private void Form1_Load(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate();
            calculate.initializeVariables();
            generateInitialValues(Calculate.T, calculate.a, calculate.w, calculate.c);
        }

        /**
         * Handle char input
         */ 
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '.');
        }
    }
}
