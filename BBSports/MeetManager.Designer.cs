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
            this.lPastMeets = new System.Windows.Forms.Label();
            this.dgPastMeets = new System.Windows.Forms.DataGridView();
            this.tbMeetName = new System.Windows.Forms.TextBox();
            this.lLocation = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lTemperature = new System.Windows.Forms.Label();
            this.numericTemperature = new System.Windows.Forms.NumericUpDown();
            this.lNotes = new System.Windows.Forms.Label();
            this.richTBMeetNotes = new System.Windows.Forms.RichTextBox();
            this.lWeatherNotes = new System.Windows.Forms.Label();
            this.richTBWeatherNotes = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPastMeets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // lPastMeets
            // 
            this.lPastMeets.AutoSize = true;
            this.lPastMeets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPastMeets.Location = new System.Drawing.Point(57, 27);
            this.lPastMeets.Name = "lPastMeets";
            this.lPastMeets.Size = new System.Drawing.Size(138, 29);
            this.lPastMeets.TabIndex = 0;
            this.lPastMeets.Text = "Past Meets:";
            // 
            // dgPastMeets
            // 
            this.dgPastMeets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgPastMeets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPastMeets.Location = new System.Drawing.Point(26, 69);
            this.dgPastMeets.Name = "dgPastMeets";
            this.dgPastMeets.RowTemplate.Height = 24;
            this.dgPastMeets.Size = new System.Drawing.Size(294, 523);
            this.dgPastMeets.TabIndex = 1;
            // 
            // tbMeetName
            // 
            this.tbMeetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMeetName.Location = new System.Drawing.Point(398, 47);
            this.tbMeetName.Name = "tbMeetName";
            this.tbMeetName.Size = new System.Drawing.Size(444, 34);
            this.tbMeetName.TabIndex = 2;
            this.tbMeetName.Text = "Meet Name";
            this.tbMeetName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lLocation
            // 
            this.lLocation.AutoSize = true;
            this.lLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLocation.Location = new System.Drawing.Point(356, 117);
            this.lLocation.Name = "lLocation";
            this.lLocation.Size = new System.Drawing.Size(78, 20);
            this.lLocation.TabIndex = 3;
            this.lLocation.Text = "Location:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(360, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(516, 26);
            this.textBox1.TabIndex = 4;
            // 
            // lTemperature
            // 
            this.lTemperature.AutoSize = true;
            this.lTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTemperature.Location = new System.Drawing.Point(356, 208);
            this.lTemperature.Name = "lTemperature";
            this.lTemperature.Size = new System.Drawing.Size(109, 20);
            this.lTemperature.TabIndex = 5;
            this.lTemperature.Text = "Temperature:";
            // 
            // numericTemperature
            // 
            this.numericTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTemperature.Location = new System.Drawing.Point(536, 202);
            this.numericTemperature.Name = "numericTemperature";
            this.numericTemperature.Size = new System.Drawing.Size(120, 26);
            this.numericTemperature.TabIndex = 6;
            // 
            // lNotes
            // 
            this.lNotes.AutoSize = true;
            this.lNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNotes.Location = new System.Drawing.Point(356, 403);
            this.lNotes.Name = "lNotes";
            this.lNotes.Size = new System.Drawing.Size(100, 20);
            this.lNotes.TabIndex = 7;
            this.lNotes.Text = "Meet Notes:";
            // 
            // richTBMeetNotes
            // 
            this.richTBMeetNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTBMeetNotes.Location = new System.Drawing.Point(360, 437);
            this.richTBMeetNotes.Name = "richTBMeetNotes";
            this.richTBMeetNotes.Size = new System.Drawing.Size(516, 143);
            this.richTBMeetNotes.TabIndex = 8;
            this.richTBMeetNotes.Text = "";
            // 
            // lWeatherNotes
            // 
            this.lWeatherNotes.AutoSize = true;
            this.lWeatherNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWeatherNotes.Location = new System.Drawing.Point(356, 249);
            this.lWeatherNotes.Name = "lWeatherNotes";
            this.lWeatherNotes.Size = new System.Drawing.Size(126, 20);
            this.lWeatherNotes.TabIndex = 10;
            this.lWeatherNotes.Text = "Weather Notes:";
            // 
            // richTBWeatherNotes
            // 
            this.richTBWeatherNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTBWeatherNotes.Location = new System.Drawing.Point(360, 284);
            this.richTBWeatherNotes.Name = "richTBWeatherNotes";
            this.richTBWeatherNotes.Size = new System.Drawing.Size(516, 96);
            this.richTBWeatherNotes.TabIndex = 11;
            this.richTBWeatherNotes.Text = "";
            // 
            // MeetManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 615);
            this.Controls.Add(this.richTBWeatherNotes);
            this.Controls.Add(this.lWeatherNotes);
            this.Controls.Add(this.richTBMeetNotes);
            this.Controls.Add(this.lNotes);
            this.Controls.Add(this.numericTemperature);
            this.Controls.Add(this.lTemperature);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lLocation);
            this.Controls.Add(this.tbMeetName);
            this.Controls.Add(this.dgPastMeets);
            this.Controls.Add(this.lPastMeets);
            this.Name = "MeetManager";
            this.Text = "Meet Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgPastMeets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTemperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPastMeets;
        private System.Windows.Forms.DataGridView dgPastMeets;
        private System.Windows.Forms.TextBox tbMeetName;
        private System.Windows.Forms.Label lLocation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lTemperature;
        private System.Windows.Forms.NumericUpDown numericTemperature;
        private System.Windows.Forms.Label lNotes;
        private System.Windows.Forms.RichTextBox richTBMeetNotes;
        private System.Windows.Forms.Label lWeatherNotes;
        private System.Windows.Forms.RichTextBox richTBWeatherNotes;
    }
}