using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DrapGetPathCopied
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Enter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach(string file in droppedFiles)
            {
                string filename = getPath(file);
                // MessageBox.Show("You dropped " + filename);
                //listBox1.Items.Add(filename);
                if (textBox1.Text == "")
                {
                    textBox1.Text = filename;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "\r\n" + filename;
                }

                filename = getDir(file);
                // MessageBox.Show("You dropped " + filename);
                //listBox1.Items.Add(filename);
                if (textBox2.Text == "")
                {
                    textBox2.Text = filename;
                }
                else
                {
                    textBox2.Text = textBox2.Text + "\r\n" + filename;
                }

                filename = getFileName(file);
                // MessageBox.Show("You dropped " + filename);
                //listBox1.Items.Add(filename);
                if (textBox3.Text == "")
                {
                    textBox3.Text = filename;
                }
                else
                {
                    textBox3.Text = textBox3.Text + "\r\n" + filename;
                }


            }


        }

        private string getPath(string file)
        {
            return Path.GetFullPath(file);
        }

        private string getFileName(string file)
        {
            return Path.GetFileName(file);
        }

        private string getDir(string file)
        {
            return Path.GetDirectoryName(file);
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
