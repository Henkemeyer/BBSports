namespace BBSports
{
    partial class TeamManager
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bSearch = new System.Windows.Forms.Button();
            this.cbSActivated = new System.Windows.Forms.CheckBox();
            this.lSSeason = new System.Windows.Forms.Label();
            this.cbSSeason = new System.Windows.Forms.ComboBox();
            this.lSSport = new System.Windows.Forms.Label();
            this.cbSSports = new System.Windows.Forms.ComboBox();
            this.gbSGender = new System.Windows.Forms.GroupBox();
            this.rbSAll = new System.Windows.Forms.RadioButton();
            this.rbSCoed = new System.Windows.Forms.RadioButton();
            this.rbSMale = new System.Windows.Forms.RadioButton();
            this.rbSFemale = new System.Windows.Forms.RadioButton();
            this.lsearch = new System.Windows.Forms.Label();
            this.dgTeams = new System.Windows.Forms.DataGridView();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bClear = new System.Windows.Forms.Button();
            this.lWarning = new System.Windows.Forms.Label();
            this.bDeactivate = new System.Windows.Forms.Button();
            this.lHeader = new System.Windows.Forms.Label();
            this.bActivate = new System.Windows.Forms.Button();
            this.cbSports = new System.Windows.Forms.ComboBox();
            this.tbTeamName = new System.Windows.Forms.TextBox();
            this.lTeamName = new System.Windows.Forms.Label();
            this.lOther = new System.Windows.Forms.Label();
            this.tbOther = new System.Windows.Forms.TextBox();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.lLevel = new System.Windows.Forms.Label();
            this.lSeason = new System.Windows.Forms.Label();
            this.cbSeason = new System.Windows.Forms.ComboBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbCoed = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lSportName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbSGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeams)).BeginInit();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bSearch);
            this.splitContainer1.Panel1.Controls.Add(this.cbSActivated);
            this.splitContainer1.Panel1.Controls.Add(this.lSSeason);
            this.splitContainer1.Panel1.Controls.Add(this.cbSSeason);
            this.splitContainer1.Panel1.Controls.Add(this.lSSport);
            this.splitContainer1.Panel1.Controls.Add(this.cbSSports);
            this.splitContainer1.Panel1.Controls.Add(this.gbSGender);
            this.splitContainer1.Panel1.Controls.Add(this.lsearch);
            this.splitContainer1.Panel1.Controls.Add(this.dgTeams);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bClear);
            this.splitContainer1.Panel2.Controls.Add(this.lWarning);
            this.splitContainer1.Panel2.Controls.Add(this.bDeactivate);
            this.splitContainer1.Panel2.Controls.Add(this.lHeader);
            this.splitContainer1.Panel2.Controls.Add(this.bActivate);
            this.splitContainer1.Panel2.Controls.Add(this.cbSports);
            this.splitContainer1.Panel2.Controls.Add(this.tbTeamName);
            this.splitContainer1.Panel2.Controls.Add(this.lTeamName);
            this.splitContainer1.Panel2.Controls.Add(this.lOther);
            this.splitContainer1.Panel2.Controls.Add(this.tbOther);
            this.splitContainer1.Panel2.Controls.Add(this.cbLevel);
            this.splitContainer1.Panel2.Controls.Add(this.lLevel);
            this.splitContainer1.Panel2.Controls.Add(this.lSeason);
            this.splitContainer1.Panel2.Controls.Add(this.cbSeason);
            this.splitContainer1.Panel2.Controls.Add(this.gbGender);
            this.splitContainer1.Panel2.Controls.Add(this.lSportName);
            this.splitContainer1.Size = new System.Drawing.Size(1638, 808);
            this.splitContainer1.SplitterDistance = 688;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // bSearch
            // 
            this.bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearch.Image = global::BBSports.Properties.Resources.Magnify;
            this.bSearch.Location = new System.Drawing.Point(474, 703);
            this.bSearch.MinimumSize = new System.Drawing.Size(46, 46);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(46, 48);
            this.bSearch.TabIndex = 8;
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // cbSActivated
            // 
            this.cbSActivated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSActivated.AutoSize = true;
            this.cbSActivated.Checked = true;
            this.cbSActivated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSActivated.Location = new System.Drawing.Point(138, 720);
            this.cbSActivated.Name = "cbSActivated";
            this.cbSActivated.Size = new System.Drawing.Size(148, 24);
            this.cbSActivated.TabIndex = 7;
            this.cbSActivated.Text = "Activated Only?";
            this.cbSActivated.UseVisualStyleBackColor = true;
            // 
            // lSSeason
            // 
            this.lSSeason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lSSeason.AutoSize = true;
            this.lSSeason.Location = new System.Drawing.Point(43, 662);
            this.lSSeason.Name = "lSSeason";
            this.lSSeason.Size = new System.Drawing.Size(70, 20);
            this.lSSeason.TabIndex = 6;
            this.lSSeason.Text = "Season:";
            // 
            // cbSSeason
            // 
            this.cbSSeason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSSeason.AutoCompleteCustomSource.AddRange(new string[] {
            "All",
            "Fall",
            "Winter",
            "Spring",
            "Summer",
            "All-Year"});
            this.cbSSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSSeason.FormattingEnabled = true;
            this.cbSSeason.Items.AddRange(new object[] {
            "All",
            "Fall",
            "Winter",
            "Spring",
            "Summer",
            "All-Year"});
            this.cbSSeason.Location = new System.Drawing.Point(138, 659);
            this.cbSSeason.Name = "cbSSeason";
            this.cbSSeason.Size = new System.Drawing.Size(266, 28);
            this.cbSSeason.TabIndex = 5;
            // 
            // lSSport
            // 
            this.lSSport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lSSport.AutoSize = true;
            this.lSSport.Location = new System.Drawing.Point(43, 611);
            this.lSSport.Name = "lSSport";
            this.lSSport.Size = new System.Drawing.Size(54, 20);
            this.lSSport.TabIndex = 4;
            this.lSSport.Text = "Sport:";
            // 
            // cbSSports
            // 
            this.cbSSports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSSports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSSports.FormattingEnabled = true;
            this.cbSSports.Location = new System.Drawing.Point(138, 608);
            this.cbSSports.Name = "cbSSports";
            this.cbSSports.Size = new System.Drawing.Size(266, 28);
            this.cbSSports.TabIndex = 3;
            // 
            // gbSGender
            // 
            this.gbSGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSGender.Controls.Add(this.rbSAll);
            this.gbSGender.Controls.Add(this.rbSCoed);
            this.gbSGender.Controls.Add(this.rbSMale);
            this.gbSGender.Controls.Add(this.rbSFemale);
            this.gbSGender.Location = new System.Drawing.Point(420, 587);
            this.gbSGender.Name = "gbSGender";
            this.gbSGender.Size = new System.Drawing.Size(200, 100);
            this.gbSGender.TabIndex = 2;
            this.gbSGender.TabStop = false;
            this.gbSGender.Text = "Gender";
            // 
            // rbSAll
            // 
            this.rbSAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSAll.AutoSize = true;
            this.rbSAll.Checked = true;
            this.rbSAll.Location = new System.Drawing.Point(101, 61);
            this.rbSAll.Name = "rbSAll";
            this.rbSAll.Size = new System.Drawing.Size(49, 24);
            this.rbSAll.TabIndex = 3;
            this.rbSAll.TabStop = true;
            this.rbSAll.Text = "All";
            this.rbSAll.UseVisualStyleBackColor = true;
            // 
            // rbSCoed
            // 
            this.rbSCoed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSCoed.AutoSize = true;
            this.rbSCoed.Location = new System.Drawing.Point(28, 58);
            this.rbSCoed.Name = "rbSCoed";
            this.rbSCoed.Size = new System.Drawing.Size(42, 24);
            this.rbSCoed.TabIndex = 2;
            this.rbSCoed.Text = "C";
            this.rbSCoed.UseVisualStyleBackColor = true;
            // 
            // rbSMale
            // 
            this.rbSMale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSMale.AutoSize = true;
            this.rbSMale.Location = new System.Drawing.Point(101, 28);
            this.rbSMale.Name = "rbSMale";
            this.rbSMale.Size = new System.Drawing.Size(44, 24);
            this.rbSMale.TabIndex = 1;
            this.rbSMale.Text = "M";
            this.rbSMale.UseVisualStyleBackColor = true;
            // 
            // rbSFemale
            // 
            this.rbSFemale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSFemale.AutoSize = true;
            this.rbSFemale.Location = new System.Drawing.Point(28, 28);
            this.rbSFemale.Name = "rbSFemale";
            this.rbSFemale.Size = new System.Drawing.Size(40, 24);
            this.rbSFemale.TabIndex = 0;
            this.rbSFemale.Text = "F";
            this.rbSFemale.UseVisualStyleBackColor = true;
            // 
            // lsearch
            // 
            this.lsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsearch.AutoSize = true;
            this.lsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsearch.Location = new System.Drawing.Point(23, 578);
            this.lsearch.Name = "lsearch";
            this.lsearch.Size = new System.Drawing.Size(62, 20);
            this.lsearch.TabIndex = 1;
            this.lsearch.Text = "Search";
            // 
            // dgTeams
            // 
            this.dgTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Team,
            this.TeamName,
            this.Gender,
            this.Level,
            this.Active});
            this.dgTeams.Location = new System.Drawing.Point(0, 0);
            this.dgTeams.Name = "dgTeams";
            this.dgTeams.RowTemplate.Height = 24;
            this.dgTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTeams.Size = new System.Drawing.Size(685, 560);
            this.dgTeams.TabIndex = 0;
            this.dgTeams.TabStop = false;
            this.dgTeams.VirtualMode = true;
            this.dgTeams.DoubleClick += new System.EventHandler(this.Teams_DoubleClick);
            // 
            // Team
            // 
            this.Team.DataPropertyName = "TeamId";
            this.Team.HeaderText = "Team Id";
            this.Team.Name = "Team";
            this.Team.ReadOnly = true;
            this.Team.Visible = false;
            // 
            // TeamName
            // 
            this.TeamName.DataPropertyName = "TeamName";
            this.TeamName.HeaderText = "Team Name";
            this.TeamName.MinimumWidth = 40;
            this.TeamName.Name = "TeamName";
            this.TeamName.ReadOnly = true;
            this.TeamName.Width = 175;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Level";
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.FalseValue = "0";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.TrueValue = "1";
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(388, 597);
            this.bClear.MinimumSize = new System.Drawing.Size(100, 48);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(144, 48);
            this.bClear.TabIndex = 9;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // lWarning
            // 
            this.lWarning.AutoSize = true;
            this.lWarning.ForeColor = System.Drawing.Color.Red;
            this.lWarning.Location = new System.Drawing.Point(213, 688);
            this.lWarning.Name = "lWarning";
            this.lWarning.Size = new System.Drawing.Size(387, 20);
            this.lWarning.TabIndex = 28;
            this.lWarning.Text = "*Deactivated Teams are subject to a 48 hour lock.*";
            this.lWarning.Visible = false;
            // 
            // bDeactivate
            // 
            this.bDeactivate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bDeactivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bDeactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeactivate.Location = new System.Drawing.Point(143, 595);
            this.bDeactivate.MinimumSize = new System.Drawing.Size(100, 48);
            this.bDeactivate.Name = "bDeactivate";
            this.bDeactivate.Size = new System.Drawing.Size(144, 48);
            this.bDeactivate.TabIndex = 8;
            this.bDeactivate.Text = "Deactivate";
            this.bDeactivate.UseVisualStyleBackColor = false;
            this.bDeactivate.Visible = false;
            this.bDeactivate.Click += new System.EventHandler(this.Deactivate_Click);
            // 
            // lHeader
            // 
            this.lHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lHeader.AutoSize = true;
            this.lHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeader.Location = new System.Drawing.Point(160, 42);
            this.lHeader.Name = "lHeader";
            this.lHeader.Size = new System.Drawing.Size(153, 31);
            this.lHeader.TabIndex = 99;
            this.lHeader.Text = "New Team";
            // 
            // bActivate
            // 
            this.bActivate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bActivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bActivate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bActivate.FlatAppearance.BorderSize = 0;
            this.bActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bActivate.Location = new System.Drawing.Point(620, 597);
            this.bActivate.Margin = new System.Windows.Forms.Padding(4);
            this.bActivate.MinimumSize = new System.Drawing.Size(100, 48);
            this.bActivate.Name = "bActivate";
            this.bActivate.Size = new System.Drawing.Size(144, 48);
            this.bActivate.TabIndex = 7;
            this.bActivate.Text = "Activate";
            this.bActivate.UseVisualStyleBackColor = false;
            this.bActivate.Click += new System.EventHandler(this.Activate_Click);
            // 
            // cbSports
            // 
            this.cbSports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSports.FormattingEnabled = true;
            this.cbSports.Location = new System.Drawing.Point(347, 135);
            this.cbSports.Margin = new System.Windows.Forms.Padding(4);
            this.cbSports.MinimumSize = new System.Drawing.Size(250, 0);
            this.cbSports.Name = "cbSports";
            this.cbSports.Size = new System.Drawing.Size(417, 28);
            this.cbSports.TabIndex = 1;
            // 
            // tbTeamName
            // 
            this.tbTeamName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTeamName.Location = new System.Drawing.Point(347, 185);
            this.tbTeamName.Margin = new System.Windows.Forms.Padding(4);
            this.tbTeamName.MinimumSize = new System.Drawing.Size(250, 26);
            this.tbTeamName.Name = "tbTeamName";
            this.tbTeamName.Size = new System.Drawing.Size(417, 26);
            this.tbTeamName.TabIndex = 2;
            // 
            // lTeamName
            // 
            this.lTeamName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lTeamName.AutoSize = true;
            this.lTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTeamName.Location = new System.Drawing.Point(162, 186);
            this.lTeamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTeamName.Name = "lTeamName";
            this.lTeamName.Size = new System.Drawing.Size(126, 25);
            this.lTeamName.TabIndex = 99;
            this.lTeamName.Text = "Team Name:";
            // 
            // lOther
            // 
            this.lOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lOther.AutoSize = true;
            this.lOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOther.Location = new System.Drawing.Point(162, 503);
            this.lOther.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lOther.Name = "lOther";
            this.lOther.Size = new System.Drawing.Size(92, 25);
            this.lOther.TabIndex = 99;
            this.lOther.Text = "*If Other*";
            this.lOther.Visible = false;
            // 
            // tbOther
            // 
            this.tbOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOther.Location = new System.Drawing.Point(347, 502);
            this.tbOther.Margin = new System.Windows.Forms.Padding(4);
            this.tbOther.MinimumSize = new System.Drawing.Size(250, 26);
            this.tbOther.Name = "tbOther";
            this.tbOther.Size = new System.Drawing.Size(417, 26);
            this.tbOther.TabIndex = 6;
            this.tbOther.Visible = false;
            // 
            // cbLevel
            // 
            this.cbLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Club",
            "Division I",
            "Division II",
            "Division III",
            "High School",
            "Middle School",
            "Premier Club",
            "Recreation",
            "(Other)"});
            this.cbLevel.Location = new System.Drawing.Point(347, 440);
            this.cbLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cbLevel.MinimumSize = new System.Drawing.Size(250, 0);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(417, 28);
            this.cbLevel.TabIndex = 5;
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.Level_SelectedIndexChanged);
            // 
            // lLevel
            // 
            this.lLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lLevel.AutoSize = true;
            this.lLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLevel.Location = new System.Drawing.Point(162, 443);
            this.lLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLevel.Name = "lLevel";
            this.lLevel.Size = new System.Drawing.Size(65, 25);
            this.lLevel.TabIndex = 99;
            this.lLevel.Text = "Level:";
            // 
            // lSeason
            // 
            this.lSeason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lSeason.AutoSize = true;
            this.lSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSeason.Location = new System.Drawing.Point(162, 236);
            this.lSeason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSeason.Name = "lSeason";
            this.lSeason.Size = new System.Drawing.Size(86, 25);
            this.lSeason.TabIndex = 99;
            this.lSeason.Text = "Season:";
            // 
            // cbSeason
            // 
            this.cbSeason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeason.FormattingEnabled = true;
            this.cbSeason.Items.AddRange(new object[] {
            "Fall",
            "Winter",
            "Spring",
            "Summer",
            "All-Year"});
            this.cbSeason.Location = new System.Drawing.Point(347, 235);
            this.cbSeason.Margin = new System.Windows.Forms.Padding(4);
            this.cbSeason.MinimumSize = new System.Drawing.Size(250, 0);
            this.cbSeason.Name = "cbSeason";
            this.cbSeason.Size = new System.Drawing.Size(417, 28);
            this.cbSeason.TabIndex = 3;
            // 
            // gbGender
            // 
            this.gbGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGender.Controls.Add(this.rbCoed);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.Location = new System.Drawing.Point(152, 315);
            this.gbGender.Margin = new System.Windows.Forms.Padding(4);
            this.gbGender.Name = "gbGender";
            this.gbGender.Padding = new System.Windows.Forms.Padding(4);
            this.gbGender.Size = new System.Drawing.Size(612, 96);
            this.gbGender.TabIndex = 4;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender:";
            // 
            // rbCoed
            // 
            this.rbCoed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCoed.AutoSize = true;
            this.rbCoed.Location = new System.Drawing.Point(236, 48);
            this.rbCoed.Name = "rbCoed";
            this.rbCoed.Size = new System.Drawing.Size(90, 29);
            this.rbCoed.TabIndex = 2;
            this.rbCoed.TabStop = true;
            this.rbCoed.Text = "Co-Ed";
            this.rbCoed.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(148, 48);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(76, 29);
            this.rbMale.TabIndex = 1;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFemale.AutoSize = true;
            this.rbFemale.Checked = true;
            this.rbFemale.Location = new System.Drawing.Point(30, 48);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(98, 29);
            this.rbFemale.TabIndex = 0;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // lSportName
            // 
            this.lSportName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lSportName.AutoSize = true;
            this.lSportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSportName.Location = new System.Drawing.Point(162, 132);
            this.lSportName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSportName.Name = "lSportName";
            this.lSportName.Size = new System.Drawing.Size(65, 25);
            this.lSportName.TabIndex = 99;
            this.lSportName.Text = "Sport:";
            // 
            // TeamManager
            // 
            this.AcceptButton = this.bActivate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1638, 808);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeamManager";
            this.Text = "Team Manager";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbSGender.ResumeLayout(false);
            this.gbSGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeams)).EndInit();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bActivate;
        private System.Windows.Forms.ComboBox cbSports;
        private System.Windows.Forms.TextBox tbTeamName;
        private System.Windows.Forms.Label lTeamName;
        private System.Windows.Forms.Label lOther;
        private System.Windows.Forms.TextBox tbOther;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Label lLevel;
        private System.Windows.Forms.Label lSeason;
        private System.Windows.Forms.ComboBox cbSeason;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lSportName;
        private System.Windows.Forms.DataGridView dgTeams;
        private System.Windows.Forms.Label lHeader;
        private System.Windows.Forms.RadioButton rbCoed;
        private System.Windows.Forms.GroupBox gbSGender;
        private System.Windows.Forms.RadioButton rbSAll;
        private System.Windows.Forms.RadioButton rbSCoed;
        private System.Windows.Forms.RadioButton rbSMale;
        private System.Windows.Forms.RadioButton rbSFemale;
        private System.Windows.Forms.Label lsearch;
        private System.Windows.Forms.Label lSSport;
        private System.Windows.Forms.ComboBox cbSSports;
        private System.Windows.Forms.Label lSSeason;
        private System.Windows.Forms.ComboBox cbSSeason;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.CheckBox cbSActivated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.Button bDeactivate;
        private System.Windows.Forms.Label lWarning;
        private System.Windows.Forms.Button bClear;
    }
}