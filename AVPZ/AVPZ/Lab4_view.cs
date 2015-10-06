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
    public partial class Lab4_view : Form
    {
        public Lab4_view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showResult();
            richTextBox1.SelectionStart = richTextBox1.Text.Length; //Set the current caret position at the end
            richTextBox1.ScrollToCaret(); //Now scroll it automatically
        }

        /**
         * Calculate inputted argument, handle exception and show result
         */
        private void showResult()
        {
            Lab4 calculate = new Lab4();

            try
            {
                calculate.a = (float)Double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                calculate.b = (float)Double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
                calculate.q = (float)Double.Parse(textBox3.Text, CultureInfo.InvariantCulture);

                calculate.calculate();
                richTextBox1.Text = (calculate.x12.Equals(0)) ? ("Discriminant > 0: x1="+calculate.x1 + "; x2=" + calculate.x2) : ("Discriminant = 0: x1=x2=" +calculate.x12);
            }
            catch (FormatException) { MessageBox.Show("Помилка, введіть число."); }
            catch (ArgumentNullException exc) { MessageBox.Show("" + exc); }
            catch (OverflowException exc) { MessageBox.Show("" + exc); }
            catch (Exception exc) { MessageBox.Show("" + exc.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
        }

        private void Lab4_view_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Dispose();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '.');
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '.');
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '.');
        }
    }
}
