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
    public partial class Lab12_view : Form
    {
        public Lab12_view()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label11.Text = "";
        }

        private void Lab12_view_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Dispose();
        }

        private string getText(string inputText)
        {
            int i = inputText.IndexOf('+');
            int length = inputText.Length;
            string before = inputText.Substring(0, i);
            string after = inputText.Substring(i + 1, length - (i + 1));

            return after + '+' + before;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label11.Text += getText(textBox1.Text);
            }
            catch (ArgumentNullException exc) { MessageBox.Show("" + exc); }
            catch (ArgumentOutOfRangeException exc) { MessageBox.Show("" + exc.Message); }
            catch (OverflowException exc) { MessageBox.Show("" + exc); }
            catch (Exception exc) { MessageBox.Show("" + exc.Message); }
        }
    }
}
