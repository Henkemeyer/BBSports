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
            this.dgvCoaches = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDirectory = new System.Windows.Forms.Button();
            this.bNewCoach = new System.Windows.Forms.Button();
            this.ttNewCoach = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoaches)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCoaches
            // 
            this.dgvCoaches.AllowUserToOrderColumns = true;
            this.dgvCoaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoaches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId});
            this.dgvCoaches.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCoaches.Location = new System.Drawing.Point(0, 0);
            this.dgvCoaches.Name = "dgvCoaches";
            this.dgvCoaches.RowTemplate.Height = 24;
            this.dgvCoaches.Size = new System.Drawing.Size(1242, 459);
            this.dgvCoaches.TabIndex = 0;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "Coach Id";
            this.UserId.Name = "UserId";
            // 
            // bDirectory
            // 
            this.bDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDirectory.Location = new System.Drawing.Point(389, 485);
            this.bDirectory.Name = "bDirectory";
            this.bDirectory.Size = new System.Drawing.Size(116, 36);
            this.bDirectory.TabIndex = 1;
            this.bDirectory.Text = "Directory";
            this.bDirectory.UseVisualStyleBackColor = true;
            this.bDirectory.Click += new System.EventHandler(this.Directory_Click);
            // 
            // bNewCoach
            // 
            this.bNewCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNewCoach.Location = new System.Drawing.Point(676, 485);
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
            // Coaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 539);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.Button bDirectory;
        private System.Windows.Forms.Button bNewCoach;
        private System.Windows.Forms.ToolTip ttNewCoach;
    }
}