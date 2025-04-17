namespace Health_Club
{
    partial class frmain
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
            this.radAdult = new System.Windows.Forms.RadioButton();
            this.radChild = new System.Windows.Forms.RadioButton();
            this.radStudent = new System.Windows.Forms.RadioButton();
            this.radSenior = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkYoga = new System.Windows.Forms.CheckBox();
            this.chkKarate = new System.Windows.Forms.CheckBox();
            this.chkTrainer = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.lblMonthlyFee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radAdult);
            this.groupBox1.Controls.Add(this.radChild);
            this.groupBox1.Controls.Add(this.radStudent);
            this.groupBox1.Controls.Add(this.radSenior);
            this.groupBox1.Location = new System.Drawing.Point(67, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Membership";
            // 
            // radAdult
            // 
            this.radAdult.AutoSize = true;
            this.radAdult.Location = new System.Drawing.Point(33, 32);
            this.radAdult.Name = "radAdult";
            this.radAdult.Size = new System.Drawing.Size(95, 17);
            this.radAdult.TabIndex = 3;
            this.radAdult.TabStop = true;
            this.radAdult.Text = "Standard &Adult";
            this.radAdult.UseVisualStyleBackColor = true;
            // 
            // radChild
            // 
            this.radChild.AutoSize = true;
            this.radChild.Location = new System.Drawing.Point(33, 55);
            this.radChild.Name = "radChild";
            this.radChild.Size = new System.Drawing.Size(108, 17);
            this.radChild.TabIndex = 4;
            this.radChild.TabStop = true;
            this.radChild.Text = "Chil&d (12 && under)";
            this.radChild.UseVisualStyleBackColor = true;
            // 
            // radStudent
            // 
            this.radStudent.AutoSize = true;
            this.radStudent.Location = new System.Drawing.Point(33, 78);
            this.radStudent.Name = "radStudent";
            this.radStudent.Size = new System.Drawing.Size(62, 17);
            this.radStudent.TabIndex = 5;
            this.radStudent.TabStop = true;
            this.radStudent.Text = "&Student";
            this.radStudent.UseVisualStyleBackColor = true;
            // 
            // radSenior
            // 
            this.radSenior.AutoSize = true;
            this.radSenior.Location = new System.Drawing.Point(33, 101);
            this.radSenior.Name = "radSenior";
            this.radSenior.Size = new System.Drawing.Size(89, 17);
            this.radSenior.TabIndex = 6;
            this.radSenior.TabStop = true;
            this.radSenior.Text = "S&enior Citizen";
            this.radSenior.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkYoga);
            this.groupBox2.Controls.Add(this.chkKarate);
            this.groupBox2.Controls.Add(this.chkTrainer);
            this.groupBox2.Location = new System.Drawing.Point(482, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 132);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // chkYoga
            // 
            this.chkYoga.AutoSize = true;
            this.chkYoga.Location = new System.Drawing.Point(47, 33);
            this.chkYoga.Name = "chkYoga";
            this.chkYoga.Size = new System.Drawing.Size(51, 17);
            this.chkYoga.TabIndex = 3;
            this.chkYoga.Text = "&Yoga";
            this.chkYoga.UseVisualStyleBackColor = true;
            // 
            // chkKarate
            // 
            this.chkKarate.AutoSize = true;
            this.chkKarate.Location = new System.Drawing.Point(47, 55);
            this.chkKarate.Name = "chkKarate";
            this.chkKarate.Size = new System.Drawing.Size(57, 17);
            this.chkKarate.TabIndex = 4;
            this.chkKarate.Text = "&Karate";
            this.chkKarate.UseVisualStyleBackColor = true;
            // 
            // chkTrainer
            // 
            this.chkTrainer.AutoSize = true;
            this.chkTrainer.Location = new System.Drawing.Point(47, 79);
            this.chkTrainer.Name = "chkTrainer";
            this.chkTrainer.Size = new System.Drawing.Size(103, 17);
            this.chkTrainer.TabIndex = 5;
            this.chkTrainer.Text = "&Personal Trainer";
            this.chkTrainer.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMonths);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(67, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Membership Length";
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(33, 61);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(100, 20);
            this.txtMonths.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter the Number of Months:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTotalFee);
            this.groupBox4.Controls.Add(this.lblMonthlyFee);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(482, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Membership Fees";
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotalFee.Location = new System.Drawing.Point(125, 68);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(58, 13);
            this.lblTotalFee.TabIndex = 11;
            this.lblTotalFee.Text = "                 ";
            // 
            // lblMonthlyFee
            // 
            this.lblMonthlyFee.AutoSize = true;
            this.lblMonthlyFee.BackColor = System.Drawing.SystemColors.Window;
            this.lblMonthlyFee.Location = new System.Drawing.Point(125, 34);
            this.lblMonthlyFee.Name = "lblMonthlyFee";
            this.lblMonthlyFee.Size = new System.Drawing.Size(58, 13);
            this.lblMonthlyFee.TabIndex = 10;
            this.lblMonthlyFee.Text = "                 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Monthly Fee:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(164, 385);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(347, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(518, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Membership Fee Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radAdult;
        private System.Windows.Forms.RadioButton radChild;
        private System.Windows.Forms.RadioButton radStudent;
        private System.Windows.Forms.RadioButton radSenior;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkYoga;
        private System.Windows.Forms.CheckBox chkKarate;
        private System.Windows.Forms.CheckBox chkTrainer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.Label lblMonthlyFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

