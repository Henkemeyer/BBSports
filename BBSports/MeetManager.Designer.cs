namespace BBSports
{
    partial class MeetManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetManager));
            this.scMeetManager = new System.Windows.Forms.SplitContainer();
            this.bSearch = new System.Windows.Forms.Button();
            this.gbMeetParam = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbCurrent = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.lEndDate = new System.Windows.Forms.Label();
            this.lBeginDate = new System.Windows.Forms.Label();
            this.dateTPEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTPBegin = new System.Windows.Forms.DateTimePicker();
            this.dgMeetsList = new System.Windows.Forms.DataGridView();
            this.MeetDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOtherScore = new System.Windows.Forms.GroupBox();
            this.numericOtherPlace = new System.Windows.Forms.NumericUpDown();
            this.numericOtherScore = new System.Windows.Forms.NumericUpDown();
            this.lScore = new System.Windows.Forms.Label();
            this.lPlace = new System.Windows.Forms.Label();
            this.gbScore = new System.Windows.Forms.GroupBox();
            this.numericPlace = new System.Windows.Forms.NumericUpDown();
            this.numericScore = new System.Windows.Forms.NumericUpDown();
            this.lOtherScore = new System.Windows.Forms.Label();
            this.lOtherPlace = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.cxbGenders = new System.Windows.Forms.CheckBox();
            this.lMeetName = new System.Windows.Forms.Label();
            this.bSubmit = new System.Windows.Forms.Button();
            this.lDate = new System.Windows.Forms.Label();
            this.dateTP = new System.Windows.Forms.DateTimePicker();
            this.richTBWeatherNotes = new System.Windows.Forms.RichTextBox();
            this.lWeatherNotes = new System.Windows.Forms.Label();
            this.richTBMeetNotes = new System.Windows.Forms.RichTextBox();
            this.lNotes = new System.Windows.Forms.Label();
            this.numericTemperature = new System.Windows.Forms.NumericUpDown();
            this.lTemperature = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.lLocation = new System.Windows.Forms.Label();
            this.tbMeetName = new System.Windows.Forms.TextBox();
            this.cxbAlumni = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.scMeetManager)).BeginInit();
            this.scMeetManager.Panel1.SuspendLayout();
            this.scMeetManager.Panel2.SuspendLayout();
            this.scMeetManager.SuspendLayout();
            this.gbMeetParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMeetsList)).BeginInit();
            this.gbOtherScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOtherPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOtherScore)).BeginInit();
            this.gbScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // scMeetManager
            // 
            this.scMeetManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMeetManager.Location = new System.Drawing.Point(0, 0);
            this.scMeetManager.Name = "scMeetManager";
            // 
            // scMeetManager.Panel1
            // 
            this.scMeetManager.Panel1.AutoScroll = true;
            this.scMeetManager.Panel1.Controls.Add(this.bSearch);
            this.scMeetManager.Panel1.Controls.Add(this.gbMeetParam);
            this.scMeetManager.Panel1.Controls.Add(this.lEndDate);
            this.scMeetManager.Panel1.Controls.Add(this.lBeginDate);
            this.scMeetManager.Panel1.Controls.Add(this.dateTPEnd);
            this.scMeetManager.Panel1.Controls.Add(this.dateTPBegin);
            this.scMeetManager.Panel1.Controls.Add(this.dgMeetsList);
            // 
            // scMeetManager.Panel2
            // 
            this.scMeetManager.Panel2.AutoScroll = true;
            this.scMeetManager.Panel2.Controls.Add(this.cxbAlumni);
            this.scMeetManager.Panel2.Controls.Add(this.label1);
            this.scMeetManager.Panel2.Controls.Add(this.gbOtherScore);
            this.scMeetManager.Panel2.Controls.Add(this.gbScore);
            this.scMeetManager.Panel2.Controls.Add(this.bClear);
            this.scMeetManager.Panel2.Controls.Add(this.cxbGenders);
            this.scMeetManager.Panel2.Controls.Add(this.lMeetName);
            this.scMeetManager.Panel2.Controls.Add(this.bSubmit);
            this.scMeetManager.Panel2.Controls.Add(this.lDate);
            this.scMeetManager.Panel2.Controls.Add(this.dateTP);
            this.scMeetManager.Panel2.Controls.Add(this.richTBWeatherNotes);
            this.scMeetManager.Panel2.Controls.Add(this.lWeatherNotes);
            this.scMeetManager.Panel2.Controls.Add(this.richTBMeetNotes);
            this.scMeetManager.Panel2.Controls.Add(this.lNotes);
            this.scMeetManager.Panel2.Controls.Add(this.numericTemperature);
            this.scMeetManager.Panel2.Controls.Add(this.lTemperature);
            this.scMeetManager.Panel2.Controls.Add(this.tbLocation);
            this.scMeetManager.Panel2.Controls.Add(this.lLocation);
            this.scMeetManager.Panel2.Controls.Add(this.tbMeetName);
            this.scMeetManager.Size = new System.Drawing.Size(1243, 927);
            this.scMeetManager.SplitterDistance = 435;
            this.scMeetManager.TabIndex = 7;
            // 
            // bSearch
            // 
            this.bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearch.Image = ((System.Drawing.Image)(resources.GetObject("bSearch.Image")));
            this.bSearch.Location = new System.Drawing.Point(377, 854);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(58, 55);
            this.bSearch.TabIndex = 8;
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // gbMeetParam
            // 
            this.gbMeetParam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbMeetParam.Controls.Add(this.rbFemale);
            this.gbMeetParam.Controls.Add(this.rbCurrent);
            this.gbMeetParam.Controls.Add(this.rbMale);
            this.gbMeetParam.Controls.Add(this.rbAll);
            this.gbMeetParam.Location = new System.Drawing.Point(12, 835);
            this.gbMeetParam.Name = "gbMeetParam";
            this.gbMeetParam.Size = new System.Drawing.Size(346, 80);
            this.gbMeetParam.TabIndex = 7;
            this.gbMeetParam.TabStop = false;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(191, 50);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(124, 24);
            this.rbFemale.TabIndex = 3;
            this.rbFemale.Text = "Female Only";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbCurrent
            // 
            this.rbCurrent.AutoSize = true;
            this.rbCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCurrent.Location = new System.Drawing.Point(26, 51);
            this.rbCurrent.Name = "rbCurrent";
            this.rbCurrent.Size = new System.Drawing.Size(133, 24);
            this.rbCurrent.TabIndex = 2;
            this.rbCurrent.Text = "Current Team";
            this.rbCurrent.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(191, 21);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(105, 24);
            this.rbMale.TabIndex = 1;
            this.rbMale.Text = "Male Only";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.Location = new System.Drawing.Point(26, 21);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(105, 24);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All Teams";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // lEndDate
            // 
            this.lEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lEndDate.AutoSize = true;
            this.lEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEndDate.Location = new System.Drawing.Point(252, 766);
            this.lEndDate.Name = "lEndDate";
            this.lEndDate.Size = new System.Drawing.Size(84, 20);
            this.lEndDate.TabIndex = 6;
            this.lEndDate.Text = "End Date:";
            // 
            // lBeginDate
            // 
            this.lBeginDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBeginDate.AutoSize = true;
            this.lBeginDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBeginDate.Location = new System.Drawing.Point(12, 766);
            this.lBeginDate.Name = "lBeginDate";
            this.lBeginDate.Size = new System.Drawing.Size(98, 20);
            this.lBeginDate.TabIndex = 5;
            this.lBeginDate.Text = "Begin Date:";
            // 
            // dateTPEnd
            // 
            this.dateTPEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTPEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTPEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPEnd.Location = new System.Drawing.Point(256, 789);
            this.dateTPEnd.Name = "dateTPEnd";
            this.dateTPEnd.Size = new System.Drawing.Size(159, 26);
            this.dateTPEnd.TabIndex = 4;
            // 
            // dateTPBegin
            // 
            this.dateTPBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTPBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPBegin.Location = new System.Drawing.Point(12, 789);
            this.dateTPBegin.Name = "dateTPBegin";
            this.dateTPBegin.Size = new System.Drawing.Size(157, 26);
            this.dateTPBegin.TabIndex = 3;
            // 
            // dgMeetsList
            // 
            this.dgMeetsList.AllowUserToAddRows = false;
            this.dgMeetsList.AllowUserToDeleteRows = false;
            this.dgMeetsList.AllowUserToOrderColumns = true;
            this.dgMeetsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMeetsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMeetsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MeetDate,
            this.Meet,
            this.MeetName,
            this.Gender});
            this.dgMeetsList.Location = new System.Drawing.Point(0, 0);
            this.dgMeetsList.MultiSelect = false;
            this.dgMeetsList.Name = "dgMeetsList";
            this.dgMeetsList.RowTemplate.Height = 24;
            this.dgMeetsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMeetsList.Size = new System.Drawing.Size(435, 750);
            this.dgMeetsList.TabIndex = 2;
            this.dgMeetsList.DoubleClick += new System.EventHandler(this.MeetsList_DoubleClick);
            // 
            // MeetDate
            // 
            this.MeetDate.DataPropertyName = "MeetDate";
            this.MeetDate.HeaderText = "Date";
            this.MeetDate.Name = "MeetDate";
            this.MeetDate.ReadOnly = true;
            // 
            // Meet
            // 
            this.Meet.DataPropertyName = "MeetId";
            this.Meet.HeaderText = "Meet Id";
            this.Meet.Name = "Meet";
            this.Meet.ReadOnly = true;
            this.Meet.Visible = false;
            // 
            // MeetName
            // 
            this.MeetName.DataPropertyName = "MeetName";
            this.MeetName.HeaderText = "Name";
            this.MeetName.MinimumWidth = 50;
            this.MeetName.Name = "MeetName";
            this.MeetName.ReadOnly = true;
            this.MeetName.Width = 250;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(794, 924);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 35;
            // 
            // gbOtherScore
            // 
            this.gbOtherScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOtherScore.Controls.Add(this.numericOtherPlace);
            this.gbOtherScore.Controls.Add(this.numericOtherScore);
            this.gbOtherScore.Controls.Add(this.lScore);
            this.gbOtherScore.Controls.Add(this.lPlace);
            this.gbOtherScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOtherScore.Location = new System.Drawing.Point(303, 350);
            this.gbOtherScore.Name = "gbOtherScore";
            this.gbOtherScore.Size = new System.Drawing.Size(382, 76);
            this.gbOtherScore.TabIndex = 34;
            this.gbOtherScore.TabStop = false;
            this.gbOtherScore.Text = "Other Team";
            this.gbOtherScore.Visible = false;
            // 
            // numericOtherPlace
            // 
            this.numericOtherPlace.Location = new System.Drawing.Point(277, 30);
            this.numericOtherPlace.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericOtherPlace.Name = "numericOtherPlace";
            this.numericOtherPlace.Size = new System.Drawing.Size(87, 26);
            this.numericOtherPlace.TabIndex = 35;
            this.numericOtherPlace.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericOtherScore
            // 
            this.numericOtherScore.Location = new System.Drawing.Point(99, 30);
            this.numericOtherScore.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericOtherScore.Name = "numericOtherScore";
            this.numericOtherScore.Size = new System.Drawing.Size(87, 26);
            this.numericOtherScore.TabIndex = 34;
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore.Location = new System.Drawing.Point(20, 32);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(58, 20);
            this.lScore.TabIndex = 29;
            this.lScore.Text = "Score:";
            // 
            // lPlace
            // 
            this.lPlace.AutoSize = true;
            this.lPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlace.Location = new System.Drawing.Point(206, 32);
            this.lPlace.Name = "lPlace";
            this.lPlace.Size = new System.Drawing.Size(56, 20);
            this.lPlace.TabIndex = 31;
            this.lPlace.Text = "Place:";
            // 
            // gbScore
            // 
            this.gbScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbScore.Controls.Add(this.numericPlace);
            this.gbScore.Controls.Add(this.numericScore);
            this.gbScore.Controls.Add(this.lOtherScore);
            this.gbScore.Controls.Add(this.lOtherPlace);
            this.gbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbScore.Location = new System.Drawing.Point(303, 276);
            this.gbScore.Name = "gbScore";
            this.gbScore.Size = new System.Drawing.Size(382, 68);
            this.gbScore.TabIndex = 33;
            this.gbScore.TabStop = false;
            this.gbScore.Text = "Current Team";
            // 
            // numericPlace
            // 
            this.numericPlace.Location = new System.Drawing.Point(277, 31);
            this.numericPlace.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPlace.Name = "numericPlace";
            this.numericPlace.Size = new System.Drawing.Size(87, 26);
            this.numericPlace.TabIndex = 34;
            this.numericPlace.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericScore
            // 
            this.numericScore.Location = new System.Drawing.Point(99, 31);
            this.numericScore.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericScore.Name = "numericScore";
            this.numericScore.Size = new System.Drawing.Size(87, 26);
            this.numericScore.TabIndex = 33;
            // 
            // lOtherScore
            // 
            this.lOtherScore.AutoSize = true;
            this.lOtherScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOtherScore.Location = new System.Drawing.Point(20, 33);
            this.lOtherScore.Name = "lOtherScore";
            this.lOtherScore.Size = new System.Drawing.Size(58, 20);
            this.lOtherScore.TabIndex = 30;
            this.lOtherScore.Text = "Score:";
            // 
            // lOtherPlace
            // 
            this.lOtherPlace.AutoSize = true;
            this.lOtherPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOtherPlace.Location = new System.Drawing.Point(206, 33);
            this.lOtherPlace.Name = "lOtherPlace";
            this.lOtherPlace.Size = new System.Drawing.Size(56, 20);
            this.lOtherPlace.TabIndex = 32;
            this.lOtherPlace.Text = "Place:";
            // 
            // bClear
            // 
            this.bClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(144, 811);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(142, 47);
            this.bClear.TabIndex = 28;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // cxbGenders
            // 
            this.cxbGenders.AutoSize = true;
            this.cxbGenders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxbGenders.Location = new System.Drawing.Point(152, 320);
            this.cxbGenders.Name = "cxbGenders";
            this.cxbGenders.Size = new System.Drawing.Size(144, 24);
            this.cxbGenders.TabIndex = 27;
            this.cxbGenders.Text = "Both Genders?";
            this.cxbGenders.UseVisualStyleBackColor = true;
            this.cxbGenders.CheckedChanged += new System.EventHandler(this.Genders_CheckedChanged);
            // 
            // lMeetName
            // 
            this.lMeetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lMeetName.AutoSize = true;
            this.lMeetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMeetName.Location = new System.Drawing.Point(150, 23);
            this.lMeetName.Name = "lMeetName";
            this.lMeetName.Size = new System.Drawing.Size(95, 20);
            this.lMeetName.TabIndex = 26;
            this.lMeetName.Text = "Meet Name";
            // 
            // bSubmit
            // 
            this.bSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubmit.Location = new System.Drawing.Point(451, 812);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(193, 46);
            this.bSubmit.TabIndex = 25;
            this.bSubmit.Text = "Submit Meet";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.Location = new System.Drawing.Point(150, 217);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(50, 20);
            this.lDate.TabIndex = 24;
            this.lDate.Text = "Date:";
            // 
            // dateTP
            // 
            this.dateTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTP.Location = new System.Drawing.Point(361, 215);
            this.dateTP.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTP.Name = "dateTP";
            this.dateTP.Size = new System.Drawing.Size(293, 26);
            this.dateTP.TabIndex = 23;
            this.dateTP.Value = new System.DateTime(2017, 6, 22, 10, 50, 2, 0);
            // 
            // richTBWeatherNotes
            // 
            this.richTBWeatherNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTBWeatherNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTBWeatherNotes.Location = new System.Drawing.Point(154, 479);
            this.richTBWeatherNotes.Name = "richTBWeatherNotes";
            this.richTBWeatherNotes.Size = new System.Drawing.Size(480, 96);
            this.richTBWeatherNotes.TabIndex = 20;
            this.richTBWeatherNotes.Text = "";
            // 
            // lWeatherNotes
            // 
            this.lWeatherNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lWeatherNotes.AutoSize = true;
            this.lWeatherNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWeatherNotes.Location = new System.Drawing.Point(150, 438);
            this.lWeatherNotes.Name = "lWeatherNotes";
            this.lWeatherNotes.Size = new System.Drawing.Size(126, 20);
            this.lWeatherNotes.TabIndex = 19;
            this.lWeatherNotes.Text = "Weather Notes:";
            // 
            // richTBMeetNotes
            // 
            this.richTBMeetNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTBMeetNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTBMeetNotes.Location = new System.Drawing.Point(154, 638);
            this.richTBMeetNotes.Name = "richTBMeetNotes";
            this.richTBMeetNotes.Size = new System.Drawing.Size(480, 131);
            this.richTBMeetNotes.TabIndex = 18;
            this.richTBMeetNotes.Text = "";
            // 
            // lNotes
            // 
            this.lNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lNotes.AutoSize = true;
            this.lNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNotes.Location = new System.Drawing.Point(150, 597);
            this.lNotes.Name = "lNotes";
            this.lNotes.Size = new System.Drawing.Size(100, 20);
            this.lNotes.TabIndex = 17;
            this.lNotes.Text = "Meet Notes:";
            // 
            // numericTemperature
            // 
            this.numericTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTemperature.Location = new System.Drawing.Point(503, 436);
            this.numericTemperature.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.numericTemperature.MaximumSize = new System.Drawing.Size(120, 0);
            this.numericTemperature.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.numericTemperature.Name = "numericTemperature";
            this.numericTemperature.Size = new System.Drawing.Size(97, 26);
            this.numericTemperature.TabIndex = 16;
            // 
            // lTemperature
            // 
            this.lTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lTemperature.AutoSize = true;
            this.lTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTemperature.Location = new System.Drawing.Point(357, 438);
            this.lTemperature.Name = "lTemperature";
            this.lTemperature.Size = new System.Drawing.Size(109, 20);
            this.lTemperature.TabIndex = 15;
            this.lTemperature.Text = "Temperature:";
            // 
            // tbLocation
            // 
            this.tbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocation.Location = new System.Drawing.Point(154, 155);
            this.tbLocation.MaxLength = 50;
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(480, 26);
            this.tbLocation.TabIndex = 14;
            // 
            // lLocation
            // 
            this.lLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lLocation.AutoSize = true;
            this.lLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLocation.Location = new System.Drawing.Point(150, 117);
            this.lLocation.Name = "lLocation";
            this.lLocation.Size = new System.Drawing.Size(78, 20);
            this.lLocation.TabIndex = 13;
            this.lLocation.Text = "Location:";
            // 
            // tbMeetName
            // 
            this.tbMeetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMeetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMeetName.Location = new System.Drawing.Point(154, 63);
            this.tbMeetName.MaxLength = 50;
            this.tbMeetName.Name = "tbMeetName";
            this.tbMeetName.Size = new System.Drawing.Size(480, 34);
            this.tbMeetName.TabIndex = 12;
            this.tbMeetName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cxbAlumni
            // 
            this.cxbAlumni.AutoSize = true;
            this.cxbAlumni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxbAlumni.Location = new System.Drawing.Point(361, 597);
            this.cxbAlumni.Name = "cxbAlumni";
            this.cxbAlumni.Size = new System.Drawing.Size(133, 24);
            this.cxbAlumni.TabIndex = 36;
            this.cxbAlumni.Text = "Alumni Meet?";
            this.cxbAlumni.UseVisualStyleBackColor = true;
            // 
            // MeetManager
            // 
            this.AcceptButton = this.bSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bClear;
            this.ClientSize = new System.Drawing.Size(1243, 927);
            this.ControlBox = false;
            this.Controls.Add(this.scMeetManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MeetManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Meet Manager";
            this.scMeetManager.Panel1.ResumeLayout(false);
            this.scMeetManager.Panel1.PerformLayout();
            this.scMeetManager.Panel2.ResumeLayout(false);
            this.scMeetManager.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMeetManager)).EndInit();
            this.scMeetManager.ResumeLayout(false);
            this.gbMeetParam.ResumeLayout(false);
            this.gbMeetParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMeetsList)).EndInit();
            this.gbOtherScore.ResumeLayout(false);
            this.gbOtherScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOtherPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOtherScore)).EndInit();
            this.gbScore.ResumeLayout(false);
            this.gbScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTemperature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMeetManager;
        private System.Windows.Forms.DataGridView dgMeetsList;
        private System.Windows.Forms.RichTextBox richTBWeatherNotes;
        private System.Windows.Forms.Label lWeatherNotes;
        private System.Windows.Forms.RichTextBox richTBMeetNotes;
        private System.Windows.Forms.Label lNotes;
        private System.Windows.Forms.NumericUpDown numericTemperature;
        private System.Windows.Forms.Label lTemperature;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label lLocation;
        private System.Windows.Forms.TextBox tbMeetName;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.DateTimePicker dateTP;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Label lMeetName;
        private System.Windows.Forms.GroupBox gbMeetParam;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbCurrent;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Label lEndDate;
        private System.Windows.Forms.Label lBeginDate;
        private System.Windows.Forms.DateTimePicker dateTPEnd;
        private System.Windows.Forms.DateTimePicker dateTPBegin;
        private System.Windows.Forms.CheckBox cxbGenders;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.GroupBox gbOtherScore;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Label lPlace;
        private System.Windows.Forms.GroupBox gbScore;
        private System.Windows.Forms.Label lOtherScore;
        private System.Windows.Forms.Label lOtherPlace;
        private System.Windows.Forms.NumericUpDown numericOtherPlace;
        private System.Windows.Forms.NumericUpDown numericOtherScore;
        private System.Windows.Forms.NumericUpDown numericPlace;
        private System.Windows.Forms.NumericUpDown numericScore;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeetDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cxbAlumni;
    }
}