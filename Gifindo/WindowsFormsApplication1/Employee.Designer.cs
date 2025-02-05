namespace WindowsFormsApplication1
{
    partial class Employee
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.contacttxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.saltxt = new System.Windows.Forms.TextBox();
            this.otrtxt = new System.Windows.Forms.TextBox();
            this.allwnstxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.empidcombo = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.insrtbtn = new System.Windows.Forms.Button();
            this.updtbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 658);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "OT Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 595);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 27);
            this.label8.TabIndex = 7;
            this.label8.Text = "Monthly Salary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 535);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 27);
            this.label9.TabIndex = 8;
            this.label9.Text = "Joined Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 475);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 27);
            this.label10.TabIndex = 9;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 723);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 27);
            this.label11.TabIndex = 10;
            this.label11.Text = "Allowances";
            // 
            // agetxt
            // 
            this.agetxt.Location = new System.Drawing.Point(351, 304);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(303, 22);
            this.agetxt.TabIndex = 11;
            // 
            // contacttxt
            // 
            this.contacttxt.Location = new System.Drawing.Point(351, 412);
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(303, 22);
            this.contacttxt.TabIndex = 13;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(351, 478);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(303, 22);
            this.emailtxt.TabIndex = 14;
            // 
            // saltxt
            // 
            this.saltxt.Location = new System.Drawing.Point(351, 598);
            this.saltxt.Name = "saltxt";
            this.saltxt.Size = new System.Drawing.Size(303, 22);
            this.saltxt.TabIndex = 16;
            // 
            // otrtxt
            // 
            this.otrtxt.Location = new System.Drawing.Point(351, 661);
            this.otrtxt.Name = "otrtxt";
            this.otrtxt.Size = new System.Drawing.Size(303, 22);
            this.otrtxt.TabIndex = 17;
            // 
            // allwnstxt
            // 
            this.allwnstxt.Location = new System.Drawing.Point(351, 726);
            this.allwnstxt.Name = "allwnstxt";
            this.allwnstxt.Size = new System.Drawing.Size(303, 22);
            this.allwnstxt.TabIndex = 19;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(351, 247);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(303, 22);
            this.nametxt.TabIndex = 20;
            // 
            // empidcombo
            // 
            this.empidcombo.FormattingEnabled = true;
            this.empidcombo.Location = new System.Drawing.Point(351, 187);
            this.empidcombo.Name = "empidcombo";
            this.empidcombo.Size = new System.Drawing.Size(303, 24);
            this.empidcombo.TabIndex = 21;
            this.empidcombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(351, 363);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 29);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(519, 363);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 29);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(351, 529);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(303, 28);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(767, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 34);
            this.button1.TabIndex = 25;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // insrtbtn
            // 
            this.insrtbtn.BackColor = System.Drawing.Color.White;
            this.insrtbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insrtbtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insrtbtn.Location = new System.Drawing.Point(767, 272);
            this.insrtbtn.Name = "insrtbtn";
            this.insrtbtn.Size = new System.Drawing.Size(127, 34);
            this.insrtbtn.TabIndex = 26;
            this.insrtbtn.Text = "Insert";
            this.insrtbtn.UseVisualStyleBackColor = false;
            this.insrtbtn.Click += new System.EventHandler(this.insrtbtn_Click);
            // 
            // updtbtn
            // 
            this.updtbtn.BackColor = System.Drawing.Color.White;
            this.updtbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updtbtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updtbtn.Location = new System.Drawing.Point(767, 329);
            this.updtbtn.Name = "updtbtn";
            this.updtbtn.Size = new System.Drawing.Size(127, 34);
            this.updtbtn.TabIndex = 27;
            this.updtbtn.Text = "Update";
            this.updtbtn.UseVisualStyleBackColor = false;
            this.updtbtn.Click += new System.EventHandler(this.updtbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.Color.White;
            this.delbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delbtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.Location = new System.Drawing.Point(767, 391);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(127, 34);
            this.delbtn.TabIndex = 28;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = false;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.Color.White;
            this.clrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clrbtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrbtn.Location = new System.Drawing.Point(767, 514);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(127, 34);
            this.clrbtn.TabIndex = 0;
            this.clrbtn.Text = "Clear All";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // viewbtn
            // 
            this.viewbtn.BackColor = System.Drawing.Color.White;
            this.viewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewbtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbtn.Location = new System.Drawing.Point(767, 454);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(127, 34);
            this.viewbtn.TabIndex = 31;
            this.viewbtn.Text = "View All";
            this.viewbtn.UseVisualStyleBackColor = false;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Annotation_2023_04_02_013051;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 803);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.updtbtn);
            this.Controls.Add(this.insrtbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.empidcombo);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.allwnstxt);
            this.Controls.Add(this.otrtxt);
            this.Controls.Add(this.saltxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.contacttxt);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Employee";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.TextBox contacttxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox saltxt;
        private System.Windows.Forms.TextBox otrtxt;
        private System.Windows.Forms.TextBox allwnstxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.ComboBox empidcombo;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button insrtbtn;
        private System.Windows.Forms.Button updtbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.Button viewbtn;
    }
}