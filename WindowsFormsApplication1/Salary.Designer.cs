namespace WindowsFormsApplication1
{
    partial class Salary
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
            this.label2 = new System.Windows.Forms.Label();
            this.salcyEdte = new System.Windows.Forms.DateTimePicker();
            this.salcyBdte = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.SCDRange = new System.Windows.Forms.Label();
            this.validatetbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.setgrpBx = new System.Windows.Forms.GroupBox();
            this.taxtxt = new System.Windows.Forms.TextBox();
            this.NoOflvstxt = new System.Windows.Forms.TextBox();
            this.salcyDrngtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.empgrpbox = new System.Windows.Forms.GroupBox();
            this.saltxt = new System.Windows.Forms.TextBox();
            this.sal = new System.Windows.Forms.Label();
            this.srchbtn = new System.Windows.Forms.Button();
            this.allwnstxt = new System.Windows.Forms.TextBox();
            this.otrtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.empidtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.othourstxt = new System.Windows.Forms.TextBox();
            this.absenttxt = new System.Windows.Forms.TextBox();
            this.salgrpbox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.insertbtn = new System.Windows.Forms.Button();
            this.basepaytxt = new System.Windows.Forms.TextBox();
            this.grosspaytxt = new System.Windows.Forms.TextBox();
            this.nopaytxt = new System.Windows.Forms.TextBox();
            this.calbtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.hollydaytxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.leavestxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.setgrpBx.SuspendLayout();
            this.empgrpbox.SuspendLayout();
            this.salgrpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Goverment Tax";
            // 
            // salcyEdte
            // 
            this.salcyEdte.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salcyEdte.Location = new System.Drawing.Point(310, 110);
            this.salcyEdte.Name = "salcyEdte";
            this.salcyEdte.Size = new System.Drawing.Size(303, 26);
            this.salcyEdte.TabIndex = 39;
            // 
            // salcyBdte
            // 
            this.salcyBdte.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salcyBdte.Location = new System.Drawing.Point(310, 69);
            this.salcyBdte.Name = "salcyBdte";
            this.salcyBdte.Size = new System.Drawing.Size(303, 26);
            this.salcyBdte.TabIndex = 38;
            this.salcyBdte.ValueChanged += new System.EventHandler(this.salcyBdte_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "No Of Leaves Per Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Salary Cycle End Date";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(28, 110);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(203, 25);
            this.lbl.TabIndex = 33;
            this.lbl.Text = "Salary Cycle Begin Date";
            // 
            // SCDRange
            // 
            this.SCDRange.AutoSize = true;
            this.SCDRange.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCDRange.Location = new System.Drawing.Point(28, 156);
            this.SCDRange.Name = "SCDRange";
            this.SCDRange.Size = new System.Drawing.Size(155, 25);
            this.SCDRange.TabIndex = 32;
            this.SCDRange.Text = "Salary Cycle Days";
            // 
            // validatetbtn
            // 
            this.validatetbtn.BackColor = System.Drawing.Color.White;
            this.validatetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.validatetbtn.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validatetbtn.Location = new System.Drawing.Point(671, 236);
            this.validatetbtn.Name = "validatetbtn";
            this.validatetbtn.Size = new System.Drawing.Size(101, 38);
            this.validatetbtn.TabIndex = 42;
            this.validatetbtn.Text = "Validate";
            this.validatetbtn.UseVisualStyleBackColor = false;
            this.validatetbtn.Click += new System.EventHandler(this.validatetbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Employee Name";
            // 
            // setgrpBx
            // 
            this.setgrpBx.BackColor = System.Drawing.Color.Transparent;
            this.setgrpBx.Controls.Add(this.taxtxt);
            this.setgrpBx.Controls.Add(this.NoOflvstxt);
            this.setgrpBx.Controls.Add(this.salcyDrngtxt);
            this.setgrpBx.Controls.Add(this.validatetbtn);
            this.setgrpBx.Controls.Add(this.label2);
            this.setgrpBx.Controls.Add(this.salcyEdte);
            this.setgrpBx.Controls.Add(this.salcyBdte);
            this.setgrpBx.Controls.Add(this.label6);
            this.setgrpBx.Controls.Add(this.label5);
            this.setgrpBx.Controls.Add(this.lbl);
            this.setgrpBx.Controls.Add(this.SCDRange);
            this.setgrpBx.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setgrpBx.Location = new System.Drawing.Point(16, 26);
            this.setgrpBx.Name = "setgrpBx";
            this.setgrpBx.Size = new System.Drawing.Size(794, 311);
            this.setgrpBx.TabIndex = 47;
            this.setgrpBx.TabStop = false;
            this.setgrpBx.Text = "Salary Setting Details";
            this.setgrpBx.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // taxtxt
            // 
            this.taxtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxtxt.Location = new System.Drawing.Point(310, 251);
            this.taxtxt.Name = "taxtxt";
            this.taxtxt.Size = new System.Drawing.Size(303, 24);
            this.taxtxt.TabIndex = 63;
            // 
            // NoOflvstxt
            // 
            this.NoOflvstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOflvstxt.Location = new System.Drawing.Point(310, 203);
            this.NoOflvstxt.Name = "NoOflvstxt";
            this.NoOflvstxt.Size = new System.Drawing.Size(303, 24);
            this.NoOflvstxt.TabIndex = 61;
            // 
            // salcyDrngtxt
            // 
            this.salcyDrngtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salcyDrngtxt.Location = new System.Drawing.Point(310, 154);
            this.salcyDrngtxt.Name = "salcyDrngtxt";
            this.salcyDrngtxt.Size = new System.Drawing.Size(303, 24);
            this.salcyDrngtxt.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 25);
            this.label11.TabIndex = 49;
            this.label11.Text = "Allowances";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 48;
            this.label7.Text = "OT Rate";
            // 
            // empgrpbox
            // 
            this.empgrpbox.BackColor = System.Drawing.Color.Transparent;
            this.empgrpbox.Controls.Add(this.saltxt);
            this.empgrpbox.Controls.Add(this.sal);
            this.empgrpbox.Controls.Add(this.srchbtn);
            this.empgrpbox.Controls.Add(this.allwnstxt);
            this.empgrpbox.Controls.Add(this.otrtxt);
            this.empgrpbox.Controls.Add(this.label11);
            this.empgrpbox.Controls.Add(this.label7);
            this.empgrpbox.Controls.Add(this.nametxt);
            this.empgrpbox.Controls.Add(this.empidtxt);
            this.empgrpbox.Controls.Add(this.label3);
            this.empgrpbox.Controls.Add(this.label1);
            this.empgrpbox.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empgrpbox.Location = new System.Drawing.Point(16, 343);
            this.empgrpbox.Name = "empgrpbox";
            this.empgrpbox.Size = new System.Drawing.Size(794, 247);
            this.empgrpbox.TabIndex = 52;
            this.empgrpbox.TabStop = false;
            this.empgrpbox.Text = "Employee Details";
            this.empgrpbox.Enter += new System.EventHandler(this.empgrpbox_Enter);
            // 
            // saltxt
            // 
            this.saltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saltxt.Location = new System.Drawing.Point(310, 214);
            this.saltxt.Name = "saltxt";
            this.saltxt.Size = new System.Drawing.Size(303, 24);
            this.saltxt.TabIndex = 53;
            // 
            // sal
            // 
            this.sal.AutoSize = true;
            this.sal.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal.Location = new System.Drawing.Point(18, 214);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(131, 25);
            this.sal.TabIndex = 52;
            this.sal.Text = "Monthly Salary";
            // 
            // srchbtn
            // 
            this.srchbtn.BackColor = System.Drawing.Color.White;
            this.srchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.srchbtn.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchbtn.Location = new System.Drawing.Point(671, 200);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(101, 38);
            this.srchbtn.TabIndex = 43;
            this.srchbtn.Text = "Search";
            this.srchbtn.UseVisualStyleBackColor = false;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // allwnstxt
            // 
            this.allwnstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allwnstxt.Location = new System.Drawing.Point(310, 172);
            this.allwnstxt.Name = "allwnstxt";
            this.allwnstxt.Size = new System.Drawing.Size(303, 24);
            this.allwnstxt.TabIndex = 51;
            // 
            // otrtxt
            // 
            this.otrtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otrtxt.Location = new System.Drawing.Point(310, 132);
            this.otrtxt.Name = "otrtxt";
            this.otrtxt.Size = new System.Drawing.Size(303, 24);
            this.otrtxt.TabIndex = 50;
            this.otrtxt.TextChanged += new System.EventHandler(this.otrtxt_TextChanged);
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(310, 92);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(303, 24);
            this.nametxt.TabIndex = 46;
            // 
            // empidtxt
            // 
            this.empidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empidtxt.Location = new System.Drawing.Point(310, 50);
            this.empidtxt.Name = "empidtxt";
            this.empidtxt.Size = new System.Drawing.Size(303, 24);
            this.empidtxt.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Over Time Hours";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 25);
            this.label9.TabIndex = 54;
            this.label9.Text = "No Of Absent Days";
            // 
            // othourstxt
            // 
            this.othourstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othourstxt.Location = new System.Drawing.Point(310, 187);
            this.othourstxt.Name = "othourstxt";
            this.othourstxt.Size = new System.Drawing.Size(303, 24);
            this.othourstxt.TabIndex = 55;
            // 
            // absenttxt
            // 
            this.absenttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absenttxt.Location = new System.Drawing.Point(310, 107);
            this.absenttxt.Name = "absenttxt";
            this.absenttxt.Size = new System.Drawing.Size(303, 24);
            this.absenttxt.TabIndex = 53;
            // 
            // salgrpbox
            // 
            this.salgrpbox.BackColor = System.Drawing.Color.Transparent;
            this.salgrpbox.Controls.Add(this.button2);
            this.salgrpbox.Controls.Add(this.insertbtn);
            this.salgrpbox.Controls.Add(this.basepaytxt);
            this.salgrpbox.Controls.Add(this.grosspaytxt);
            this.salgrpbox.Controls.Add(this.nopaytxt);
            this.salgrpbox.Controls.Add(this.calbtn);
            this.salgrpbox.Controls.Add(this.label12);
            this.salgrpbox.Controls.Add(this.label13);
            this.salgrpbox.Controls.Add(this.label14);
            this.salgrpbox.Controls.Add(this.othourstxt);
            this.salgrpbox.Controls.Add(this.label4);
            this.salgrpbox.Controls.Add(this.hollydaytxt);
            this.salgrpbox.Controls.Add(this.label8);
            this.salgrpbox.Controls.Add(this.absenttxt);
            this.salgrpbox.Controls.Add(this.label9);
            this.salgrpbox.Controls.Add(this.leavestxt);
            this.salgrpbox.Controls.Add(this.label10);
            this.salgrpbox.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salgrpbox.Location = new System.Drawing.Point(16, 624);
            this.salgrpbox.Name = "salgrpbox";
            this.salgrpbox.Size = new System.Drawing.Size(1158, 336);
            this.salgrpbox.TabIndex = 60;
            this.salgrpbox.TabStop = false;
            this.salgrpbox.Text = "Salary Calculation";
            this.salgrpbox.Enter += new System.EventHandler(this.salgrpbox_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(14, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 34);
            this.button2.TabIndex = 67;
            this.button2.Text = "Back to Home Menu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // insertbtn
            // 
            this.insertbtn.BackColor = System.Drawing.Color.White;
            this.insertbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insertbtn.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbtn.Location = new System.Drawing.Point(888, 286);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(211, 38);
            this.insertbtn.TabIndex = 66;
            this.insertbtn.Text = "Insert into Salary Table ";
            this.insertbtn.UseVisualStyleBackColor = false;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // basepaytxt
            // 
            this.basepaytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basepaytxt.Location = new System.Drawing.Point(860, 214);
            this.basepaytxt.Name = "basepaytxt";
            this.basepaytxt.Size = new System.Drawing.Size(239, 24);
            this.basepaytxt.TabIndex = 65;
            // 
            // grosspaytxt
            // 
            this.grosspaytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grosspaytxt.Location = new System.Drawing.Point(860, 146);
            this.grosspaytxt.Name = "grosspaytxt";
            this.grosspaytxt.Size = new System.Drawing.Size(239, 24);
            this.grosspaytxt.TabIndex = 64;
            this.grosspaytxt.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // nopaytxt
            // 
            this.nopaytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nopaytxt.Location = new System.Drawing.Point(860, 79);
            this.nopaytxt.Name = "nopaytxt";
            this.nopaytxt.Size = new System.Drawing.Size(239, 24);
            this.nopaytxt.TabIndex = 63;
            // 
            // calbtn
            // 
            this.calbtn.BackColor = System.Drawing.Color.White;
            this.calbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calbtn.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calbtn.Location = new System.Drawing.Point(512, 276);
            this.calbtn.Name = "calbtn";
            this.calbtn.Size = new System.Drawing.Size(101, 38);
            this.calbtn.TabIndex = 52;
            this.calbtn.Text = "Calculate";
            this.calbtn.UseVisualStyleBackColor = false;
            this.calbtn.Click += new System.EventHandler(this.calbtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(855, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 27);
            this.label12.TabIndex = 59;
            this.label12.Text = "Base Pay Values";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(855, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 27);
            this.label13.TabIndex = 58;
            this.label13.Text = "Gross Pay Values";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(855, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 27);
            this.label14.TabIndex = 57;
            this.label14.Text = "No Pay Values";
            // 
            // hollydaytxt
            // 
            this.hollydaytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hollydaytxt.Location = new System.Drawing.Point(310, 147);
            this.hollydaytxt.Name = "hollydaytxt";
            this.hollydaytxt.Size = new System.Drawing.Size(303, 24);
            this.hollydaytxt.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 55;
            this.label8.Text = "No Of HoliDays";
            // 
            // leavestxt
            // 
            this.leavestxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leavestxt.Location = new System.Drawing.Point(310, 65);
            this.leavestxt.Name = "leavestxt";
            this.leavestxt.Size = new System.Drawing.Size(303, 24);
            this.leavestxt.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 25);
            this.label10.TabIndex = 53;
            this.label10.Text = "No Of Leaves";
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Annotation_2023_04_02_013051;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1219, 972);
            this.Controls.Add(this.salgrpbox);
            this.Controls.Add(this.empgrpbox);
            this.Controls.Add(this.setgrpBx);
            this.Name = "Salary";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.setgrpBx.ResumeLayout(false);
            this.setgrpBx.PerformLayout();
            this.empgrpbox.ResumeLayout(false);
            this.empgrpbox.PerformLayout();
            this.salgrpbox.ResumeLayout(false);
            this.salgrpbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker salcyEdte;
        private System.Windows.Forms.DateTimePicker salcyBdte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label SCDRange;
        private System.Windows.Forms.Button validatetbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox setgrpBx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox empgrpbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox othourstxt;
        private System.Windows.Forms.TextBox absenttxt;
        private System.Windows.Forms.GroupBox salgrpbox;
        private System.Windows.Forms.Button srchbtn;
        private System.Windows.Forms.TextBox allwnstxt;
        private System.Windows.Forms.TextBox otrtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Button calbtn;
        private System.Windows.Forms.TextBox taxtxt;
        private System.Windows.Forms.TextBox NoOflvstxt;
        private System.Windows.Forms.TextBox salcyDrngtxt;
        private System.Windows.Forms.TextBox empidtxt;
        private System.Windows.Forms.TextBox saltxt;
        private System.Windows.Forms.Label sal;
        private System.Windows.Forms.TextBox hollydaytxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox leavestxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.TextBox basepaytxt;
        private System.Windows.Forms.TextBox grosspaytxt;
        private System.Windows.Forms.TextBox nopaytxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
    }
}