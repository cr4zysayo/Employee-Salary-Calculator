namespace Employee_Salary_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.Fname1 = new System.Windows.Forms.TextBox();
            this.Department1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lname1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Jtitle1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Rate1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tworked1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Fname2 = new System.Windows.Forms.Label();
            this.Lname2 = new System.Windows.Forms.Label();
            this.Bsalary1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Fname1
            // 
            this.Fname1.Location = new System.Drawing.Point(16, 32);
            this.Fname1.Name = "Fname1";
            this.Fname1.Size = new System.Drawing.Size(179, 20);
            this.Fname1.TabIndex = 1;
            this.Fname1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Department1
            // 
            this.Department1.Location = new System.Drawing.Point(16, 78);
            this.Department1.Name = "Department1";
            this.Department1.Size = new System.Drawing.Size(179, 20);
            this.Department1.TabIndex = 3;
            this.Department1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department";
            // 
            // Lname1
            // 
            this.Lname1.Location = new System.Drawing.Point(211, 32);
            this.Lname1.Name = "Lname1";
            this.Lname1.Size = new System.Drawing.Size(179, 20);
            this.Lname1.TabIndex = 5;
            this.Lname1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // Jtitle1
            // 
            this.Jtitle1.Location = new System.Drawing.Point(211, 78);
            this.Jtitle1.Name = "Jtitle1";
            this.Jtitle1.Size = new System.Drawing.Size(179, 20);
            this.Jtitle1.TabIndex = 7;
            this.Jtitle1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Job Title";
            // 
            // Rate1
            // 
            this.Rate1.Location = new System.Drawing.Point(16, 149);
            this.Rate1.Name = "Rate1";
            this.Rate1.Size = new System.Drawing.Size(179, 20);
            this.Rate1.TabIndex = 9;
            this.Rate1.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rate per hour";
            // 
            // Tworked1
            // 
            this.Tworked1.Location = new System.Drawing.Point(211, 149);
            this.Tworked1.Name = "Tworked1";
            this.Tworked1.Size = new System.Drawing.Size(179, 20);
            this.Tworked1.TabIndex = 11;
            this.Tworked1.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total hours worked";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Compute Salary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "First Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Last Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Basic Salary:";
            // 
            // Fname2
            // 
            this.Fname2.AutoSize = true;
            this.Fname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname2.Location = new System.Drawing.Point(127, 225);
            this.Fname2.Name = "Fname2";
            this.Fname2.Size = new System.Drawing.Size(133, 20);
            this.Fname2.TabIndex = 16;
            this.Fname2.Text = "<first name here>";
            this.Fname2.Click += new System.EventHandler(this.label10_Click);
            // 
            // Lname2
            // 
            this.Lname2.AutoSize = true;
            this.Lname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname2.Location = new System.Drawing.Point(127, 255);
            this.Lname2.Name = "Lname2";
            this.Lname2.Size = new System.Drawing.Size(132, 20);
            this.Lname2.TabIndex = 17;
            this.Lname2.Text = "<last name here>";
            this.Lname2.Click += new System.EventHandler(this.label11_Click);
            // 
            // Bsalary1
            // 
            this.Bsalary1.AutoSize = true;
            this.Bsalary1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bsalary1.Location = new System.Drawing.Point(127, 285);
            this.Bsalary1.Name = "Bsalary1";
            this.Bsalary1.Size = new System.Drawing.Size(49, 20);
            this.Bsalary1.TabIndex = 18;
            this.Bsalary1.Text = "00.00";
            this.Bsalary1.Click += new System.EventHandler(this.label12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 321);
            this.Controls.Add(this.Bsalary1);
            this.Controls.Add(this.Lname2);
            this.Controls.Add(this.Fname2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tworked1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Rate1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Jtitle1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lname1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Department1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fname1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fname1;
        private System.Windows.Forms.TextBox Department1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Lname1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Jtitle1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Rate1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tworked1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Fname2;
        private System.Windows.Forms.Label Lname2;
        private System.Windows.Forms.Label Bsalary1;
    }
}

