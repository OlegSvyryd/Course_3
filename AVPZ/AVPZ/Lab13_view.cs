using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using AVPZ.Sources;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace AVPZ
{
    public partial class Lab13_view : Form
    {
        public Lab13_view()
        {
            InitializeComponent();
        }

        private void Lab13_view_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test2();
        }

        private void test2()
        {
            List<Lab13> list = new List<Lab13>();

            list.Add(new Lab13("name1", "UA", 142f, 255.5f));
            list.Add(new Lab13("name2", "UA", 145f, 251.5f));
            list.Add(new Lab13("name3", "US", 147f, 212.5f));
            list.Add(new Lab13("name4", "UA", 149f, 253.5f));
            list.Add(new Lab13("name5", "UA", 145f, 254.5f));
            list.Add(new Lab13("name1", "UA", 142f, 255.5f));
            list.Add(new Lab13("name2", "UA", 145f, 222.5f));
            list.Add(new Lab13("name3", "US", 147f, 255.5f));
            list.Add(new Lab13("name4", "UA", 149f, 253.5f));
            list.Add(new Lab13("name5", "UA", 145f, 254.5f));
            list.Add(new Lab13("name6", "UA", 142f, 255.5f));
            list.Add(new Lab13("name7", "UA", 145f, 255.5f));
            list.Add(new Lab13("name8", "US", 147f, 212.5f));
            list.Add(new Lab13("name9", "UA", 149f, 253.5f));
            list.Add(new Lab13("name0", "UA", 145f, 255.5f));
            list.Add(new Lab13("name4", "UA", 149f, 253.5f));
            list.Add(new Lab13("name5", "UA", 145f, 222.5f));
            list.Add(new Lab13("name6", "UA", 142f, 222.5f));
            list.Add(new Lab13("name7", "UA", 145f, 255.5f));
            list.Add(new Lab13("name8", "US", 147f, 222.5f));
            list.Add(new Lab13("name9", "UA", 149f, 222.5f));
            list.Add(new Lab13("name0", "UA", 145f, 222.5f));

            //serialize
            using (Stream stream = File.Open("test.bin", FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, list);
            }

            list.Clear();
            //deserialize
            using (Stream stream = File.Open("test.bin", FileMode.Open))
            {
                TextWriter tw1 = new StreamWriter("test.txt");
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                list = (List<Lab13>)bformatter.Deserialize(stream);

                IEnumerable<Lab13> results = list.Distinct().Where(i => list.Where(it => it.country == i.country).Count() > 10);

                string country = "";
                float sum = 0;
                foreach (Lab13 obj in results)
                {
                    sum += obj.price;
                    country = obj.country;
                }
                tw1.WriteLine("Sum: " + sum + " ,country: " + country);

                tw1.Close();
            }

            TextReader tr1 = new StreamReader("test.txt");

            foreach (var line in File.ReadLines("test.txt"))
            {
                richTextBox1.Text += line;
            }

            tr1.Close();
        }
    }
}
