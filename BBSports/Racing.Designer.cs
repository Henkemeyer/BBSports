namespace BBSports
{
    partial class Racing
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
            this.scRacing = new System.Windows.Forms.SplitContainer();
            this.numericPlace = new System.Windows.Forms.NumericUpDown();
            this.lPlace = new System.Windows.Forms.Label();
            this.lSplits = new System.Windows.Forms.Label();
            this.bReset = new System.Windows.Forms.Button();
            this.bSubmit = new System.Windows.Forms.Button();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lMeet = new System.Windows.Forms.Label();
            this.gbSplitDistance = new System.Windows.Forms.GroupBox();
            this.rbLong = new System.Windows.Forms.RadioButton();
            this.rbShort = new System.Windows.Forms.RadioButton();
            this.cbMeet = new System.Windows.Forms.ComboBox();
            this.lAthlete = new System.Windows.Forms.Label();
            this.lEvent = new System.Windows.Forms.Label();
            this.cbAthlete = new System.Windows.Forms.ComboBox();
            this.cbEvent = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.scRacing)).BeginInit();
            this.scRacing.Panel1.SuspendLayout();
            this.scRacing.Panel2.SuspendLayout();
            this.scRacing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlace)).BeginInit();
            this.gbGender.SuspendLayout();
            this.gbSplitDistance.SuspendLayout();
            this.SuspendLayout();
            // 
            // scRacing
            // 
            this.scRacing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scRacing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRacing.IsSplitterFixed = true;
            this.scRacing.Location = new System.Drawing.Point(0, 0);
            this.scRacing.Name = "scRacing";
            // 
            // scRacing.Panel1
            // 
            this.scRacing.Panel1.Controls.Add(this.gbGender);
            this.scRacing.Panel1.Controls.Add(this.lMeet);
            this.scRacing.Panel1.Controls.Add(this.gbSplitDistance);
            this.scRacing.Panel1.Controls.Add(this.cbMeet);
            this.scRacing.Panel1.Controls.Add(this.lAthlete);
            this.scRacing.Panel1.Controls.Add(this.lEvent);
            this.scRacing.Panel1.Controls.Add(this.cbAthlete);
            this.scRacing.Panel1.Controls.Add(this.cbEvent);
            // 
            // scRacing.Panel2
            // 
            this.scRacing.Panel2.Controls.Add(this.numericPlace);
            this.scRacing.Panel2.Controls.Add(this.lPlace);
            this.scRacing.Panel2.Controls.Add(this.lSplits);
            this.scRacing.Panel2.Controls.Add(this.bReset);
            this.scRacing.Panel2.Controls.Add(this.bSubmit);
            this.scRacing.Size = new System.Drawing.Size(1151, 625);
            this.scRacing.SplitterDistance = 382;
            this.scRacing.TabIndex = 4;
            // 
            // numericPlace
            // 
            this.numericPlace.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPlace.Location = new System.Drawing.Point(435, 423);
            this.numericPlace.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPlace.Name = "numericPlace";
            this.numericPlace.Size = new System.Drawing.Size(120, 28);
            this.numericPlace.TabIndex = 10;
            // 
            // lPlace
            // 
            this.lPlace.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lPlace.AutoSize = true;
            this.lPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlace.Location = new System.Drawing.Point(221, 420);
            this.lPlace.Name = "lPlace";
            this.lPlace.Size = new System.Drawing.Size(184, 29);
            this.lPlace.TabIndex = 9;
            this.lPlace.Text = "Finishing Place:";
            // 
            // lSplits
            // 
            this.lSplits.AutoSize = true;
            this.lSplits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSplits.Location = new System.Drawing.Point(173, 83);
            this.lSplits.Name = "lSplits";
            this.lSplits.Size = new System.Drawing.Size(79, 29);
            this.lSplits.TabIndex = 8;
            this.lSplits.Text = "Splits:";
            // 
            // bReset
            // 
            this.bReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.Location = new System.Drawing.Point(270, 503);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(91, 37);
            this.bReset.TabIndex = 7;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            // 
            // bSubmit
            // 
            this.bSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubmit.Location = new System.Drawing.Point(490, 503);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(99, 37);
            this.bSubmit.TabIndex = 6;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            // 
            // gbGender
            // 
            this.gbGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.Location = new System.Drawing.Point(32, 272);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(299, 118);
            this.gbGender.TabIndex = 21;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(207, 55);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(72, 28);
            this.rbMale.TabIndex = 5;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Checked = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(21, 55);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(95, 28);
            this.rbFemale.TabIndex = 6;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // lMeet
            // 
            this.lMeet.AutoSize = true;
            this.lMeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMeet.Location = new System.Drawing.Point(39, 50);
            this.lMeet.Name = "lMeet";
            this.lMeet.Size = new System.Drawing.Size(67, 29);
            this.lMeet.TabIndex = 14;
            this.lMeet.Text = "Meet";
            // 
            // gbSplitDistance
            // 
            this.gbSplitDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSplitDistance.Controls.Add(this.rbLong);
            this.gbSplitDistance.Controls.Add(this.rbShort);
            this.gbSplitDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSplitDistance.Location = new System.Drawing.Point(32, 476);
            this.gbSplitDistance.Name = "gbSplitDistance";
            this.gbSplitDistance.Size = new System.Drawing.Size(299, 120);
            this.gbSplitDistance.TabIndex = 20;
            this.gbSplitDistance.TabStop = false;
            this.gbSplitDistance.Text = "Split Distance";
            // 
            // rbLong
            // 
            this.rbLong.AutoSize = true;
            this.rbLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLong.Location = new System.Drawing.Point(207, 59);
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
            this.rbShort.Location = new System.Drawing.Point(21, 59);
            this.rbShort.Name = "rbShort";
            this.rbShort.Size = new System.Drawing.Size(87, 28);
            this.rbShort.TabIndex = 7;
            this.rbShort.TabStop = true;
            this.rbShort.Text = "1000m";
            this.rbShort.UseVisualStyleBackColor = true;
            // 
            // cbMeet
            // 
            this.cbMeet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMeet.FormattingEnabled = true;
            this.cbMeet.Location = new System.Drawing.Point(44, 93);
            this.cbMeet.MaxDropDownItems = 16;
            this.cbMeet.Name = "cbMeet";
            this.cbMeet.Size = new System.Drawing.Size(278, 24);
            this.cbMeet.TabIndex = 15;
            // 
            // lAthlete
            // 
            this.lAthlete.AutoSize = true;
            this.lAthlete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAthlete.Location = new System.Drawing.Point(39, 393);
            this.lAthlete.Name = "lAthlete";
            this.lAthlete.Size = new System.Drawing.Size(87, 29);
            this.lAthlete.TabIndex = 19;
            this.lAthlete.Text = "Athlete";
            // 
            // lEvent
            // 
            this.lEvent.AutoSize = true;
            this.lEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEvent.Location = new System.Drawing.Point(39, 149);
            this.lEvent.Name = "lEvent";
            this.lEvent.Size = new System.Drawing.Size(73, 29);
            this.lEvent.TabIndex = 16;
            this.lEvent.Text = "Event";
            // 
            // cbAthlete
            // 
            this.cbAthlete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAthlete.FormattingEnabled = true;
            this.cbAthlete.Location = new System.Drawing.Point(44, 435);
            this.cbAthlete.Name = "cbAthlete";
            this.cbAthlete.Size = new System.Drawing.Size(278, 24);
            this.cbAthlete.TabIndex = 18;
            // 
            // cbEvent
            // 
            this.cbEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Location = new System.Drawing.Point(44, 209);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(278, 24);
            this.cbEvent.TabIndex = 17;
            // 
            // Racing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 625);
            this.ControlBox = false;
            this.Controls.Add(this.scRacing);
            this.Name = "Racing";
            this.Text = "Racing";
            this.scRacing.Panel1.ResumeLayout(false);
            this.scRacing.Panel1.PerformLayout();
            this.scRacing.Panel2.ResumeLayout(false);
            this.scRacing.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scRacing)).EndInit();
            this.scRacing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericPlace)).EndInit();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.gbSplitDistance.ResumeLayout(false);
            this.gbSplitDistance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scRacing;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lMeet;
        private System.Windows.Forms.GroupBox gbSplitDistance;
        private System.Windows.Forms.RadioButton rbLong;
        private System.Windows.Forms.RadioButton rbShort;
        private System.Windows.Forms.ComboBox cbMeet;
        private System.Windows.Forms.Label lAthlete;
        private System.Windows.Forms.Label lEvent;
        private System.Windows.Forms.ComboBox cbAthlete;
        private System.Windows.Forms.ComboBox cbEvent;
        private System.Windows.Forms.NumericUpDown numericPlace;
        private System.Windows.Forms.Label lPlace;
        private System.Windows.Forms.Label lSplits;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bSubmit;
    }
}