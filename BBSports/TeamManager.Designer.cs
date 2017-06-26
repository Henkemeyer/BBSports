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
            this.MeetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.bSearch.Image = global::BBSports.Properties.Resources.Magnify;
            this.bSearch.Location = new System.Drawing.Point(474, 703);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(46, 48);
            this.bSearch.TabIndex = 8;
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // cbSActivated
            // 
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
            this.lSSeason.AutoSize = true;
            this.lSSeason.Location = new System.Drawing.Point(43, 662);
            this.lSSeason.Name = "lSSeason";
            this.lSSeason.Size = new System.Drawing.Size(70, 20);
            this.lSSeason.TabIndex = 6;
            this.lSSeason.Text = "Season:";
            // 
            // cbSSeason
            // 
            this.cbSSeason.AutoCompleteCustomSource.AddRange(new string[] {
            "All",
            "Fall",
            "Winter",
            "Spring",
            "Summer",
            "All-Year"});
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
            this.lSSport.AutoSize = true;
            this.lSSport.Location = new System.Drawing.Point(43, 611);
            this.lSSport.Name = "lSSport";
            this.lSSport.Size = new System.Drawing.Size(54, 20);
            this.lSSport.TabIndex = 4;
            this.lSSport.Text = "Sport:";
            // 
            // cbSSports
            // 
            this.cbSSports.FormattingEnabled = true;
            this.cbSSports.Location = new System.Drawing.Point(138, 608);
            this.cbSSports.Name = "cbSSports";
            this.cbSSports.Size = new System.Drawing.Size(266, 28);
            this.cbSSports.TabIndex = 3;
            // 
            // gbSGender
            // 
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
            this.rbSAll.AutoSize = true;
            this.rbSAll.Checked = true;
            this.rbSAll.Location = new System.Drawing.Point(131, 58);
            this.rbSAll.Name = "rbSAll";
            this.rbSAll.Size = new System.Drawing.Size(49, 24);
            this.rbSAll.TabIndex = 3;
            this.rbSAll.TabStop = true;
            this.rbSAll.Text = "All";
            this.rbSAll.UseVisualStyleBackColor = true;
            // 
            // rbSCoed
            // 
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
            this.rbSMale.AutoSize = true;
            this.rbSMale.Location = new System.Drawing.Point(131, 25);
            this.rbSMale.Name = "rbSMale";
            this.rbSMale.Size = new System.Drawing.Size(44, 24);
            this.rbSMale.TabIndex = 1;
            this.rbSMale.Text = "M";
            this.rbSMale.UseVisualStyleBackColor = true;
            // 
            // rbSFemale
            // 
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
            this.MeetId,
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
            this.dgTeams.VirtualMode = true;
            this.dgTeams.DoubleClick += new System.EventHandler(this.Teams_DoubleClick);
            // 
            // lHeader
            // 
            this.lHeader.AutoSize = true;
            this.lHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeader.Location = new System.Drawing.Point(206, 43);
            this.lHeader.Name = "lHeader";
            this.lHeader.Size = new System.Drawing.Size(153, 31);
            this.lHeader.TabIndex = 26;
            this.lHeader.Text = "New Team";
            // 
            // bActivate
            // 
            this.bActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bActivate.Location = new System.Drawing.Point(570, 578);
            this.bActivate.Margin = new System.Windows.Forms.Padding(4);
            this.bActivate.Name = "bActivate";
            this.bActivate.Size = new System.Drawing.Size(145, 48);
            this.bActivate.TabIndex = 25;
            this.bActivate.Text = "Activate";
            this.bActivate.UseVisualStyleBackColor = true;
            // 
            // cbSports
            // 
            this.cbSports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSports.FormattingEnabled = true;
            this.cbSports.Location = new System.Drawing.Point(393, 136);
            this.cbSports.Margin = new System.Windows.Forms.Padding(4);
            this.cbSports.Name = "cbSports";
            this.cbSports.Size = new System.Drawing.Size(418, 28);
            this.cbSports.TabIndex = 24;
            // 
            // tbTeamName
            // 
            this.tbTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTeamName.Location = new System.Drawing.Point(393, 186);
            this.tbTeamName.Margin = new System.Windows.Forms.Padding(4);
            this.tbTeamName.Name = "tbTeamName";
            this.tbTeamName.Size = new System.Drawing.Size(418, 26);
            this.tbTeamName.TabIndex = 23;
            // 
            // lTeamName
            // 
            this.lTeamName.AutoSize = true;
            this.lTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTeamName.Location = new System.Drawing.Point(208, 187);
            this.lTeamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTeamName.Name = "lTeamName";
            this.lTeamName.Size = new System.Drawing.Size(126, 25);
            this.lTeamName.TabIndex = 22;
            this.lTeamName.Text = "Team Name:";
            // 
            // lOther
            // 
            this.lOther.AutoSize = true;
            this.lOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOther.Location = new System.Drawing.Point(208, 504);
            this.lOther.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lOther.Name = "lOther";
            this.lOther.Size = new System.Drawing.Size(92, 25);
            this.lOther.TabIndex = 21;
            this.lOther.Text = "*If Other*";
            this.lOther.Visible = false;
            // 
            // tbOther
            // 
            this.tbOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOther.Location = new System.Drawing.Point(393, 503);
            this.tbOther.Margin = new System.Windows.Forms.Padding(4);
            this.tbOther.Name = "tbOther";
            this.tbOther.Size = new System.Drawing.Size(418, 26);
            this.tbOther.TabIndex = 20;
            this.tbOther.Visible = false;
            // 
            // cbLevel
            // 
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
            this.cbLevel.Location = new System.Drawing.Point(393, 441);
            this.cbLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(418, 28);
            this.cbLevel.TabIndex = 19;
            // 
            // lLevel
            // 
            this.lLevel.AutoSize = true;
            this.lLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLevel.Location = new System.Drawing.Point(208, 444);
            this.lLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLevel.Name = "lLevel";
            this.lLevel.Size = new System.Drawing.Size(65, 25);
            this.lLevel.TabIndex = 18;
            this.lLevel.Text = "Level:";
            // 
            // lSeason
            // 
            this.lSeason.AutoSize = true;
            this.lSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSeason.Location = new System.Drawing.Point(208, 237);
            this.lSeason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSeason.Name = "lSeason";
            this.lSeason.Size = new System.Drawing.Size(86, 25);
            this.lSeason.TabIndex = 17;
            this.lSeason.Text = "Season:";
            // 
            // cbSeason
            // 
            this.cbSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeason.FormattingEnabled = true;
            this.cbSeason.Items.AddRange(new object[] {
            "Fall",
            "Winter",
            "Spring",
            "Summer",
            "All-Year"});
            this.cbSeason.Location = new System.Drawing.Point(393, 236);
            this.cbSeason.Margin = new System.Windows.Forms.Padding(4);
            this.cbSeason.Name = "cbSeason";
            this.cbSeason.Size = new System.Drawing.Size(418, 28);
            this.cbSeason.TabIndex = 16;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbCoed);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.Location = new System.Drawing.Point(198, 316);
            this.gbGender.Margin = new System.Windows.Forms.Padding(4);
            this.gbGender.Name = "gbGender";
            this.gbGender.Padding = new System.Windows.Forms.Padding(4);
            this.gbGender.Size = new System.Drawing.Size(613, 96);
            this.gbGender.TabIndex = 15;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender:";
            // 
            // rbCoed
            // 
            this.rbCoed.AutoSize = true;
            this.rbCoed.Location = new System.Drawing.Point(458, 48);
            this.rbCoed.Name = "rbCoed";
            this.rbCoed.Size = new System.Drawing.Size(77, 24);
            this.rbCoed.TabIndex = 2;
            this.rbCoed.TabStop = true;
            this.rbCoed.Text = "Co-Ed";
            this.rbCoed.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(248, 48);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(66, 24);
            this.rbMale.TabIndex = 1;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Checked = true;
            this.rbFemale.Location = new System.Drawing.Point(30, 48);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(85, 24);
            this.rbFemale.TabIndex = 0;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // lSportName
            // 
            this.lSportName.AutoSize = true;
            this.lSportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSportName.Location = new System.Drawing.Point(208, 133);
            this.lSportName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSportName.Name = "lSportName";
            this.lSportName.Size = new System.Drawing.Size(65, 25);
            this.lSportName.TabIndex = 14;
            this.lSportName.Text = "Sport:";
            // 
            // MeetId
            // 
            this.MeetId.DataPropertyName = "MeetId";
            this.MeetId.HeaderText = "Meet Id";
            this.MeetId.Name = "MeetId";
            this.MeetId.ReadOnly = true;
            this.MeetId.Visible = false;
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
            // TeamManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 808);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MeetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
    }
}