namespace StudentFormDemo
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
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txbStudentID = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.gbMajor = new System.Windows.Forms.GroupBox();
            this.rbProgramming = new System.Windows.Forms.RadioButton();
            this.rbWebDesign = new System.Windows.Forms.RadioButton();
            this.rbIT = new System.Windows.Forms.RadioButton();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.txbScore1 = new System.Windows.Forms.TextBox();
            this.txbScore3 = new System.Windows.Forms.TextBox();
            this.txbScore2 = new System.Windows.Forms.TextBox();
            this.txbScore4 = new System.Windows.Forms.TextBox();
            this.cbxCIS101 = new System.Windows.Forms.CheckBox();
            this.cbxCIS104 = new System.Windows.Forms.CheckBox();
            this.cbxCIS103 = new System.Windows.Forms.CheckBox();
            this.cbxCIS102 = new System.Windows.Forms.CheckBox();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gbMajor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(12, 19);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(58, 13);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID";
            this.lblStudentID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(13, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(13, 72);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txbStudentID
            // 
            this.txbStudentID.Location = new System.Drawing.Point(94, 20);
            this.txbStudentID.Name = "txbStudentID";
            this.txbStudentID.Size = new System.Drawing.Size(186, 20);
            this.txbStudentID.TabIndex = 3;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(94, 46);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(186, 20);
            this.txbFirstName.TabIndex = 4;
            this.txbFirstName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(94, 72);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(186, 20);
            this.txbLastName.TabIndex = 5;
            // 
            // gbMajor
            // 
            this.gbMajor.Controls.Add(this.rbIT);
            this.gbMajor.Controls.Add(this.rbWebDesign);
            this.gbMajor.Controls.Add(this.rbProgramming);
            this.gbMajor.Location = new System.Drawing.Point(16, 107);
            this.gbMajor.Name = "gbMajor";
            this.gbMajor.Size = new System.Drawing.Size(115, 103);
            this.gbMajor.TabIndex = 6;
            this.gbMajor.TabStop = false;
            this.gbMajor.Text = "Major";
            // 
            // rbProgramming
            // 
            this.rbProgramming.AutoSize = true;
            this.rbProgramming.Location = new System.Drawing.Point(6, 20);
            this.rbProgramming.Name = "rbProgramming";
            this.rbProgramming.Size = new System.Drawing.Size(86, 17);
            this.rbProgramming.TabIndex = 0;
            this.rbProgramming.TabStop = true;
            this.rbProgramming.Text = "Programming";
            this.rbProgramming.UseVisualStyleBackColor = true;
            // 
            // rbWebDesign
            // 
            this.rbWebDesign.AutoSize = true;
            this.rbWebDesign.Location = new System.Drawing.Point(6, 43);
            this.rbWebDesign.Name = "rbWebDesign";
            this.rbWebDesign.Size = new System.Drawing.Size(84, 17);
            this.rbWebDesign.TabIndex = 1;
            this.rbWebDesign.TabStop = true;
            this.rbWebDesign.Text = "Web Design";
            this.rbWebDesign.UseVisualStyleBackColor = true;
            this.rbWebDesign.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbIT
            // 
            this.rbIT.AutoSize = true;
            this.rbIT.Location = new System.Drawing.Point(6, 66);
            this.rbIT.Name = "rbIT";
            this.rbIT.Size = new System.Drawing.Size(35, 17);
            this.rbIT.TabIndex = 2;
            this.rbIT.TabStop = true;
            this.rbIT.Text = "IT";
            this.rbIT.UseVisualStyleBackColor = true;
            this.rbIT.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(169, 107);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(45, 13);
            this.lblCourses.TabIndex = 7;
            this.lblCourses.Text = "Courses";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Location = new System.Drawing.Point(326, 107);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(40, 13);
            this.lblScores.TabIndex = 8;
            this.lblScores.Text = "Scores";
            this.lblScores.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbScore1
            // 
            this.txbScore1.Location = new System.Drawing.Point(303, 123);
            this.txbScore1.Name = "txbScore1";
            this.txbScore1.Size = new System.Drawing.Size(100, 20);
            this.txbScore1.TabIndex = 9;
            // 
            // txbScore3
            // 
            this.txbScore3.Location = new System.Drawing.Point(303, 175);
            this.txbScore3.Name = "txbScore3";
            this.txbScore3.Size = new System.Drawing.Size(100, 20);
            this.txbScore3.TabIndex = 10;
            // 
            // txbScore2
            // 
            this.txbScore2.Location = new System.Drawing.Point(303, 149);
            this.txbScore2.Name = "txbScore2";
            this.txbScore2.Size = new System.Drawing.Size(100, 20);
            this.txbScore2.TabIndex = 11;
            // 
            // txbScore4
            // 
            this.txbScore4.Location = new System.Drawing.Point(303, 202);
            this.txbScore4.Name = "txbScore4";
            this.txbScore4.Size = new System.Drawing.Size(100, 20);
            this.txbScore4.TabIndex = 12;
            // 
            // cbxCIS101
            // 
            this.cbxCIS101.AutoSize = true;
            this.cbxCIS101.Location = new System.Drawing.Point(172, 127);
            this.cbxCIS101.Name = "cbxCIS101";
            this.cbxCIS101.Size = new System.Drawing.Size(64, 17);
            this.cbxCIS101.TabIndex = 13;
            this.cbxCIS101.Text = "CIS 101";
            this.cbxCIS101.UseVisualStyleBackColor = true;
            // 
            // cbxCIS104
            // 
            this.cbxCIS104.AutoSize = true;
            this.cbxCIS104.Location = new System.Drawing.Point(172, 204);
            this.cbxCIS104.Name = "cbxCIS104";
            this.cbxCIS104.Size = new System.Drawing.Size(64, 17);
            this.cbxCIS104.TabIndex = 14;
            this.cbxCIS104.Text = "CIS 104";
            this.cbxCIS104.UseVisualStyleBackColor = true;
            // 
            // cbxCIS103
            // 
            this.cbxCIS103.AutoSize = true;
            this.cbxCIS103.Location = new System.Drawing.Point(172, 177);
            this.cbxCIS103.Name = "cbxCIS103";
            this.cbxCIS103.Size = new System.Drawing.Size(64, 17);
            this.cbxCIS103.TabIndex = 15;
            this.cbxCIS103.Text = "CIS 103";
            this.cbxCIS103.UseVisualStyleBackColor = true;
            // 
            // cbxCIS102
            // 
            this.cbxCIS102.AutoSize = true;
            this.cbxCIS102.Location = new System.Drawing.Point(172, 154);
            this.cbxCIS102.Name = "cbxCIS102";
            this.cbxCIS102.Size = new System.Drawing.Size(64, 17);
            this.cbxCIS102.TabIndex = 16;
            this.cbxCIS102.Text = "CIS 102";
            this.cbxCIS102.UseVisualStyleBackColor = true;
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(37, 357);
            this.txbResult.Multiline = true;
            this.txbResult.Name = "txbResult";
            this.txbResult.ReadOnly = true;
            this.txbResult.Size = new System.Drawing.Size(329, 123);
            this.txbResult.TabIndex = 17;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Image = global::StudentFormDemo.Properties.Resources.Button_Submit1;
            this.btnSubmit.Location = new System.Drawing.Point(82, 246);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(226, 90);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(143, 497);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Visit Our School";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 538);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.cbxCIS102);
            this.Controls.Add(this.cbxCIS103);
            this.Controls.Add(this.cbxCIS104);
            this.Controls.Add(this.cbxCIS101);
            this.Controls.Add(this.txbScore4);
            this.Controls.Add(this.txbScore2);
            this.Controls.Add(this.txbScore3);
            this.Controls.Add(this.txbScore1);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.gbMajor);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.txbStudentID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStudentID);
            this.Name = "Form1";
            this.Text = "Student Infomation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMajor.ResumeLayout(false);
            this.gbMajor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txbStudentID;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.GroupBox gbMajor;
        private System.Windows.Forms.RadioButton rbIT;
        private System.Windows.Forms.RadioButton rbWebDesign;
        private System.Windows.Forms.RadioButton rbProgramming;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.TextBox txbScore1;
        private System.Windows.Forms.TextBox txbScore3;
        private System.Windows.Forms.TextBox txbScore2;
        private System.Windows.Forms.TextBox txbScore4;
        private System.Windows.Forms.CheckBox cbxCIS101;
        private System.Windows.Forms.CheckBox cbxCIS104;
        private System.Windows.Forms.CheckBox cbxCIS103;
        private System.Windows.Forms.CheckBox cbxCIS102;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.PictureBox btnSubmit;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

