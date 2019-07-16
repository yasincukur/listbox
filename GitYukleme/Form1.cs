using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitYukleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            listBox1.Items.Add(veri);
            textBox1.Focus();
            textBox1.Clear();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            { 
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] dizi = { "yasin", "furkan", "sedat", "fatih", "murat", "selim", };
            foreach (string item in dizi)
            {
                listBox1.Items.Add(item);

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null )
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else if (listBox2.SelectedItem != null )
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }
    }
}
