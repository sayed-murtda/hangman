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

    public partial class Form3 : Form
    {
        int score;
        char c;
        String name;
        String leavel;

        public void set(char c, int score, String name,String leavel)
        {
            this.score = score;
            
            this.name = name;
            this.leavel = leavel;
            switch (c)
            {
                case 'e':
                    this.leavel = "Normal";
                    this.c = 'n';
                    break;
                case 'n':
                    this.leavel = "Hard";
                    this.c = 'h';
                    break;
                case 'h':
                    this.leavel = "Hard";
                    this.c = 'h';

                    break;

            }
        }
        public Form3()
        {
            InitializeComponent();
        }



        private void palyagin(object sender, EventArgs e)
        {
            Button fff = sender as Button;
            
            char j = fff.Name.ElementAt(0);
            this.Hide();
            Form2 f2 =new  Form2();
            f2.setleavel(j, name);
            f2.ShowDialog();

            this.Close();



        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            this.CenterToScreen();
            txtname.Text = "Player : " + name;
            txtscore.Text = "Score  : " + score;
            if (score > 40)
            {
                txtwin.Text = "You Win";
                button1.Text = "Next Leavel (" + leavel + ")";
            }
            else
            {
                txtwin.Text = "You Lose";
                label2.Visible = false;
                button1.Visible = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form2 f2 = new Form2();
            f2.setleavel(c, name);
            f2.ShowDialog();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
            this.Close();
        }
    }
}
