using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char m ='f';
            if (RE.Checked)
                m = 'e';
            else 
            if (RN.Checked)
                m = 'n';
            else
            if (RH.Checked)
                m = 'h';


            if (m != 'f')
            {
                this.Hide();
                Form2 f = new Form2();
               f.setleavel(m,txtname.Text);
               f.ShowDialog();
                this.Close();
            }else
                MessageBox.Show("Select Level");




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
