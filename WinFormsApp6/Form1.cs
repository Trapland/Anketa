using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("File.txt", false);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sw.WriteLine(listBox1.Items[i]);
            }
            sw.Close();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("File.txt", Encoding.UTF8);
            while (sr.Peek() != -1)
            {
                listBox1.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
        }

        private void importToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("File.txt", false);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sw.WriteLine(listBox1.Items[i]);
            }
            sw.Close();
        }

        private void exportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("File.txt", Encoding.UTF8);
            while (sr.Peek() != -1)
            {
                listBox1.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }
    }
}
