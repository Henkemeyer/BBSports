namespace BBSports
{
    partial class Coaches
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCoaches = new System.Windows.Forms.DataGridView();
            this.bDirectory = new System.Windows.Forms.Button();
            this.bNewCoach = new System.Windows.Forms.Button();
            this.ttNewCoach = new System.Windows.Forms.ToolTip(this.components);
            this.Change = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TeamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoaches)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCoaches
            // 
            this.dgvCoaches.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCoaches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCoaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoaches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Change,
            this.TeamId,
            this.TeamName,
            this.UserId,
            this.FullName,
            this.Email,
            this.Phone,
            this.Position});
            this.dgvCoaches.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCoaches.Location = new System.Drawing.Point(0, 0);
            this.dgvCoaches.MultiSelect = false;
            this.dgvCoaches.Name = "dgvCoaches";
            this.dgvCoaches.RowTemplate.Height = 24;
            this.dgvCoaches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCoaches.Size = new System.Drawing.Size(1242, 735);
            this.dgvCoaches.TabIndex = 0;
            // 
            // bDirectory
            // 
            this.bDirectory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDirectory.Location = new System.Drawing.Point(387, 788);
            this.bDirectory.Name = "bDirectory";
            this.bDirectory.Size = new System.Drawing.Size(116, 36);
            this.bDirectory.TabIndex = 1;
            this.bDirectory.Text = "Directory";
            this.bDirectory.UseVisualStyleBackColor = true;
            this.bDirectory.Click += new System.EventHandler(this.Directory_Click);
            // 
            // bNewCoach
            // 
            this.bNewCoach.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bNewCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNewCoach.Location = new System.Drawing.Point(692, 788);
            this.bNewCoach.Name = "bNewCoach";
            this.bNewCoach.Size = new System.Drawing.Size(118, 36);
            this.bNewCoach.TabIndex = 2;
            this.bNewCoach.Text = "New Coach";
            this.bNewCoach.UseVisualStyleBackColor = true;
            this.bNewCoach.Click += new System.EventHandler(this.NewCoach_Click);
            // 
            // ttNewCoach
            // 
            this.ttNewCoach.ToolTipTitle = "Make sure to check the Directory to see if your coach exists in the system alread" +
    "y";
            // 
            // Change
            // 
            this.Change.HeaderText = "Update";
            this.Change.Name = "Change";
            this.Change.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Change.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TeamId
            // 
            this.TeamId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeamId.DataPropertyName = "TeamId";
            this.TeamId.HeaderText = "Team Id";
            this.TeamId.Name = "TeamId";
            // 
            // TeamName
            // 
            this.TeamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeamName.DataPropertyName = "TeamName";
            this.TeamName.HeaderText = "Team";
            this.TeamName.Name = "TeamName";
            this.TeamName.ReadOnly = true;
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "Coach Id";
            this.UserId.Name = "UserId";
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FulName";
            this.FullName.HeaderText = "Name";
            this.FullName.MaxInputLength = 78;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-Mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "PhoneNumber";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Position";
            this.Position.MaxInputLength = 25;
            this.Position.Name = "Position";
            // 
            // Coaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 885);
            this.ControlBox = false;
            this.Controls.Add(this.bNewCoach);
            this.Controls.Add(this.bDirectory);
            this.Controls.Add(this.dgvCoaches);
            this.Name = "Coaches";
            this.Text = "Coaches";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoaches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCoaches;
        private System.Windows.Forms.Button bDirectory;
        private System.Windows.Forms.Button bNewCoach;
        private System.Windows.Forms.ToolTip ttNewCoach;
        private System.Windows.Forms.DataGridViewButtonColumn Change;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
    }
}