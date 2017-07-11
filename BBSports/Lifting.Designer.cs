namespace BBSports
{
    partial class Lifting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAndContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcLifting = new System.Windows.Forms.TabControl();
            this.tpNewLift = new System.Windows.Forms.TabPage();
            this.mcWorkouts = new System.Windows.Forms.MonthCalendar();
            this.lbAthletes = new System.Windows.Forms.ListBox();
            this.cbGroups = new System.Windows.Forms.ComboBox();
            this.dgWorkout = new System.Windows.Forms.DataGridView();
            this.LiftName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Effort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpGroups = new System.Windows.Forms.TabPage();
            this.flpGroups = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpDefault = new System.Windows.Forms.TableLayoutPanel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.tlpUnassigned = new System.Windows.Forms.TableLayoutPanel();
            this.lAthletes = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tcLifting.SuspendLayout();
            this.tpNewLift.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkout)).BeginInit();
            this.tpGroups.SuspendLayout();
            this.flpGroups.SuspendLayout();
            this.tlpDefault.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1721, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAndContToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAndContToolStripMenuItem
            // 
            this.saveAndContToolStripMenuItem.Name = "saveAndContToolStripMenuItem";
            this.saveAndContToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.saveAndContToolStripMenuItem.Text = "Save and Cont.";
            // 
            // tcLifting
            // 
            this.tcLifting.Controls.Add(this.tpNewLift);
            this.tcLifting.Controls.Add(this.tpGroups);
            this.tcLifting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcLifting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcLifting.Location = new System.Drawing.Point(0, 28);
            this.tcLifting.Name = "tcLifting";
            this.tcLifting.SelectedIndex = 0;
            this.tcLifting.Size = new System.Drawing.Size(1721, 793);
            this.tcLifting.TabIndex = 6;
            // 
            // tpNewLift
            // 
            this.tpNewLift.Controls.Add(this.mcWorkouts);
            this.tpNewLift.Controls.Add(this.lbAthletes);
            this.tpNewLift.Controls.Add(this.cbGroups);
            this.tpNewLift.Controls.Add(this.dgWorkout);
            this.tpNewLift.Location = new System.Drawing.Point(4, 27);
            this.tpNewLift.Name = "tpNewLift";
            this.tpNewLift.Padding = new System.Windows.Forms.Padding(3);
            this.tpNewLift.Size = new System.Drawing.Size(1713, 762);
            this.tpNewLift.TabIndex = 0;
            this.tpNewLift.Text = "New Lift";
            this.tpNewLift.UseVisualStyleBackColor = true;
            // 
            // mcWorkouts
            // 
            this.mcWorkouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcWorkouts.Location = new System.Drawing.Point(864, 19);
            this.mcWorkouts.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.mcWorkouts.MaxSelectionCount = 10;
            this.mcWorkouts.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.mcWorkouts.Name = "mcWorkouts";
            this.mcWorkouts.ShowWeekNumbers = true;
            this.mcWorkouts.TabIndex = 8;
            // 
            // lbAthletes
            // 
            this.lbAthletes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAthletes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAthletes.FormattingEnabled = true;
            this.lbAthletes.ItemHeight = 20;
            this.lbAthletes.Location = new System.Drawing.Point(1232, 82);
            this.lbAthletes.Name = "lbAthletes";
            this.lbAthletes.Size = new System.Drawing.Size(448, 644);
            this.lbAthletes.TabIndex = 7;
            // 
            // cbGroups
            // 
            this.cbGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGroups.FormattingEnabled = true;
            this.cbGroups.Location = new System.Drawing.Point(1232, 19);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.Size = new System.Drawing.Size(448, 33);
            this.cbGroups.TabIndex = 6;
            this.cbGroups.SelectedIndexChanged += new System.EventHandler(this.Groups_SelectedIndexChanged);
            // 
            // dgWorkout
            // 
            this.dgWorkout.AllowUserToOrderColumns = true;
            this.dgWorkout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWorkout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LiftName,
            this.Effort,
            this.Sets,
            this.Reps,
            this.URL});
            this.dgWorkout.Location = new System.Drawing.Point(8, 19);
            this.dgWorkout.Name = "dgWorkout";
            this.dgWorkout.RowTemplate.Height = 24;
            this.dgWorkout.Size = new System.Drawing.Size(784, 722);
            this.dgWorkout.TabIndex = 5;
            // 
            // LiftName
            // 
            this.LiftName.HeaderText = "Lift";
            this.LiftName.MaxInputLength = 25;
            this.LiftName.Name = "LiftName";
            this.LiftName.Width = 200;
            // 
            // Effort
            // 
            this.Effort.HeaderText = "Effort";
            this.Effort.MaxInputLength = 10;
            this.Effort.Name = "Effort";
            // 
            // Sets
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "1";
            this.Sets.DefaultCellStyle = dataGridViewCellStyle1;
            this.Sets.HeaderText = "Sets";
            this.Sets.MaxInputLength = 3;
            this.Sets.Name = "Sets";
            this.Sets.ToolTipText = "Number of sets for Lift";
            this.Sets.Width = 50;
            // 
            // Reps
            // 
            this.Reps.HeaderText = "Reps";
            this.Reps.MaxInputLength = 10;
            this.Reps.Name = "Reps";
            this.Reps.Width = 50;
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.ToolTipText = "Add a link for a help video";
            this.URL.Width = 300;
            // 
            // tpGroups
            // 
            this.tpGroups.Controls.Add(this.flpGroups);
            this.tpGroups.Controls.Add(this.tlpUnassigned);
            this.tpGroups.Controls.Add(this.lAthletes);
            this.tpGroups.Location = new System.Drawing.Point(4, 27);
            this.tpGroups.Name = "tpGroups";
            this.tpGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tpGroups.Size = new System.Drawing.Size(1713, 762);
            this.tpGroups.TabIndex = 1;
            this.tpGroups.Text = "Manage Groups";
            this.tpGroups.UseVisualStyleBackColor = true;
            // 
            // flpGroups
            // 
            this.flpGroups.Controls.Add(this.tlpDefault);
            this.flpGroups.Location = new System.Drawing.Point(321, 23);
            this.flpGroups.Name = "flpGroups";
            this.flpGroups.Padding = new System.Windows.Forms.Padding(7);
            this.flpGroups.Size = new System.Drawing.Size(1384, 731);
            this.flpGroups.TabIndex = 12;
            // 
            // tlpDefault
            // 
            this.tlpDefault.BackColor = System.Drawing.Color.LightGray;
            this.tlpDefault.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpDefault.ColumnCount = 2;
            this.tlpDefault.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.tlpDefault.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlpDefault.Controls.Add(this.tbName, 0, 0);
            this.tlpDefault.Controls.Add(this.bDelete, 1, 0);
            this.tlpDefault.Location = new System.Drawing.Point(10, 10);
            this.tlpDefault.Name = "tlpDefault";
            this.tlpDefault.RowCount = 1;
            this.tlpDefault.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDefault.Size = new System.Drawing.Size(237, 233);
            this.tlpDefault.TabIndex = 11;
            this.tlpDefault.Visible = false;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(4, 4);
            this.tbName.MaxLength = 25;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(188, 26);
            this.tbName.TabIndex = 7;
            this.tbName.Visible = false;
            this.tbName.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.Red;
            this.bDelete.Location = new System.Drawing.Point(199, 4);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(34, 29);
            this.bDelete.TabIndex = 8;
            this.bDelete.Text = "X";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Visible = false;
            // 
            // tlpUnassigned
            // 
            this.tlpUnassigned.AccessibleDescription = "";
            this.tlpUnassigned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tlpUnassigned.BackColor = System.Drawing.Color.LightGray;
            this.tlpUnassigned.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpUnassigned.ColumnCount = 1;
            this.tlpUnassigned.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUnassigned.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUnassigned.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpUnassigned.Location = new System.Drawing.Point(8, 60);
            this.tlpUnassigned.Name = "tlpUnassigned";
            this.tlpUnassigned.RowCount = 1;
            this.tlpUnassigned.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUnassigned.Size = new System.Drawing.Size(282, 664);
            this.tlpUnassigned.TabIndex = 10;
            // 
            // lAthletes
            // 
            this.lAthletes.AutoSize = true;
            this.lAthletes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAthletes.Location = new System.Drawing.Point(98, 23);
            this.lAthletes.Name = "lAthletes";
            this.lAthletes.Size = new System.Drawing.Size(83, 25);
            this.lAthletes.TabIndex = 5;
            this.lAthletes.Text = "Athletes";
            // 
            // Lifting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1721, 821);
            this.ControlBox = false;
            this.Controls.Add(this.tcLifting);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lifting";
            this.Text = "Lifting";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tcLifting.ResumeLayout(false);
            this.tpNewLift.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkout)).EndInit();
            this.tpGroups.ResumeLayout(false);
            this.tpGroups.PerformLayout();
            this.flpGroups.ResumeLayout(false);
            this.tlpDefault.ResumeLayout(false);
            this.tlpDefault.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAndContToolStripMenuItem;
        private System.Windows.Forms.TabControl tcLifting;
        private System.Windows.Forms.TabPage tpNewLift;
        private System.Windows.Forms.MonthCalendar mcWorkouts;
        private System.Windows.Forms.ListBox lbAthletes;
        private System.Windows.Forms.ComboBox cbGroups;
        private System.Windows.Forms.DataGridView dgWorkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiftName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Effort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sets;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reps;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.TabPage tpGroups;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lAthletes;
        private System.Windows.Forms.TableLayoutPanel tlpUnassigned;
        private System.Windows.Forms.TableLayoutPanel tlpDefault;
        private System.Windows.Forms.FlowLayoutPanel flpGroups;
    }
}