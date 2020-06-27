namespace test2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.Label();
            this.txtscore = new System.Windows.Forms.Label();
            this.txtwin = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.h);
            this.panel1.Controls.Add(this.e);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.n);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 102);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Or";
            // 
            // h
            // 
            this.h.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.h.ForeColor = System.Drawing.Color.Transparent;
            this.h.Location = new System.Drawing.Point(123, 61);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(60, 23);
            this.h.TabIndex = 3;
            this.h.Text = "Hard";
            this.h.UseVisualStyleBackColor = false;
            this.h.Click += new System.EventHandler(this.palyagin);
            // 
            // e
            // 
            this.e.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.e.ForeColor = System.Drawing.Color.Transparent;
            this.e.Location = new System.Drawing.Point(15, 61);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(60, 23);
            this.e.TabIndex = 2;
            this.e.Text = "Esay";
            this.e.UseVisualStyleBackColor = false;
            this.e.Click += new System.EventHandler(this.palyagin);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(170, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Next Leavel (Normal)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // n
            // 
            this.n.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.n.ForeColor = System.Drawing.Color.Transparent;
            this.n.Location = new System.Drawing.Point(67, 61);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(60, 23);
            this.n.TabIndex = 1;
            this.n.Text = "Normal";
            this.n.UseVisualStyleBackColor = false;
            this.n.Click += new System.EventHandler(this.palyagin);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Play agin";
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(12, 19);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(163, 29);
            this.txtname.TabIndex = 1;
            this.txtname.Text = "Player :  nun";
            // 
            // txtscore
            // 
            this.txtscore.AutoSize = true;
            this.txtscore.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore.Location = new System.Drawing.Point(198, 19);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(148, 29);
            this.txtscore.TabIndex = 2;
            this.txtscore.Text = "Score:  nun";
            // 
            // txtwin
            // 
            this.txtwin.AutoSize = true;
            this.txtwin.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwin.ForeColor = System.Drawing.Color.Red;
            this.txtwin.Location = new System.Drawing.Point(121, 62);
            this.txtwin.Name = "txtwin";
            this.txtwin.Size = new System.Drawing.Size(128, 33);
            this.txtwin.TabIndex = 3;
            this.txtwin.Text = "You Win";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(12, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Beginning";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(101, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 31);
            this.button3.TabIndex = 6;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(393, 260);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtwin);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.Name = "Form3";
            this.Text = "HangMan";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.Label txtscore;
        private System.Windows.Forms.Button h;
        private System.Windows.Forms.Button e;
        private System.Windows.Forms.Button n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtwin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}