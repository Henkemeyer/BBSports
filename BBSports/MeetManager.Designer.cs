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
            this.scMeetManager = new System.Windows.Forms.SplitContainer();
            this.dgPastMeets = new System.Windows.Forms.DataGridView();
            this.lGenders = new System.Windows.Forms.Label();
            this.clbGenders = new System.Windows.Forms.CheckedListBox();
            this.richTBWeatherNotes = new System.Windows.Forms.RichTextBox();
            this.lWeatherNotes = new System.Windows.Forms.Label();
            this.richTBMeetNotes = new System.Windows.Forms.RichTextBox();
            this.lNotes = new System.Windows.Forms.Label();
            this.numericTemperature = new System.Windows.Forms.NumericUpDown();
            this.lTemperature = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.lLocation = new System.Windows.Forms.Label();
            this.tbMeetName = new System.Windows.Forms.TextBox();
            this.dateTP = new System.Windows.Forms.DateTimePicker();
            this.lDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scMeetManager)).BeginInit();
            this.scMeetManager.Panel1.SuspendLayout();
            this.scMeetManager.Panel2.SuspendLayout();
            this.scMeetManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPastMeets)).BeginInit();
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
            this.scMeetManager.Panel1.Controls.Add(this.dgPastMeets);
            // 
            // scMeetManager.Panel2
            // 
            this.scMeetManager.Panel2.Controls.Add(this.lDate);
            this.scMeetManager.Panel2.Controls.Add(this.dateTP);
            this.scMeetManager.Panel2.Controls.Add(this.lGenders);
            this.scMeetManager.Panel2.Controls.Add(this.clbGenders);
            this.scMeetManager.Panel2.Controls.Add(this.richTBWeatherNotes);
            this.scMeetManager.Panel2.Controls.Add(this.lWeatherNotes);
            this.scMeetManager.Panel2.Controls.Add(this.richTBMeetNotes);
            this.scMeetManager.Panel2.Controls.Add(this.lNotes);
            this.scMeetManager.Panel2.Controls.Add(this.numericTemperature);
            this.scMeetManager.Panel2.Controls.Add(this.lTemperature);
            this.scMeetManager.Panel2.Controls.Add(this.tbLocation);
            this.scMeetManager.Panel2.Controls.Add(this.lLocation);
            this.scMeetManager.Panel2.Controls.Add(this.tbMeetName);
            this.scMeetManager.Size = new System.Drawing.Size(1243, 896);
            this.scMeetManager.SplitterDistance = 435;
            this.scMeetManager.TabIndex = 7;
            // 
            // dgPastMeets
            // 
            this.dgPastMeets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPastMeets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPastMeets.Location = new System.Drawing.Point(0, 0);
            this.dgPastMeets.Name = "dgPastMeets";
            this.dgPastMeets.RowTemplate.Height = 24;
            this.dgPastMeets.Size = new System.Drawing.Size(435, 896);
            this.dgPastMeets.TabIndex = 2;
            // 
            // lGenders
            // 
            this.lGenders.AutoSize = true;
            this.lGenders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGenders.Location = new System.Drawing.Point(150, 330);
            this.lGenders.Name = "lGenders";
            this.lGenders.Size = new System.Drawing.Size(78, 20);
            this.lGenders.TabIndex = 22;
            this.lGenders.Text = "Genders:";
            // 
            // clbGenders
            // 
            this.clbGenders.BackColor = System.Drawing.SystemColors.Control;
            this.clbGenders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbGenders.FormattingEnabled = true;
            this.clbGenders.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.clbGenders.Location = new System.Drawing.Point(361, 318);
            this.clbGenders.Name = "clbGenders";
            this.clbGenders.Size = new System.Drawing.Size(145, 67);
            this.clbGenders.TabIndex = 21;
            // 
            // richTBWeatherNotes
            // 
            this.richTBWeatherNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTBWeatherNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTBWeatherNotes.Location = new System.Drawing.Point(154, 448);
            this.richTBWeatherNotes.Name = "richTBWeatherNotes";
            this.richTBWeatherNotes.Size = new System.Drawing.Size(500, 96);
            this.richTBWeatherNotes.TabIndex = 20;
            this.richTBWeatherNotes.Text = "";
            // 
            // lWeatherNotes
            // 
            this.lWeatherNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lWeatherNotes.AutoSize = true;
            this.lWeatherNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWeatherNotes.Location = new System.Drawing.Point(150, 407);
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
            this.richTBMeetNotes.Location = new System.Drawing.Point(154, 607);
            this.richTBMeetNotes.Name = "richTBMeetNotes";
            this.richTBMeetNotes.Size = new System.Drawing.Size(500, 143);
            this.richTBMeetNotes.TabIndex = 18;
            this.richTBMeetNotes.Text = "";
            // 
            // lNotes
            // 
            this.lNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lNotes.AutoSize = true;
            this.lNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNotes.Location = new System.Drawing.Point(150, 573);
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
            this.numericTemperature.Location = new System.Drawing.Point(503, 405);
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
            this.numericTemperature.Size = new System.Drawing.Size(117, 26);
            this.numericTemperature.TabIndex = 16;
            // 
            // lTemperature
            // 
            this.lTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lTemperature.AutoSize = true;
            this.lTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTemperature.Location = new System.Drawing.Point(357, 407);
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
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(500, 26);
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
            this.tbMeetName.Location = new System.Drawing.Point(192, 47);
            this.tbMeetName.Name = "tbMeetName";
            this.tbMeetName.Size = new System.Drawing.Size(428, 34);
            this.tbMeetName.TabIndex = 12;
            this.tbMeetName.Text = "Meet Name";
            this.tbMeetName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTP
            // 
            this.dateTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTP.Location = new System.Drawing.Point(361, 242);
            this.dateTP.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTP.Name = "dateTP";
            this.dateTP.Size = new System.Drawing.Size(293, 26);
            this.dateTP.TabIndex = 23;
            this.dateTP.Value = new System.DateTime(2017, 6, 22, 10, 50, 2, 0);
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.Location = new System.Drawing.Point(150, 244);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(50, 20);
            this.lDate.TabIndex = 24;
            this.lDate.Text = "Date:";
            // 
            // MeetManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 896);
            this.ControlBox = false;
            this.Controls.Add(this.scMeetManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MeetManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Meet Manager";
            this.scMeetManager.Panel1.ResumeLayout(false);
            this.scMeetManager.Panel2.ResumeLayout(false);
            this.scMeetManager.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMeetManager)).EndInit();
            this.scMeetManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPastMeets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTemperature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMeetManager;
        private System.Windows.Forms.DataGridView dgPastMeets;
        private System.Windows.Forms.RichTextBox richTBWeatherNotes;
        private System.Windows.Forms.Label lWeatherNotes;
        private System.Windows.Forms.RichTextBox richTBMeetNotes;
        private System.Windows.Forms.Label lNotes;
        private System.Windows.Forms.NumericUpDown numericTemperature;
        private System.Windows.Forms.Label lTemperature;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label lLocation;
        private System.Windows.Forms.TextBox tbMeetName;
        private System.Windows.Forms.Label lGenders;
        private System.Windows.Forms.CheckedListBox clbGenders;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.DateTimePicker dateTP;
    }
}