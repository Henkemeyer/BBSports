namespace BBSports
{
    partial class HomePage
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
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.gbSplitDistance = new System.Windows.Forms.GroupBox();
            this.rbLong = new System.Windows.Forms.RadioButton();
            this.rbShort = new System.Windows.Forms.RadioButton();
            this.lAthlete = new System.Windows.Forms.Label();
            this.cbAthlete = new System.Windows.Forms.ComboBox();
            this.cbEvent = new System.Windows.Forms.ComboBox();
            this.lEvent = new System.Windows.Forms.Label();
            this.cbMeet = new System.Windows.Forms.ComboBox();
            this.lMeet = new System.Windows.Forms.Label();
            this.pCrossCountry = new System.Windows.Forms.Panel();
            this.numericPlace = new System.Windows.Forms.NumericUpDown();
            this.lPlace = new System.Windows.Forms.Label();
            this.lSplits = new System.Windows.Forms.Label();
            this.bReset = new System.Windows.Forms.Button();
            this.bSubmit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolMenuProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSportTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.baseballTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.basketballTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.crossCountryTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.footballTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.hockeyTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.indoorTrackTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.outdoorTrackTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.soccerTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.softballTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.volleyballTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.createMeetTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.activateNewSportTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.meetPDFTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.athletesTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolRecordsTMI = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.gbSplitDistance.SuspendLayout();
            this.pCrossCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlace)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbGender);
            this.splitContainer1.Panel1.Controls.Add(this.gbSplitDistance);
            this.splitContainer1.Panel1.Controls.Add(this.lAthlete);
            this.splitContainer1.Panel1.Controls.Add(this.cbAthlete);
            this.splitContainer1.Panel1.Controls.Add(this.cbEvent);
            this.splitContainer1.Panel1.Controls.Add(this.lEvent);
            this.splitContainer1.Panel1.Controls.Add(this.cbMeet);
            this.splitContainer1.Panel1.Controls.Add(this.lMeet);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pCrossCountry);
            this.splitContainer1.Size = new System.Drawing.Size(1235, 626);
            this.splitContainer1.SplitterDistance = 410;
            this.splitContainer1.TabIndex = 3;
            // 
            // gbGender
            // 
            this.gbGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.Location = new System.Drawing.Point(43, 117);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(362, 118);
            this.gbGender.TabIndex = 13;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(9, 55);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(72, 28);
            this.rbMale.TabIndex = 5;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(240, 55);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(95, 28);
            this.rbFemale.TabIndex = 6;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // gbSplitDistance
            // 
            this.gbSplitDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSplitDistance.Controls.Add(this.rbLong);
            this.gbSplitDistance.Controls.Add(this.rbShort);
            this.gbSplitDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSplitDistance.Location = new System.Drawing.Point(43, 331);
            this.gbSplitDistance.Name = "gbSplitDistance";
            this.gbSplitDistance.Size = new System.Drawing.Size(362, 124);
            this.gbSplitDistance.TabIndex = 12;
            this.gbSplitDistance.TabStop = false;
            this.gbSplitDistance.Text = "Split Distance";
            // 
            // rbLong
            // 
            this.rbLong.AutoSize = true;
            this.rbLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLong.Location = new System.Drawing.Point(240, 59);
            this.rbLong.Name = "rbLong";
            this.rbLong.Size = new System.Drawing.Size(81, 28);
            this.rbLong.TabIndex = 8;
            this.rbLong.TabStop = true;
            this.rbLong.Text = "1 Mile";
            this.rbLong.UseVisualStyleBackColor = true;
            // 
            // rbShort
            // 
            this.rbShort.AutoSize = true;
            this.rbShort.Checked = true;
            this.rbShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbShort.Location = new System.Drawing.Point(9, 59);
            this.rbShort.Name = "rbShort";
            this.rbShort.Size = new System.Drawing.Size(87, 28);
            this.rbShort.TabIndex = 7;
            this.rbShort.TabStop = true;
            this.rbShort.Text = "1000m";
            this.rbShort.UseVisualStyleBackColor = true;
            // 
            // lAthlete
            // 
            this.lAthlete.AutoSize = true;
            this.lAthlete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAthlete.Location = new System.Drawing.Point(48, 458);
            this.lAthlete.Name = "lAthlete";
            this.lAthlete.Size = new System.Drawing.Size(87, 29);
            this.lAthlete.TabIndex = 11;
            this.lAthlete.Text = "Athlete";
            // 
            // cbAthlete
            // 
            this.cbAthlete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAthlete.FormattingEnabled = true;
            this.cbAthlete.Location = new System.Drawing.Point(43, 506);
            this.cbAthlete.Name = "cbAthlete";
            this.cbAthlete.Size = new System.Drawing.Size(334, 24);
            this.cbAthlete.TabIndex = 10;
            // 
            // cbEvent
            // 
            this.cbEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Location = new System.Drawing.Point(44, 279);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(334, 24);
            this.cbEvent.TabIndex = 3;
            // 
            // lEvent
            // 
            this.lEvent.AutoSize = true;
            this.lEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEvent.Location = new System.Drawing.Point(48, 238);
            this.lEvent.Name = "lEvent";
            this.lEvent.Size = new System.Drawing.Size(73, 29);
            this.lEvent.TabIndex = 2;
            this.lEvent.Text = "Event";
            // 
            // cbMeet
            // 
            this.cbMeet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMeet.FormattingEnabled = true;
            this.cbMeet.Location = new System.Drawing.Point(43, 77);
            this.cbMeet.MaxDropDownItems = 16;
            this.cbMeet.Name = "cbMeet";
            this.cbMeet.Size = new System.Drawing.Size(334, 24);
            this.cbMeet.TabIndex = 1;
            // 
            // lMeet
            // 
            this.lMeet.AutoSize = true;
            this.lMeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMeet.Location = new System.Drawing.Point(48, 41);
            this.lMeet.Name = "lMeet";
            this.lMeet.Size = new System.Drawing.Size(67, 29);
            this.lMeet.TabIndex = 0;
            this.lMeet.Text = "Meet";
            // 
            // pCrossCountry
            // 
            this.pCrossCountry.AutoSize = true;
            this.pCrossCountry.Controls.Add(this.numericPlace);
            this.pCrossCountry.Controls.Add(this.lPlace);
            this.pCrossCountry.Controls.Add(this.lSplits);
            this.pCrossCountry.Controls.Add(this.bReset);
            this.pCrossCountry.Controls.Add(this.bSubmit);
            this.pCrossCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCrossCountry.Location = new System.Drawing.Point(0, 0);
            this.pCrossCountry.Name = "pCrossCountry";
            this.pCrossCountry.Size = new System.Drawing.Size(819, 624);
            this.pCrossCountry.TabIndex = 0;
            // 
            // numericPlace
            // 
            this.numericPlace.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPlace.Location = new System.Drawing.Point(328, 441);
            this.numericPlace.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPlace.Name = "numericPlace";
            this.numericPlace.Size = new System.Drawing.Size(120, 28);
            this.numericPlace.TabIndex = 5;
            // 
            // lPlace
            // 
            this.lPlace.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lPlace.AutoSize = true;
            this.lPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlace.Location = new System.Drawing.Point(114, 438);
            this.lPlace.Name = "lPlace";
            this.lPlace.Size = new System.Drawing.Size(184, 29);
            this.lPlace.TabIndex = 3;
            this.lPlace.Text = "Finishing Place:";
            // 
            // lSplits
            // 
            this.lSplits.AutoSize = true;
            this.lSplits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSplits.Location = new System.Drawing.Point(38, 23);
            this.lSplits.Name = "lSplits";
            this.lSplits.Size = new System.Drawing.Size(79, 29);
            this.lSplits.TabIndex = 2;
            this.lSplits.Text = "Splits:";
            // 
            // bReset
            // 
            this.bReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.Location = new System.Drawing.Point(163, 521);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(91, 37);
            this.bReset.TabIndex = 1;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            // 
            // bSubmit
            // 
            this.bSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubmit.Location = new System.Drawing.Point(383, 521);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(99, 37);
            this.bSubmit.TabIndex = 0;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuProgram,
            this.toolMenuView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1235, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolMenuProgram
            // 
            this.toolMenuProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activateNewSportTMI,
            this.changeSportTMI,
            this.createMeetTMI,
            this.exitTMI});
            this.toolMenuProgram.Name = "toolMenuProgram";
            this.toolMenuProgram.Size = new System.Drawing.Size(78, 24);
            this.toolMenuProgram.Text = "Program";
            // 
            // changeSportTMI
            // 
            this.changeSportTMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseballTMI,
            this.basketballTMI,
            this.crossCountryTMI,
            this.footballTMI,
            this.hockeyTMI,
            this.indoorTrackTMI,
            this.outdoorTrackTMI,
            this.soccerTMI,
            this.softballTMI,
            this.volleyballTMI});
            this.changeSportTMI.Name = "changeSportTMI";
            this.changeSportTMI.Size = new System.Drawing.Size(212, 26);
            this.changeSportTMI.Text = "Change Sport";
            // 
            // baseballTMI
            // 
            this.baseballTMI.CheckOnClick = true;
            this.baseballTMI.Name = "baseballTMI";
            this.baseballTMI.Size = new System.Drawing.Size(178, 26);
            this.baseballTMI.Text = "Baseball";
            // 
            // basketballTMI
            // 
            this.basketballTMI.Name = "basketballTMI";
            this.basketballTMI.Size = new System.Drawing.Size(178, 26);
            this.basketballTMI.Text = "Basketball";
            // 
            // crossCountryTMI
            // 
            this.crossCountryTMI.Checked = true;
            this.crossCountryTMI.CheckOnClick = true;
            this.crossCountryTMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.crossCountryTMI.Name = "crossCountryTMI";
            this.crossCountryTMI.Size = new System.Drawing.Size(178, 26);
            this.crossCountryTMI.Text = "Cross Country";
            // 
            // footballTMI
            // 
            this.footballTMI.Name = "footballTMI";
            this.footballTMI.Size = new System.Drawing.Size(178, 26);
            this.footballTMI.Text = "Football";
            // 
            // hockeyTMI
            // 
            this.hockeyTMI.Name = "hockeyTMI";
            this.hockeyTMI.Size = new System.Drawing.Size(178, 26);
            this.hockeyTMI.Text = "Hockey";
            // 
            // indoorTrackTMI
            // 
            this.indoorTrackTMI.Name = "indoorTrackTMI";
            this.indoorTrackTMI.Size = new System.Drawing.Size(178, 26);
            this.indoorTrackTMI.Text = "Indoor Track";
            // 
            // outdoorTrackTMI
            // 
            this.outdoorTrackTMI.Name = "outdoorTrackTMI";
            this.outdoorTrackTMI.Size = new System.Drawing.Size(178, 26);
            this.outdoorTrackTMI.Text = "Outdoor Track";
            // 
            // soccerTMI
            // 
            this.soccerTMI.Name = "soccerTMI";
            this.soccerTMI.Size = new System.Drawing.Size(178, 26);
            this.soccerTMI.Text = "Soccer";
            // 
            // softballTMI
            // 
            this.softballTMI.Name = "softballTMI";
            this.softballTMI.Size = new System.Drawing.Size(178, 26);
            this.softballTMI.Text = "Softball";
            // 
            // volleyballTMI
            // 
            this.volleyballTMI.Name = "volleyballTMI";
            this.volleyballTMI.Size = new System.Drawing.Size(178, 26);
            this.volleyballTMI.Text = "Volleyball";
            // 
            // createMeetTMI
            // 
            this.createMeetTMI.Name = "createMeetTMI";
            this.createMeetTMI.Size = new System.Drawing.Size(212, 26);
            this.createMeetTMI.Text = "Create Meet";
            this.createMeetTMI.Click += new System.EventHandler(this.CreateMeetTMI_Click);
            // 
            // exitTMI
            // 
            this.exitTMI.Name = "exitTMI";
            this.exitTMI.Size = new System.Drawing.Size(212, 26);
            this.exitTMI.Text = "Exit";
            // 
            // activateNewSportTMI
            // 
            this.activateNewSportTMI.Name = "activateNewSportTMI";
            this.activateNewSportTMI.Size = new System.Drawing.Size(212, 26);
            this.activateNewSportTMI.Text = "Activate New Sport";
            this.activateNewSportTMI.Click += new System.EventHandler(this.ActivateNewSportTMI_Click);
            // 
            // toolMenuView
            // 
            this.toolMenuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meetPDFTMI,
            this.athletesTMI,
            this.schoolRecordsTMI});
            this.toolMenuView.Name = "toolMenuView";
            this.toolMenuView.Size = new System.Drawing.Size(53, 24);
            this.toolMenuView.Text = "View";
            // 
            // meetPDFTMI
            // 
            this.meetPDFTMI.Name = "meetPDFTMI";
            this.meetPDFTMI.Size = new System.Drawing.Size(186, 26);
            this.meetPDFTMI.Text = "Meet PDF";
            // 
            // athletesTMI
            // 
            this.athletesTMI.Name = "athletesTMI";
            this.athletesTMI.Size = new System.Drawing.Size(186, 26);
            this.athletesTMI.Text = "Athletes";
            // 
            // schoolRecordsTMI
            // 
            this.schoolRecordsTMI.Name = "schoolRecordsTMI";
            this.schoolRecordsTMI.Size = new System.Drawing.Size(186, 26);
            this.schoolRecordsTMI.Text = "School Records";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 654);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.gbSplitDistance.ResumeLayout(false);
            this.gbSplitDistance.PerformLayout();
            this.pCrossCountry.ResumeLayout(false);
            this.pCrossCountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlace)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ComboBox cbEvent;
        private System.Windows.Forms.Label lEvent;
        private System.Windows.Forms.ComboBox cbMeet;
        private System.Windows.Forms.Label lMeet;
        private System.Windows.Forms.ComboBox cbAthlete;
        private System.Windows.Forms.RadioButton rbLong;
        private System.Windows.Forms.RadioButton rbShort;
        private System.Windows.Forms.Label lAthlete;
        private System.Windows.Forms.Panel pCrossCountry;
        private System.Windows.Forms.NumericUpDown numericPlace;
        private System.Windows.Forms.Label lPlace;
        private System.Windows.Forms.Label lSplits;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolMenuProgram;
        private System.Windows.Forms.ToolStripMenuItem createMeetTMI;
        private System.Windows.Forms.ToolStripMenuItem exitTMI;
        private System.Windows.Forms.ToolStripMenuItem toolMenuView;
        private System.Windows.Forms.ToolStripMenuItem meetPDFTMI;
        private System.Windows.Forms.ToolStripMenuItem athletesTMI;
        private System.Windows.Forms.ToolStripMenuItem schoolRecordsTMI;
        private System.Windows.Forms.ToolStripMenuItem changeSportTMI;
        private System.Windows.Forms.ToolStripMenuItem baseballTMI;
        private System.Windows.Forms.ToolStripMenuItem basketballTMI;
        private System.Windows.Forms.ToolStripMenuItem crossCountryTMI;
        private System.Windows.Forms.ToolStripMenuItem footballTMI;
        private System.Windows.Forms.ToolStripMenuItem hockeyTMI;
        private System.Windows.Forms.ToolStripMenuItem indoorTrackTMI;
        private System.Windows.Forms.ToolStripMenuItem outdoorTrackTMI;
        private System.Windows.Forms.ToolStripMenuItem soccerTMI;
        private System.Windows.Forms.ToolStripMenuItem softballTMI;
        private System.Windows.Forms.ToolStripMenuItem volleyballTMI;
        private System.Windows.Forms.GroupBox gbSplitDistance;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.ToolStripMenuItem activateNewSportTMI;
    }
}