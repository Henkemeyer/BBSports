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
            this.toolMenuProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.newPerformTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAthletesTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMeetsTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.teamManagerTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.rosterTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPerformTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.meetPDFTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolRecordsTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHome = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTeamTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.switchUserTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrgTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.workoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LiftingTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.practiceTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.activateNewSportTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolMenuProgram
            // 
            this.toolMenuProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPerformTMI,
            this.manageAthletesTMI,
            this.manageMeetsTMI,
            this.teamManagerTMI});
            this.toolMenuProgram.Name = "toolMenuProgram";
            this.toolMenuProgram.Size = new System.Drawing.Size(75, 24);
            this.toolMenuProgram.Text = "Manage";
            // 
            // newPerformTMI
            // 
            this.newPerformTMI.Name = "newPerformTMI";
            this.newPerformTMI.Size = new System.Drawing.Size(201, 26);
            this.newPerformTMI.Text = "New Performance";
            this.newPerformTMI.Click += new System.EventHandler(this.PerformancesTMI_Click);
            // 
            // manageAthletesTMI
            // 
            this.manageAthletesTMI.Name = "manageAthletesTMI";
            this.manageAthletesTMI.Size = new System.Drawing.Size(201, 26);
            this.manageAthletesTMI.Text = "Add Athletes";
            this.manageAthletesTMI.Click += new System.EventHandler(this.ManageAthletesTMI_Click);
            // 
            // manageMeetsTMI
            // 
            this.manageMeetsTMI.Name = "manageMeetsTMI";
            this.manageMeetsTMI.Size = new System.Drawing.Size(201, 26);
            this.manageMeetsTMI.Text = "Meets";
            this.manageMeetsTMI.Click += new System.EventHandler(this.ManageMeetsTMI_Click);
            // 
            // teamManagerTMI
            // 
            this.teamManagerTMI.Name = "teamManagerTMI";
            this.teamManagerTMI.Size = new System.Drawing.Size(201, 26);
            this.teamManagerTMI.Text = "Teams";
            this.teamManagerTMI.Click += new System.EventHandler(this.ManageTeamsTMI_Click);
            // 
            // toolMenuView
            // 
            this.toolMenuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rosterTMI,
            this.viewPerformTMI,
            this.meetPDFTMI,
            this.schoolRecordsTMI});
            this.toolMenuView.Name = "toolMenuView";
            this.toolMenuView.Size = new System.Drawing.Size(53, 24);
            this.toolMenuView.Text = "View";
            // 
            // rosterTMI
            // 
            this.rosterTMI.Name = "rosterTMI";
            this.rosterTMI.Size = new System.Drawing.Size(186, 26);
            this.rosterTMI.Text = "Roster";
            this.rosterTMI.Click += new System.EventHandler(this.RosterTMI_Click);
            // 
            // viewPerformTMI
            // 
            this.viewPerformTMI.Enabled = false;
            this.viewPerformTMI.Name = "viewPerformTMI";
            this.viewPerformTMI.Size = new System.Drawing.Size(186, 26);
            this.viewPerformTMI.Text = "Performances";
            // 
            // meetPDFTMI
            // 
            this.meetPDFTMI.Enabled = false;
            this.meetPDFTMI.Name = "meetPDFTMI";
            this.meetPDFTMI.Size = new System.Drawing.Size(186, 26);
            this.meetPDFTMI.Text = "Meet PDF";
            // 
            // schoolRecordsTMI
            // 
            this.schoolRecordsTMI.Enabled = false;
            this.schoolRecordsTMI.Name = "schoolRecordsTMI";
            this.schoolRecordsTMI.Size = new System.Drawing.Size(186, 26);
            this.schoolRecordsTMI.Text = "School Records";
            // 
            // menuHome
            // 
            this.menuHome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuHome.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolMenuProgram,
            this.toolMenuView,
            this.workoutsToolStripMenuItem});
            this.menuHome.Location = new System.Drawing.Point(0, 0);
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(1235, 28);
            this.menuHome.TabIndex = 4;
            this.menuHome.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileTMI,
            this.changeTeamTMI,
            this.switchUserTMI,
            this.newOrgTMI,
            this.exitTMI});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // profileTMI
            // 
            this.profileTMI.Enabled = false;
            this.profileTMI.Name = "profileTMI";
            this.profileTMI.Size = new System.Drawing.Size(217, 26);
            this.profileTMI.Text = "Profile";
            // 
            // changeTeamTMI
            // 
            this.changeTeamTMI.Name = "changeTeamTMI";
            this.changeTeamTMI.Size = new System.Drawing.Size(217, 26);
            this.changeTeamTMI.Text = "Change Team";
            // 
            // switchUserTMI
            // 
            this.switchUserTMI.Name = "switchUserTMI";
            this.switchUserTMI.Size = new System.Drawing.Size(217, 26);
            this.switchUserTMI.Text = "Switch User";
            this.switchUserTMI.Click += new System.EventHandler(this.SwitchUserTMI_Click);
            // 
            // newOrgTMI
            // 
            this.newOrgTMI.Name = "newOrgTMI";
            this.newOrgTMI.Size = new System.Drawing.Size(217, 26);
            this.newOrgTMI.Text = "Create Organization";
            this.newOrgTMI.Click += new System.EventHandler(this.NewOrgTMI_Click);
            // 
            // exitTMI
            // 
            this.exitTMI.Name = "exitTMI";
            this.exitTMI.Size = new System.Drawing.Size(217, 26);
            this.exitTMI.Text = "Exit";
            this.exitTMI.Click += new System.EventHandler(this.ExitTMI_Click);
            // 
            // workoutsToolStripMenuItem
            // 
            this.workoutsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LiftingTMI,
            this.practiceTMI});
            this.workoutsToolStripMenuItem.Name = "workoutsToolStripMenuItem";
            this.workoutsToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.workoutsToolStripMenuItem.Text = "Workouts";
            // 
            // LiftingTMI
            // 
            this.LiftingTMI.Name = "LiftingTMI";
            this.LiftingTMI.Size = new System.Drawing.Size(171, 26);
            this.LiftingTMI.Text = "Lift Workouts";
            this.LiftingTMI.Click += new System.EventHandler(this.LiftingTMI_Click);
            // 
            // practiceTMI
            // 
            this.practiceTMI.Enabled = false;
            this.practiceTMI.Name = "practiceTMI";
            this.practiceTMI.Size = new System.Drawing.Size(171, 26);
            this.practiceTMI.Text = "Practice";
            // 
            // activateNewSportTMI
            // 
            this.activateNewSportTMI.Name = "activateNewSportTMI";
            this.activateNewSportTMI.Size = new System.Drawing.Size(32, 19);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1235, 654);
            this.Controls.Add(this.menuHome);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuHome;
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuHome.ResumeLayout(false);
            this.menuHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolMenuProgram;
        private System.Windows.Forms.ToolStripMenuItem teamManagerTMI;
        private System.Windows.Forms.ToolStripMenuItem manageMeetsTMI;
        private System.Windows.Forms.ToolStripMenuItem toolMenuView;
        private System.Windows.Forms.ToolStripMenuItem meetPDFTMI;
        private System.Windows.Forms.ToolStripMenuItem schoolRecordsTMI;
        private System.Windows.Forms.MenuStrip menuHome;
        private System.Windows.Forms.ToolStripMenuItem activateNewSportTMI;
        private System.Windows.Forms.ToolStripMenuItem manageAthletesTMI;
        private System.Windows.Forms.ToolStripMenuItem rosterTMI;
        private System.Windows.Forms.ToolStripMenuItem newPerformTMI;
        private System.Windows.Forms.ToolStripMenuItem workoutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LiftingTMI;
        private System.Windows.Forms.ToolStripMenuItem viewPerformTMI;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileTMI;
        private System.Windows.Forms.ToolStripMenuItem changeTeamTMI;
        private System.Windows.Forms.ToolStripMenuItem switchUserTMI;
        private System.Windows.Forms.ToolStripMenuItem exitTMI;
        private System.Windows.Forms.ToolStripMenuItem practiceTMI;
        private System.Windows.Forms.ToolStripMenuItem newOrgTMI;
    }
}