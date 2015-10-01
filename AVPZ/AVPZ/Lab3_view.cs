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
    public partial class Lab3_view : Form
    {
        public Lab3_view()
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
            Lab3 calculate = new Lab3();

            try
            {
                richTextBox1.AppendText(calculate.result() + '\n');
            }
            catch (FormatException) { MessageBox.Show("Помилка, введіть число."); }
            catch (ArgumentNullException exc) { MessageBox.Show("" + exc); }
            catch (OverflowException exc) { MessageBox.Show("" + exc); }
            catch (Exception exc) { MessageBox.Show("" + exc.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Lab3_view_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Dispose();
        }
    }
}
