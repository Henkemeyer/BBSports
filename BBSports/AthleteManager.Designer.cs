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
            this.scAthletes = new System.Windows.Forms.SplitContainer();
            this.clbSTeams = new System.Windows.Forms.CheckedListBox();
            this.clbSGrades = new System.Windows.Forms.CheckedListBox();
            this.lSearch = new System.Windows.Forms.Label();
            this.bSearch = new System.Windows.Forms.Button();
            this.gbSGender = new System.Windows.Forms.GroupBox();
            this.rbSAll = new System.Windows.Forms.RadioButton();
            this.rbSMale = new System.Windows.Forms.RadioButton();
            this.rbSFemale = new System.Windows.Forms.RadioButton();
            this.dgAthletes = new System.Windows.Forms.DataGridView();
            this.Athlete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.lGrade = new System.Windows.Forms.Label();
            this.bSubmit = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.lAssign = new System.Windows.Forms.Label();
            this.clbTeams = new System.Windows.Forms.CheckedListBox();
            this.richTBNotes = new System.Windows.Forms.RichTextBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.dateTPBirthday = new System.Windows.Forms.DateTimePicker();
            this.tbMiddle = new System.Windows.Forms.TextBox();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.lNotes = new System.Windows.Forms.Label();
            this.lBirthday = new System.Windows.Forms.Label();
            this.lNickname = new System.Windows.Forms.Label();
            this.lLast = new System.Windows.Forms.Label();
            this.lMiddle = new System.Windows.Forms.Label();
            this.lFirst = new System.Windows.Forms.Label();
            this.lHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scAthletes)).BeginInit();
            this.scAthletes.Panel1.SuspendLayout();
            this.scAthletes.Panel2.SuspendLayout();
            this.scAthletes.SuspendLayout();
            this.gbSGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAthletes)).BeginInit();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // scAthletes
            // 
            this.scAthletes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scAthletes.Location = new System.Drawing.Point(0, 0);
            this.scAthletes.Name = "scAthletes";
            // 
            // scAthletes.Panel1
            // 
            this.scAthletes.Panel1.AutoScroll = true;
            this.scAthletes.Panel1.Controls.Add(this.clbSTeams);
            this.scAthletes.Panel1.Controls.Add(this.clbSGrades);
            this.scAthletes.Panel1.Controls.Add(this.lSearch);
            this.scAthletes.Panel1.Controls.Add(this.bSearch);
            this.scAthletes.Panel1.Controls.Add(this.gbSGender);
            this.scAthletes.Panel1.Controls.Add(this.dgAthletes);
            // 
            // scAthletes.Panel2
            // 
            this.scAthletes.Panel2.AutoScroll = true;
            this.scAthletes.Panel2.Controls.Add(this.label1);
            this.scAthletes.Panel2.Controls.Add(this.cbGrade);
            this.scAthletes.Panel2.Controls.Add(this.lGrade);
            this.scAthletes.Panel2.Controls.Add(this.bSubmit);
            this.scAthletes.Panel2.Controls.Add(this.bClear);
            this.scAthletes.Panel2.Controls.Add(this.lAssign);
            this.scAthletes.Panel2.Controls.Add(this.clbTeams);
            this.scAthletes.Panel2.Controls.Add(this.richTBNotes);
            this.scAthletes.Panel2.Controls.Add(this.gbGender);
            this.scAthletes.Panel2.Controls.Add(this.dateTPBirthday);
            this.scAthletes.Panel2.Controls.Add(this.tbMiddle);
            this.scAthletes.Panel2.Controls.Add(this.tbLast);
            this.scAthletes.Panel2.Controls.Add(this.tbNickname);
            this.scAthletes.Panel2.Controls.Add(this.tbFirst);
            this.scAthletes.Panel2.Controls.Add(this.lNotes);
            this.scAthletes.Panel2.Controls.Add(this.lBirthday);
            this.scAthletes.Panel2.Controls.Add(this.lNickname);
            this.scAthletes.Panel2.Controls.Add(this.lLast);
            this.scAthletes.Panel2.Controls.Add(this.lMiddle);
            this.scAthletes.Panel2.Controls.Add(this.lFirst);
            this.scAthletes.Panel2.Controls.Add(this.lHeader);
            this.scAthletes.Size = new System.Drawing.Size(1797, 882);
            this.scAthletes.SplitterDistance = 721;
            this.scAthletes.TabIndex = 0;
            this.scAthletes.TabStop = false;
            // 
            // clbSTeams
            // 
            this.clbSTeams.CheckOnClick = true;
            this.clbSTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbSTeams.FormattingEnabled = true;
            this.clbSTeams.Location = new System.Drawing.Point(210, 699);
            this.clbSTeams.Name = "clbSTeams";
            this.clbSTeams.Size = new System.Drawing.Size(170, 156);
            this.clbSTeams.TabIndex = 6;
            // 
            // clbSGrades
            // 
            this.clbSGrades.CheckOnClick = true;
            this.clbSGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbSGrades.FormattingEnabled = true;
            this.clbSGrades.Location = new System.Drawing.Point(22, 699);
            this.clbSGrades.Name = "clbSGrades";
            this.clbSGrades.Size = new System.Drawing.Size(152, 156);
            this.clbSGrades.TabIndex = 5;
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSearch.Location = new System.Drawing.Point(27, 653);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(75, 25);
            this.lSearch.TabIndex = 4;
            this.lSearch.Text = "Search";
            // 
            // bSearch
            // 
            this.bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearch.Image = global::BBSports.Properties.Resources.Magnify;
            this.bSearch.Location = new System.Drawing.Point(630, 789);
            this.bSearch.MinimumSize = new System.Drawing.Size(50, 50);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(57, 55);
            this.bSearch.TabIndex = 2;
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // gbSGender
            // 
            this.gbSGender.Controls.Add(this.rbSAll);
            this.gbSGender.Controls.Add(this.rbSMale);
            this.gbSGender.Controls.Add(this.rbSFemale);
            this.gbSGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSGender.Location = new System.Drawing.Point(420, 653);
            this.gbSGender.Name = "gbSGender";
            this.gbSGender.Size = new System.Drawing.Size(264, 109);
            this.gbSGender.TabIndex = 1;
            this.gbSGender.TabStop = false;
            this.gbSGender.Text = "Gender";
            // 
            // rbSAll
            // 
            this.rbSAll.AutoSize = true;
            this.rbSAll.Checked = true;
            this.rbSAll.Location = new System.Drawing.Point(111, 71);
            this.rbSAll.Name = "rbSAll";
            this.rbSAll.Size = new System.Drawing.Size(65, 24);
            this.rbSAll.TabIndex = 2;
            this.rbSAll.TabStop = true;
            this.rbSAll.Text = "Both";
            this.rbSAll.UseVisualStyleBackColor = true;
            this.rbSAll.CheckedChanged += new System.EventHandler(this.SGender_CheckedChanged);
            // 
            // rbSMale
            // 
            this.rbSMale.AutoSize = true;
            this.rbSMale.Location = new System.Drawing.Point(167, 41);
            this.rbSMale.Name = "rbSMale";
            this.rbSMale.Size = new System.Drawing.Size(66, 24);
            this.rbSMale.TabIndex = 1;
            this.rbSMale.Text = "Male";
            this.rbSMale.UseVisualStyleBackColor = true;
            this.rbSMale.CheckedChanged += new System.EventHandler(this.SGender_CheckedChanged);
            // 
            // rbSFemale
            // 
            this.rbSFemale.AutoSize = true;
            this.rbSFemale.Location = new System.Drawing.Point(28, 41);
            this.rbSFemale.Name = "rbSFemale";
            this.rbSFemale.Size = new System.Drawing.Size(85, 24);
            this.rbSFemale.TabIndex = 0;
            this.rbSFemale.Text = "Female";
            this.rbSFemale.UseVisualStyleBackColor = true;
            this.rbSFemale.CheckedChanged += new System.EventHandler(this.SGender_CheckedChanged);
            // 
            // dgAthletes
            // 
            this.dgAthletes.AllowUserToAddRows = false;
            this.dgAthletes.AllowUserToDeleteRows = false;
            this.dgAthletes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAthletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAthletes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Athlete,
            this.FullName,
            this.Gender,
            this.Grade,
            this.Birthday});
            this.dgAthletes.Location = new System.Drawing.Point(0, 0);
            this.dgAthletes.MultiSelect = false;
            this.dgAthletes.Name = "dgAthletes";
            this.dgAthletes.ReadOnly = true;
            this.dgAthletes.RowTemplate.Height = 24;
            this.dgAthletes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAthletes.Size = new System.Drawing.Size(718, 628);
            this.dgAthletes.TabIndex = 0;
            this.dgAthletes.DoubleClick += new System.EventHandler(this.Athletes_DoubleClick);
            // 
            // Athlete
            // 
            this.Athlete.DataPropertyName = "AthleteId";
            this.Athlete.HeaderText = "Athlete Id";
            this.Athlete.Name = "Athlete";
            this.Athlete.ReadOnly = true;
            this.Athlete.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Name";
            this.FullName.MinimumWidth = 50;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 200;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grade";
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1052, 853);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 100;
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
            this.cbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Items.AddRange(new object[] {
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
            this.cbGrade.Location = new System.Drawing.Point(498, 475);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(329, 28);
            this.cbGrade.TabIndex = 10;
            // 
            // lGrade
            // 
            this.lGrade.AutoSize = true;
            this.lGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGrade.Location = new System.Drawing.Point(494, 444);
            this.lGrade.Name = "lGrade";
            this.lGrade.Size = new System.Drawing.Size(55, 20);
            this.lGrade.TabIndex = 99;
            this.lGrade.Text = "Grade";
            // 
            // bSubmit
            // 
            this.bSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubmit.Location = new System.Drawing.Point(737, 775);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(90, 40);
            this.bSubmit.TabIndex = 10;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // bClear
            // 
            this.bClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(591, 775);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(90, 40);
            this.bClear.TabIndex = 11;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // lAssign
            // 
            this.lAssign.AutoSize = true;
            this.lAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAssign.Location = new System.Drawing.Point(53, 444);
            this.lAssign.Name = "lAssign";
            this.lAssign.Size = new System.Drawing.Size(146, 20);
            this.lAssign.TabIndex = 99;
            this.lAssign.Text = "Assign To Teams*";
            // 
            // clbTeams
            // 
            this.clbTeams.CheckOnClick = true;
            this.clbTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbTeams.FormattingEnabled = true;
            this.clbTeams.Location = new System.Drawing.Point(56, 475);
            this.clbTeams.Name = "clbTeams";
            this.clbTeams.Size = new System.Drawing.Size(369, 340);
            this.clbTeams.TabIndex = 9;
            // 
            // richTBNotes
            // 
            this.richTBNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTBNotes.Location = new System.Drawing.Point(56, 315);
            this.richTBNotes.Name = "richTBNotes";
            this.richTBNotes.Size = new System.Drawing.Size(771, 104);
            this.richTBNotes.TabIndex = 8;
            this.richTBNotes.Text = "";
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.Location = new System.Drawing.Point(446, 172);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(381, 77);
            this.gbGender.TabIndex = 6;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender*";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(240, 38);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(66, 24);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Checked = true;
            this.rbFemale.Location = new System.Drawing.Point(18, 37);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(85, 24);
            this.rbFemale.TabIndex = 6;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.Gender_CheckedChanged);
            // 
            // dateTPBirthday
            // 
            this.dateTPBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTPBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPBirthday.Location = new System.Drawing.Point(56, 209);
            this.dateTPBirthday.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dateTPBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTPBirthday.Name = "dateTPBirthday";
            this.dateTPBirthday.Size = new System.Drawing.Size(275, 26);
            this.dateTPBirthday.TabIndex = 5;
            // 
            // tbMiddle
            // 
            this.tbMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMiddle.Location = new System.Drawing.Point(288, 114);
            this.tbMiddle.Name = "tbMiddle";
            this.tbMiddle.Size = new System.Drawing.Size(137, 26);
            this.tbMiddle.TabIndex = 2;
            // 
            // tbLast
            // 
            this.tbLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLast.Location = new System.Drawing.Point(446, 114);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(217, 26);
            this.tbLast.TabIndex = 3;
            // 
            // tbNickname
            // 
            this.tbNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNickname.Location = new System.Drawing.Point(682, 114);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(145, 26);
            this.tbNickname.TabIndex = 4;
            // 
            // tbFirst
            // 
            this.tbFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirst.Location = new System.Drawing.Point(54, 114);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(213, 26);
            this.tbFirst.TabIndex = 1;
            // 
            // lNotes
            // 
            this.lNotes.AutoSize = true;
            this.lNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNotes.Location = new System.Drawing.Point(52, 283);
            this.lNotes.Name = "lNotes";
            this.lNotes.Size = new System.Drawing.Size(53, 20);
            this.lNotes.TabIndex = 99;
            this.lNotes.Text = "Notes";
            // 
            // lBirthday
            // 
            this.lBirthday.AutoSize = true;
            this.lBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBirthday.Location = new System.Drawing.Point(52, 172);
            this.lBirthday.Name = "lBirthday";
            this.lBirthday.Size = new System.Drawing.Size(71, 20);
            this.lBirthday.TabIndex = 99;
            this.lBirthday.Text = "Birthday";
            // 
            // lNickname
            // 
            this.lNickname.AutoSize = true;
            this.lNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNickname.Location = new System.Drawing.Point(678, 81);
            this.lNickname.Name = "lNickname";
            this.lNickname.Size = new System.Drawing.Size(83, 20);
            this.lNickname.TabIndex = 99;
            this.lNickname.Text = "Nickname";
            // 
            // lLast
            // 
            this.lLast.AutoSize = true;
            this.lLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLast.Location = new System.Drawing.Point(442, 81);
            this.lLast.Name = "lLast";
            this.lLast.Size = new System.Drawing.Size(48, 20);
            this.lLast.TabIndex = 99;
            this.lLast.Text = "Last*";
            // 
            // lMiddle
            // 
            this.lMiddle.AutoSize = true;
            this.lMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMiddle.Location = new System.Drawing.Point(284, 81);
            this.lMiddle.Name = "lMiddle";
            this.lMiddle.Size = new System.Drawing.Size(58, 20);
            this.lMiddle.TabIndex = 99;
            this.lMiddle.Text = "Middle";
            // 
            // lFirst
            // 
            this.lFirst.AutoSize = true;
            this.lFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFirst.Location = new System.Drawing.Point(50, 81);
            this.lFirst.Name = "lFirst";
            this.lFirst.Size = new System.Drawing.Size(49, 20);
            this.lFirst.TabIndex = 99;
            this.lFirst.Text = "First*";
            // 
            // lHeader
            // 
            this.lHeader.AutoSize = true;
            this.lHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeader.Location = new System.Drawing.Point(50, 26);
            this.lHeader.Name = "lHeader";
            this.lHeader.Size = new System.Drawing.Size(161, 31);
            this.lHeader.TabIndex = 0;
            this.lHeader.Text = "New Athlete";
            // 
            // AthleteManager
            // 
            this.AcceptButton = this.bSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bClear;
            this.ClientSize = new System.Drawing.Size(1797, 882);
            this.ControlBox = false;
            this.Controls.Add(this.scAthletes);
            this.Name = "AthleteManager";
            this.Text = "Manage Athletes";
            this.scAthletes.Panel1.ResumeLayout(false);
            this.scAthletes.Panel1.PerformLayout();
            this.scAthletes.Panel2.ResumeLayout(false);
            this.scAthletes.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scAthletes)).EndInit();
            this.scAthletes.ResumeLayout(false);
            this.gbSGender.ResumeLayout(false);
            this.gbSGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAthletes)).EndInit();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scAthletes;
        private System.Windows.Forms.DataGridView dgAthletes;
        private System.Windows.Forms.Label lNotes;
        private System.Windows.Forms.Label lBirthday;
        private System.Windows.Forms.Label lNickname;
        private System.Windows.Forms.Label lLast;
        private System.Windows.Forms.Label lMiddle;
        private System.Windows.Forms.Label lFirst;
        private System.Windows.Forms.Label lHeader;
        private System.Windows.Forms.TextBox tbMiddle;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.DateTimePicker dateTPBirthday;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lAssign;
        private System.Windows.Forms.CheckedListBox clbTeams;
        private System.Windows.Forms.RichTextBox richTBNotes;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Athlete;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.Label lGrade;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbSTeams;
        private System.Windows.Forms.CheckedListBox clbSGrades;
        private System.Windows.Forms.Label lSearch;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.GroupBox gbSGender;
        private System.Windows.Forms.RadioButton rbSAll;
        private System.Windows.Forms.RadioButton rbSMale;
        private System.Windows.Forms.RadioButton rbSFemale;
    }
}