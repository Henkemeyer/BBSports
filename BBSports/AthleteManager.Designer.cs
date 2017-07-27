namespace BBSports
{
    partial class AthleteManager
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
            this.bDirectory = new System.Windows.Forms.Button();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lState = new System.Windows.Forms.Label();
            this.lCity = new System.Windows.Forms.Label();
            this.mtbBirthday = new System.Windows.Forms.MaskedTextBox();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.lGrade = new System.Windows.Forms.Label();
            this.bRecruit = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.lAssign = new System.Windows.Forms.Label();
            this.clbTeams = new System.Windows.Forms.CheckedListBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.tbMiddle = new System.Windows.Forms.TextBox();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.lBirthday = new System.Windows.Forms.Label();
            this.lNickname = new System.Windows.Forms.Label();
            this.lLast = new System.Windows.Forms.Label();
            this.lMiddle = new System.Windows.Forms.Label();
            this.lFirst = new System.Windows.Forms.Label();
            this.lHeader = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cxbDirector = new System.Windows.Forms.CheckBox();
            this.lPhone = new System.Windows.Forms.Label();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.lReq = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDirectory
            // 
            this.bDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDirectory.Location = new System.Drawing.Point(1009, 33);
            this.bDirectory.Name = "bDirectory";
            this.bDirectory.Size = new System.Drawing.Size(159, 48);
            this.bDirectory.TabIndex = 131;
            this.bDirectory.Text = "Directory";
            this.bDirectory.UseVisualStyleBackColor = true;
            this.bDirectory.Click += new System.EventHandler(this.Directory_Click);
            // 
            // tbState
            // 
            this.tbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbState.Location = new System.Drawing.Point(683, 260);
            this.tbState.MaxLength = 2;
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(55, 32);
            this.tbState.TabIndex = 130;
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(254, 260);
            this.tbCity.MaxLength = 50;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(361, 32);
            this.tbCity.TabIndex = 129;
            // 
            // lState
            // 
            this.lState.AutoSize = true;
            this.lState.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lState.Location = new System.Drawing.Point(678, 218);
            this.lState.Name = "lState";
            this.lState.Size = new System.Drawing.Size(63, 26);
            this.lState.TabIndex = 128;
            this.lState.Text = "State";
            // 
            // lCity
            // 
            this.lCity.AutoSize = true;
            this.lCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCity.Location = new System.Drawing.Point(249, 218);
            this.lCity.Name = "lCity";
            this.lCity.Size = new System.Drawing.Size(50, 26);
            this.lCity.TabIndex = 127;
            this.lCity.Text = "City";
            // 
            // mtbBirthday
            // 
            this.mtbBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbBirthday.Location = new System.Drawing.Point(49, 260);
            this.mtbBirthday.Mask = "00/00/0000";
            this.mtbBirthday.Name = "mtbBirthday";
            this.mtbBirthday.Size = new System.Drawing.Size(137, 32);
            this.mtbBirthday.TabIndex = 126;
            this.mtbBirthday.ValidatingType = typeof(System.DateTime);
            // 
            // cbGrade
            // 
            this.cbGrade.AutoCompleteCustomSource.AddRange(new string[] {
            "Freshman",
            "Sophmore",
            "Junior",
            "Senior",
            "Super-Senior",
            "Alumni",
            "Ninth",
            "Tenth",
            "Eleventh",
            "Twelfth",
            "First",
            "Second",
            "Third",
            "Fourth",
            "Fifth",
            "Sixth",
            "Seventh",
            "Eighth"});
            this.cbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Location = new System.Drawing.Point(848, 260);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(338, 34);
            this.cbGrade.TabIndex = 116;
            // 
            // lGrade
            // 
            this.lGrade.AutoSize = true;
            this.lGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGrade.Location = new System.Drawing.Point(843, 218);
            this.lGrade.Name = "lGrade";
            this.lGrade.Size = new System.Drawing.Size(72, 26);
            this.lGrade.TabIndex = 118;
            this.lGrade.Text = "Grade";
            // 
            // bRecruit
            // 
            this.bRecruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRecruit.Location = new System.Drawing.Point(1114, 795);
            this.bRecruit.Name = "bRecruit";
            this.bRecruit.Size = new System.Drawing.Size(106, 40);
            this.bRecruit.TabIndex = 115;
            this.bRecruit.Text = "Recruit";
            this.bRecruit.UseVisualStyleBackColor = true;
            this.bRecruit.Click += new System.EventHandler(this.Recruit_Click);
            // 
            // bClear
            // 
            this.bClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(769, 795);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(113, 40);
            this.bClear.TabIndex = 117;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // lAssign
            // 
            this.lAssign.AutoSize = true;
            this.lAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAssign.Location = new System.Drawing.Point(44, 348);
            this.lAssign.Name = "lAssign";
            this.lAssign.Size = new System.Drawing.Size(189, 26);
            this.lAssign.TabIndex = 119;
            this.lAssign.Text = "Assign To Teams*";
            // 
            // clbTeams
            // 
            this.clbTeams.CheckOnClick = true;
            this.clbTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbTeams.FormattingEnabled = true;
            this.clbTeams.Location = new System.Drawing.Point(47, 406);
            this.clbTeams.Name = "clbTeams";
            this.clbTeams.Size = new System.Drawing.Size(535, 274);
            this.clbTeams.TabIndex = 114;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.Location = new System.Drawing.Point(683, 348);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(265, 136);
            this.gbGender.TabIndex = 112;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender*";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(29, 87);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(80, 30);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Checked = true;
            this.rbFemale.Location = new System.Drawing.Point(29, 38);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(106, 30);
            this.rbFemale.TabIndex = 6;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.Gender_CheckedChanged);
            // 
            // tbMiddle
            // 
            this.tbMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMiddle.Location = new System.Drawing.Point(490, 144);
            this.tbMiddle.Name = "tbMiddle";
            this.tbMiddle.Size = new System.Drawing.Size(318, 32);
            this.tbMiddle.TabIndex = 109;
            // 
            // tbLast
            // 
            this.tbLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLast.Location = new System.Drawing.Point(848, 140);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(342, 32);
            this.tbLast.TabIndex = 110;
            // 
            // tbNickname
            // 
            this.tbNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNickname.Location = new System.Drawing.Point(1230, 140);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(261, 32);
            this.tbNickname.TabIndex = 111;
            // 
            // tbFirst
            // 
            this.tbFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirst.Location = new System.Drawing.Point(51, 144);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(396, 32);
            this.tbFirst.TabIndex = 108;
            // 
            // lBirthday
            // 
            this.lBirthday.AutoSize = true;
            this.lBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBirthday.Location = new System.Drawing.Point(46, 218);
            this.lBirthday.Name = "lBirthday";
            this.lBirthday.Size = new System.Drawing.Size(92, 26);
            this.lBirthday.TabIndex = 124;
            this.lBirthday.Text = "Birthday";
            // 
            // lNickname
            // 
            this.lNickname.AutoSize = true;
            this.lNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNickname.Location = new System.Drawing.Point(1225, 100);
            this.lNickname.Name = "lNickname";
            this.lNickname.Size = new System.Drawing.Size(110, 26);
            this.lNickname.TabIndex = 125;
            this.lNickname.Text = "Nickname";
            // 
            // lLast
            // 
            this.lLast.AutoSize = true;
            this.lLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLast.Location = new System.Drawing.Point(843, 100);
            this.lLast.Name = "lLast";
            this.lLast.Size = new System.Drawing.Size(62, 26);
            this.lLast.TabIndex = 122;
            this.lLast.Text = "Last*";
            // 
            // lMiddle
            // 
            this.lMiddle.AutoSize = true;
            this.lMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMiddle.Location = new System.Drawing.Point(485, 100);
            this.lMiddle.Name = "lMiddle";
            this.lMiddle.Size = new System.Drawing.Size(76, 26);
            this.lMiddle.TabIndex = 121;
            this.lMiddle.Text = "Middle";
            // 
            // lFirst
            // 
            this.lFirst.AutoSize = true;
            this.lFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFirst.Location = new System.Drawing.Point(46, 100);
            this.lFirst.Name = "lFirst";
            this.lFirst.Size = new System.Drawing.Size(63, 26);
            this.lFirst.TabIndex = 120;
            this.lFirst.Text = "First*";
            // 
            // lHeader
            // 
            this.lHeader.AutoSize = true;
            this.lHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeader.Location = new System.Drawing.Point(45, 39);
            this.lHeader.Name = "lHeader";
            this.lHeader.Size = new System.Drawing.Size(161, 31);
            this.lHeader.TabIndex = 107;
            this.lHeader.Text = "New Athlete";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(678, 521);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(157, 26);
            this.lEmail.TabIndex = 132;
            this.lEmail.Text = "Athlete E-Mail*";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(848, 518);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(451, 32);
            this.tbEmail.TabIndex = 133;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.Email_Validating);
            // 
            // cxbDirector
            // 
            this.cxbDirector.AutoSize = true;
            this.cxbDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxbDirector.Location = new System.Drawing.Point(1009, 406);
            this.cxbDirector.Name = "cxbDirector";
            this.cxbDirector.Size = new System.Drawing.Size(169, 30);
            this.cxbDirector.TabIndex = 134;
            this.cxbDirector.Text = "Make Director";
            this.cxbDirector.UseVisualStyleBackColor = true;
            this.cxbDirector.Visible = false;
            this.cxbDirector.CheckedChanged += new System.EventHandler(this.Director_CheckedChanged);
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPhone.Location = new System.Drawing.Point(1225, 348);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(93, 26);
            this.lPhone.TabIndex = 135;
            this.lPhone.Text = "Phone #";
            // 
            // mtbPhone
            // 
            this.mtbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPhone.Location = new System.Drawing.Point(1230, 406);
            this.mtbPhone.Mask = "(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(267, 32);
            this.mtbPhone.TabIndex = 136;
            // 
            // lReq
            // 
            this.lReq.AutoSize = true;
            this.lReq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lReq.ForeColor = System.Drawing.Color.Red;
            this.lReq.Location = new System.Drawing.Point(95, 795);
            this.lReq.Name = "lReq";
            this.lReq.Size = new System.Drawing.Size(77, 19);
            this.lReq.TabIndex = 138;
            this.lReq.Text = "* Required";
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(688, 637);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(61, 26);
            this.lTitle.TabIndex = 140;
            this.lTitle.Text = "Title*";
            this.lTitle.Visible = false;
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(848, 634);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(451, 32);
            this.tbTitle.TabIndex = 141;
            this.tbTitle.Visible = false;
            // 
            // AthleteManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1797, 882);
            this.ControlBox = false;
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.lReq);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.lPhone);
            this.Controls.Add(this.cxbDirector);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.bDirectory);
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.lState);
            this.Controls.Add(this.lCity);
            this.Controls.Add(this.mtbBirthday);
            this.Controls.Add(this.cbGrade);
            this.Controls.Add(this.lGrade);
            this.Controls.Add(this.bRecruit);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.lAssign);
            this.Controls.Add(this.clbTeams);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.tbMiddle);
            this.Controls.Add(this.tbLast);
            this.Controls.Add(this.tbNickname);
            this.Controls.Add(this.tbFirst);
            this.Controls.Add(this.lBirthday);
            this.Controls.Add(this.lNickname);
            this.Controls.Add(this.lLast);
            this.Controls.Add(this.lMiddle);
            this.Controls.Add(this.lFirst);
            this.Controls.Add(this.lHeader);
            this.Name = "AthleteManager";
            this.Text = "Manage Athletes";
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bDirectory;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lState;
        private System.Windows.Forms.Label lCity;
        private System.Windows.Forms.MaskedTextBox mtbBirthday;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.Label lGrade;
        private System.Windows.Forms.Button bRecruit;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label lAssign;
        private System.Windows.Forms.CheckedListBox clbTeams;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.TextBox tbMiddle;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.Label lBirthday;
        private System.Windows.Forms.Label lNickname;
        private System.Windows.Forms.Label lLast;
        private System.Windows.Forms.Label lMiddle;
        private System.Windows.Forms.Label lFirst;
        private System.Windows.Forms.Label lHeader;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.CheckBox cxbDirector;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Label lReq;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.TextBox tbTitle;
    }
}