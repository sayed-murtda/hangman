namespace test2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtname = new System.Windows.Forms.TextBox();
            this.RN = new System.Windows.Forms.RadioButton();
            this.RE = new System.Windows.Forms.RadioButton();
            this.n = new System.Windows.Forms.Label();
            this.RH = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtname.Location = new System.Drawing.Point(187, 156);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(269, 20);
            this.txtname.TabIndex = 0;
            // 
            // RN
            // 
            this.RN.AutoSize = true;
            this.RN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RN.Location = new System.Drawing.Point(251, 184);
            this.RN.Name = "RN";
            this.RN.Size = new System.Drawing.Size(67, 20);
            this.RN.TabIndex = 2;
            this.RN.TabStop = true;
            this.RN.Text = "Normal";
            this.RN.UseVisualStyleBackColor = true;
            this.RN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RE
            // 
            this.RE.AutoSize = true;
            this.RE.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RE.Location = new System.Drawing.Point(187, 184);
            this.RE.Name = "RE";
            this.RE.Size = new System.Drawing.Size(58, 20);
            this.RE.TabIndex = 3;
            this.RE.TabStop = true;
            this.RE.Text = "Essay";
            this.RE.UseVisualStyleBackColor = true;
            this.RE.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.n.Location = new System.Drawing.Point(10, 151);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(173, 25);
            this.n.TabIndex = 10;
            this.n.Text = "Enter Your Name";
            this.n.Click += new System.EventHandler(this.label1_Click);
            // 
            // RH
            // 
            this.RH.AutoSize = true;
            this.RH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RH.Location = new System.Drawing.Point(324, 184);
            this.RH.Name = "RH";
            this.RH.Size = new System.Drawing.Size(53, 20);
            this.RH.TabIndex = 11;
            this.RH.TabStop = true;
            this.RH.Text = "Hard";
            this.RH.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(383, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Strart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(108, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 58);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hang Man";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 184);
            this.label2.TabIndex = 14;
            this.label2.Text = "The Rules :\r\n- You must get 50 points to win.\r\n- You have one try at a time.\r\n- Y" +
    "ou must get 50 points before \r\n    the time runs out.\r\n   For Easy   01:30\r\n   F" +
    "or Normal 01:00\r\n   For Hard   00:30\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::test2.Properties.Resources.sis;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(301, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(509, 414);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RH);
            this.Controls.Add(this.n);
            this.Controls.Add(this.RE);
            this.Controls.Add(this.RN);
            this.Controls.Add(this.txtname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.Name = "Form1";
            this.Text = "HangMan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.RadioButton RN;
        private System.Windows.Forms.RadioButton RE;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.RadioButton RH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

