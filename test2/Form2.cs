
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace test2
{
    public partial class Form2 : Form
    {
        private Bitmap [] pictherm ={test2.Properties.Resources._4,
        test2.Properties.Resources._5,
        test2.Properties.Resources._6,
        test2.Properties.Resources._7,
        test2.Properties.Resources._8,
        test2.Properties.Resources._9,
        test2.Properties.Resources._10,
        test2.Properties.Resources._4};
        int mastek;
        
        int win;
         char lavel='f';
        bool lose = true;
        private String xxx;
        private String[] word = { "red/color",
  "bahrain/country",
   "yellow/color",
   "white/color",
   "black/color",
    "mango/fruits",
   "accountant/job",
   "editor/job",
   "apple/fruits",
    "banana/fruits",
   "crey/color",
    "melon/fruits",
   "lawyer/job",
   "egypt/country",
    "blackberry/fruits",
   "driver/job",
   "sudan/country",
    "fig/fruits",
   "baker/job",
   "tunisia/country",
    "cherry/fruits",
   "somalia/country",
   "dyer/job",
   "iraq/country",
   "waiter/job",
   "silver/color",
   "brown/color",
    "grape/fruits",
    "lrmon/fruits",
   "teacher/job",
   "actor/job",
   "morocco/country",
   "algeria/country",
   "syria/country",
   "author/job",
   "yemen/country",
   "barber/job",
   "qatar/country",
   "purple/color",
   "clerk/job",
   "orange/color",
   "maroon/color",
   "green/color",

"dector/job"};
        Form3 f2 = new Form3();

        public void selectword() {
            timer1.Start();
            mastek = 0;
            Class1 soso = new Class1();
            int dd = soso.RandomNumber(1, 43);
            
           Array.Sort(word);
            

            picther.Image = pictherm[mastek];
            String  s  = word[dd];
            String[] w = s.Split('/');
            label1.Text = w[1];
            xxx = w[0];
            win = xxx.Length;
            viewtexbox(w[0].Length);

        }

      

        String lavelname;
        String name;
        public void setleavel(char m,string name="null") {
            
            this.name = name;
            lavel = m;
            txtname.Text ="Player : "+name;
            switch (lavel)
            {
                case 'e':
                    lavelname = "Essay";
                    second = 90;
                    break;
                case 'n':
                    lavelname = "Normal";
                    second = 60;
                    break;
                case 'h':
                    lavelname = "Hard";
                    second = 30;


                    break;
               
            }
            txtscore.Text = "Score " + lavelname + " : " + (scoreE * 10 );

        }
        
        int scoreE=0;
        
        public void selectscore() {
            scoreE++;
            txtscore.Text = "Score " + lavelname + " : " + (scoreE * 10 ) ;


        }
        private void EnButton(bool n)
        {
            lose = n;
            
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is Button)
                        (control as Button).Visible=n;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        public void viewtexbox(int m) {
            textBox1.Text = "";
            for (int i = 0; i < m; i++) {
                textBox1.Text += " _";
            }

        }
        public void change(int m,char c) {
            m = m * 2+1;
            
            Char[] test=textBox1.Text.ToCharArray();
            
            String after ="";
            for (int i = 0; i < test.Length; i++) {
                if (m == i)
                {
                    after += c;
                }
                else
                {
                    after += test[i];
                   
                }

            }
            
            textBox1.Text = after;
            if (win == 0)
            {
               
                EnButton(true);
                selectword();
                selectscore();
            }
        }
        public void cheakword(Char c) {
            bool f = false;
            Char[] test = xxx.ToCharArray();
            for (int i = 0; i < test.Length; i++) {
                if (test[i].Equals(c)) {
                    win--;
                    change(i,c);
                    f = true;
                   
            }
            }
            if (!f) {
                mastek++;
                if (mastek < 8)
                {
                    picther.Image = pictherm[mastek];
                    if (mastek == 6)
                    {
                        textBox1.Text = xxx;
                        timer1.Stop();
                        lose = false;
                        this.Close();
                        f2.set(lavel, scoreE * 10, name,lavelname);
                        f2.ShowDialog();
                        
                    }
                }
            }

        
        }
        
        public Form2()
        {
            InitializeComponent();
        }

        

        private void geussClick(object sender, EventArgs e)
        {
            if (lose)
            {
                Button co = sender as Button;
                txtname.Focus();
                co.Visible = false;
                String n = co.Text;
                n = n.ToLower();
                char[] f = n.ToArray();
                
                cheakword(f[0]);
            }
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            selectword();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            this.CenterToScreen();
            selectword();
        }
        int second;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
             second--;
            if (second > 60)

                tiymer.Text = "Time 01:" + (second-60);
            else
                tiymer.Text = "Time 00:" + second;


            if (second == 0)
            {
                textBox1.Text = xxx;
                this.Close();
                timer1.Stop();
                f2.set(lavel,scoreE*10,name,lavelname);
                f2.ShowDialog();
            }
        }
       

      
    }
}
