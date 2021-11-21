using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsHFSSExtract;

namespace ClassParseTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "HFSS Files (*.hfss)|*.hfss";
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;

            clsHFSSProject proj = new clsHFSSProject(textBox1.Text);

            textBox1.Text = proj.FileName;
            textBox2.Text = proj.Path;
            textBox3.Text = proj.FileAndPath;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
