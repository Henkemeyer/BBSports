namespace BBSports
{
    partial class Roster
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
            this.dgRoster = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAthleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AthleteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Captain = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Eligibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoster)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgRoster
            // 
            this.dgRoster.AllowUserToDeleteRows = false;
            this.dgRoster.AllowUserToOrderColumns = true;
            this.dgRoster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgRoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRoster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AthleteId,
            this.FullName,
            this.Status,
            this.Position,
            this.Captain,
            this.Eligibility});
            this.dgRoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRoster.Location = new System.Drawing.Point(0, 28);
            this.dgRoster.Name = "dgRoster";
            this.dgRoster.RowTemplate.Height = 24;
            this.dgRoster.Size = new System.Drawing.Size(1188, 641);
            this.dgRoster.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1188, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAthleteToolStripMenuItem,
            this.addColumnToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addAthleteToolStripMenuItem
            // 
            this.addAthleteToolStripMenuItem.Name = "addAthleteToolStripMenuItem";
            this.addAthleteToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.addAthleteToolStripMenuItem.Text = "Add Athlete";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // addColumnToolStripMenuItem
            // 
            this.addColumnToolStripMenuItem.Name = "addColumnToolStripMenuItem";
            this.addColumnToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.addColumnToolStripMenuItem.Text = "Add Column";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumniToolStripMenuItem,
            this.cutToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // alumniToolStripMenuItem
            // 
            this.alumniToolStripMenuItem.CheckOnClick = true;
            this.alumniToolStripMenuItem.Name = "alumniToolStripMenuItem";
            this.alumniToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.alumniToolStripMenuItem.Text = "Alumni";
            this.alumniToolStripMenuItem.CheckedChanged += new System.EventHandler(this.AlumniToolStripMenuItem_CheckedChanged);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.CheckOnClick = true;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.CheckedChanged += new System.EventHandler(this.CutToolStripMenuItem_CheckedChanged);
            // 
            // AthleteId
            // 
            this.AthleteId.DataPropertyName = "AthleteId";
            this.AthleteId.HeaderText = "Athlete Id";
            this.AthleteId.Name = "AthleteId";
            this.AthleteId.ReadOnly = true;
            this.AthleteId.Width = 96;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 74;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 54;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.Width = 87;
            // 
            // Captain
            // 
            this.Captain.DataPropertyName = "Captain";
            this.Captain.HeaderText = "Captain";
            this.Captain.Name = "Captain";
            this.Captain.Width = 62;
            // 
            // Eligibility
            // 
            this.Eligibility.DataPropertyName = "Eligibility";
            this.Eligibility.HeaderText = "Eligibility";
            this.Eligibility.Name = "Eligibility";
            this.Eligibility.ReadOnly = true;
            this.Eligibility.Width = 91;
            // 
            // Roster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 669);
            this.ControlBox = false;
            this.Controls.Add(this.dgRoster);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Roster";
            this.Text = "Roster";
            this.Load += new System.EventHandler(this.Roster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRoster)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRoster;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAthleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn AthleteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Captain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eligibility;
    }
}