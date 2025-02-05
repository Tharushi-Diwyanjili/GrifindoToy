namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.SCDRange = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NoOflvstxt = new System.Windows.Forms.TextBox();
            this.salcyDrngtxt = new System.Windows.Forms.TextBox();
            this.salcyBdte = new System.Windows.Forms.DateTimePicker();
            this.salcyEdte = new System.Windows.Forms.DateTimePicker();
            this.updtbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.taxtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Setting Details";
            // 
            // SCDRange
            // 
            this.SCDRange.AutoSize = true;
            this.SCDRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCDRange.Location = new System.Drawing.Point(93, 185);
            this.SCDRange.Name = "SCDRange";
            this.SCDRange.Size = new System.Drawing.Size(173, 25);
            this.SCDRange.TabIndex = 3;
            this.SCDRange.Text = "Salary Cycle Days";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(93, 255);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(224, 25);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Salary Cycle Begin Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salary Cycle End Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "No Of Leaves Per Year";
            // 
            // NoOflvstxt
            // 
            this.NoOflvstxt.Location = new System.Drawing.Point(443, 399);
            this.NoOflvstxt.Name = "NoOflvstxt";
            this.NoOflvstxt.Size = new System.Drawing.Size(303, 22);
            this.NoOflvstxt.TabIndex = 20;
            // 
            // salcyDrngtxt
            // 
            this.salcyDrngtxt.Location = new System.Drawing.Point(443, 185);
            this.salcyDrngtxt.Name = "salcyDrngtxt";
            this.salcyDrngtxt.Size = new System.Drawing.Size(303, 22);
            this.salcyDrngtxt.TabIndex = 21;
            // 
            // salcyBdte
            // 
            this.salcyBdte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salcyBdte.Location = new System.Drawing.Point(443, 255);
            this.salcyBdte.Name = "salcyBdte";
            this.salcyBdte.Size = new System.Drawing.Size(303, 26);
            this.salcyBdte.TabIndex = 25;
            // 
            // salcyEdte
            // 
            this.salcyEdte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salcyEdte.Location = new System.Drawing.Point(443, 325);
            this.salcyEdte.Name = "salcyEdte";
            this.salcyEdte.Size = new System.Drawing.Size(303, 26);
            this.salcyEdte.TabIndex = 26;
            // 
            // updtbtn
            // 
            this.updtbtn.BackColor = System.Drawing.Color.White;
            this.updtbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updtbtn.Location = new System.Drawing.Point(645, 528);
            this.updtbtn.Name = "updtbtn";
            this.updtbtn.Size = new System.Drawing.Size(101, 38);
            this.updtbtn.TabIndex = 29;
            this.updtbtn.Text = "Update";
            this.updtbtn.UseVisualStyleBackColor = false;
            this.updtbtn.Click += new System.EventHandler(this.updtbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Goverment Tax";
            // 
            // taxtxt
            // 
            this.taxtxt.Location = new System.Drawing.Point(443, 470);
            this.taxtxt.Name = "taxtxt";
            this.taxtxt.Size = new System.Drawing.Size(303, 22);
            this.taxtxt.TabIndex = 31;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(843, 628);
            this.Controls.Add(this.taxtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updtbtn);
            this.Controls.Add(this.salcyEdte);
            this.Controls.Add(this.salcyBdte);
            this.Controls.Add(this.salcyDrngtxt);
            this.Controls.Add(this.NoOflvstxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.SCDRange);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SCDRange;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NoOflvstxt;
        private System.Windows.Forms.TextBox salcyDrngtxt;
        private System.Windows.Forms.DateTimePicker salcyBdte;
        private System.Windows.Forms.DateTimePicker salcyEdte;
        private System.Windows.Forms.Button updtbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taxtxt;
    }
}