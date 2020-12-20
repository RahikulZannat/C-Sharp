namespace Dairy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.leName = new System.Windows.Forms.Label();
            this.lpriority = new System.Windows.Forms.Label();
            this.ldate = new System.Windows.Forms.Label();
            this.ldesc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ldesc);
            this.groupBox1.Controls.Add(this.ldate);
            this.groupBox1.Controls.Add(this.lpriority);
            this.groupBox1.Controls.Add(this.leName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 534);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Home";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priority";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // leName
            // 
            this.leName.AutoSize = true;
            this.leName.BackColor = System.Drawing.SystemColors.Control;
            this.leName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leName.Location = new System.Drawing.Point(235, 78);
            this.leName.Name = "leName";
            this.leName.Size = new System.Drawing.Size(99, 25);
            this.leName.TabIndex = 4;
            this.leName.Text = "<eName>";
            // 
            // lpriority
            // 
            this.lpriority.AutoSize = true;
            this.lpriority.BackColor = System.Drawing.SystemColors.Control;
            this.lpriority.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lpriority.Location = new System.Drawing.Point(235, 144);
            this.lpriority.Name = "lpriority";
            this.lpriority.Size = new System.Drawing.Size(93, 25);
            this.lpriority.TabIndex = 5;
            this.lpriority.Text = "<priority>";
            // 
            // ldate
            // 
            this.ldate.AutoSize = true;
            this.ldate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ldate.Location = new System.Drawing.Point(235, 207);
            this.ldate.Name = "ldate";
            this.ldate.Size = new System.Drawing.Size(74, 25);
            this.ldate.TabIndex = 6;
            this.ldate.Text = "<date>";
            // 
            // ldesc
            // 
            this.ldesc.AutoSize = true;
            this.ldesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ldesc.Location = new System.Drawing.Point(235, 272);
            this.ldesc.Name = "ldesc";
            this.ldesc.Size = new System.Drawing.Size(78, 25);
            this.ldesc.TabIndex = 7;
            this.ldesc.Text = "<desc>";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(819, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 621);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label ldesc;
        public System.Windows.Forms.Label ldate;
        public System.Windows.Forms.Label lpriority;
        public System.Windows.Forms.Label leName;
    }
}