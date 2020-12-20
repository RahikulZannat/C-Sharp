namespace Dairy
{
    partial class Form2
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
            this.Diary = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txteName = new System.Windows.Forms.TextBox();
            this.radioButtonh = new System.Windows.Forms.RadioButton();
            this.radioButtonm = new System.Windows.Forms.RadioButton();
            this.radioButtonl = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Diary.SuspendLayout();
            this.SuspendLayout();
            // 
            // Diary
            // 
            this.Diary.Controls.Add(this.button3);
            this.Diary.Controls.Add(this.button2);
            this.Diary.Controls.Add(this.btnSubmit);
            this.Diary.Controls.Add(this.txtdesc);
            this.Diary.Controls.Add(this.dateTimePicker1);
            this.Diary.Controls.Add(this.radioButtonl);
            this.Diary.Controls.Add(this.radioButtonm);
            this.Diary.Controls.Add(this.radioButtonh);
            this.Diary.Controls.Add(this.txteName);
            this.Diary.Controls.Add(this.label4);
            this.Diary.Controls.Add(this.label3);
            this.Diary.Controls.Add(this.label2);
            this.Diary.Controls.Add(this.label1);
            this.Diary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diary.Location = new System.Drawing.Point(54, 51);
            this.Diary.Name = "Diary";
            this.Diary.Size = new System.Drawing.Size(801, 527);
            this.Diary.TabIndex = 0;
            this.Diary.TabStop = false;
            this.Diary.Text = "Digital Diary";
            this.Diary.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priority";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // txteName
            // 
            this.txteName.Location = new System.Drawing.Point(191, 65);
            this.txteName.Name = "txteName";
            this.txteName.Size = new System.Drawing.Size(238, 28);
            this.txteName.TabIndex = 4;
            // 
            // radioButtonh
            // 
            this.radioButtonh.AutoSize = true;
            this.radioButtonh.Location = new System.Drawing.Point(177, 156);
            this.radioButtonh.Name = "radioButtonh";
            this.radioButtonh.Size = new System.Drawing.Size(71, 28);
            this.radioButtonh.TabIndex = 5;
            this.radioButtonh.TabStop = true;
            this.radioButtonh.Text = "High";
            this.radioButtonh.UseVisualStyleBackColor = true;
            // 
            // radioButtonm
            // 
            this.radioButtonm.AutoSize = true;
            this.radioButtonm.Location = new System.Drawing.Point(271, 155);
            this.radioButtonm.Name = "radioButtonm";
            this.radioButtonm.Size = new System.Drawing.Size(111, 28);
            this.radioButtonm.TabIndex = 6;
            this.radioButtonm.TabStop = true;
            this.radioButtonm.Text = "Moderate";
            this.radioButtonm.UseVisualStyleBackColor = true;
            // 
            // radioButtonl
            // 
            this.radioButtonl.AutoSize = true;
            this.radioButtonl.Location = new System.Drawing.Point(393, 155);
            this.radioButtonl.Name = "radioButtonl";
            this.radioButtonl.Size = new System.Drawing.Size(152, 28);
            this.radioButtonl.TabIndex = 7;
            this.radioButtonl.TabStop = true;
            this.radioButtonl.Text = "Less Important";
            this.radioButtonl.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 233);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 28);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(168, 341);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(423, 156);
            this.txtdesc.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(669, 434);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 63);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Modify";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 31);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 625);
            this.Controls.Add(this.Diary);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Diary.ResumeLayout(false);
            this.Diary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Diary;
        private System.Windows.Forms.RadioButton radioButtonl;
        private System.Windows.Forms.RadioButton radioButtonm;
        private System.Windows.Forms.RadioButton radioButtonh;
        private System.Windows.Forms.TextBox txteName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}