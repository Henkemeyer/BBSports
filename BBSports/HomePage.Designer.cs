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
            this.activateNewSportTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTeamTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMeetsTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.meetPDFTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.athletesTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolRecordsTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHome = new System.Windows.Forms.MenuStrip();
            this.menuHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolMenuProgram
            // 
            this.toolMenuProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activateNewSportTMI,
            this.changeTeamTMI,
            this.manageMeetsTMI,
            this.exitTMI});
            this.toolMenuProgram.Name = "toolMenuProgram";
            this.toolMenuProgram.Size = new System.Drawing.Size(78, 24);
            this.toolMenuProgram.Text = "Program";
            // 
            // activateNewSportTMI
            // 
            this.activateNewSportTMI.Name = "activateNewSportTMI";
            this.activateNewSportTMI.Size = new System.Drawing.Size(212, 26);
            this.activateNewSportTMI.Text = "Activate New Sport";
            this.activateNewSportTMI.Click += new System.EventHandler(this.ActivateNewSportTMI_Click);
            // 
            // changeTeamTMI
            // 
            this.changeTeamTMI.Name = "changeTeamTMI";
            this.changeTeamTMI.Size = new System.Drawing.Size(212, 26);
            this.changeTeamTMI.Text = "Change Team";
            // 
            // manageMeetsTMI
            // 
            this.manageMeetsTMI.Name = "manageMeetsTMI";
            this.manageMeetsTMI.Size = new System.Drawing.Size(212, 26);
            this.manageMeetsTMI.Text = "Manage Meets";
            this.manageMeetsTMI.Click += new System.EventHandler(this.ManageMeetsTMI_Click);
            // 
            // exitTMI
            // 
            this.exitTMI.Name = "exitTMI";
            this.exitTMI.Size = new System.Drawing.Size(212, 26);
            this.exitTMI.Text = "Exit";
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
            // menuHome
            // 
            this.menuHome.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuProgram,
            this.toolMenuView});
            this.menuHome.Location = new System.Drawing.Point(0, 0);
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(1235, 28);
            this.menuHome.TabIndex = 4;
            this.menuHome.Text = "menuStrip1";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 654);
            this.Controls.Add(this.menuHome);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuHome;
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuHome.ResumeLayout(false);
            this.menuHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolMenuProgram;
        private System.Windows.Forms.ToolStripMenuItem activateNewSportTMI;
        private System.Windows.Forms.ToolStripMenuItem changeTeamTMI;
        private System.Windows.Forms.ToolStripMenuItem manageMeetsTMI;
        private System.Windows.Forms.ToolStripMenuItem exitTMI;
        private System.Windows.Forms.ToolStripMenuItem toolMenuView;
        private System.Windows.Forms.ToolStripMenuItem meetPDFTMI;
        private System.Windows.Forms.ToolStripMenuItem athletesTMI;
        private System.Windows.Forms.ToolStripMenuItem schoolRecordsTMI;
        private System.Windows.Forms.MenuStrip menuHome;
    }
}