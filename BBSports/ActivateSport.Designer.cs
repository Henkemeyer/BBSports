namespace BBSports
{
    partial class ActivateSport
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
            this.lSportName = new System.Windows.Forms.Label();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lSeason = new System.Windows.Forms.Label();
            this.lLevel = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.tbOther = new System.Windows.Forms.TextBox();
            this.lOther = new System.Windows.Forms.Label();
            this.lTeamName = new System.Windows.Forms.Label();
            this.tbTeamName = new System.Windows.Forms.TextBox();
            this.cbSports = new System.Windows.Forms.ComboBox();
            this.bActivate = new System.Windows.Forms.Button();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lSportName
            // 
            this.lSportName.AutoSize = true;
            this.lSportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSportName.Location = new System.Drawing.Point(33, 33);
            this.lSportName.Name = "lSportName";
            this.lSportName.Size = new System.Drawing.Size(54, 20);
            this.lSportName.TabIndex = 0;
            this.lSportName.Text = "Sport:";
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.Location = new System.Drawing.Point(25, 168);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(409, 77);
            this.gbGender.TabIndex = 1;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender:";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(198, 38);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(66, 24);
            this.rbMale.TabIndex = 1;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Checked = true;
            this.rbFemale.Location = new System.Drawing.Point(24, 38);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(85, 24);
            this.rbFemale.TabIndex = 0;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fall",
            "Winter",
            "Spring",
            "Summer",
            "All-Year"});
            this.comboBox1.Location = new System.Drawing.Point(161, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // lSeason
            // 
            this.lSeason.AutoSize = true;
            this.lSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSeason.Location = new System.Drawing.Point(33, 116);
            this.lSeason.Name = "lSeason";
            this.lSeason.Size = new System.Drawing.Size(70, 20);
            this.lSeason.TabIndex = 4;
            this.lSeason.Text = "Season:";
            // 
            // lLevel
            // 
            this.lLevel.AutoSize = true;
            this.lLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLevel.Location = new System.Drawing.Point(33, 271);
            this.lLevel.Name = "lLevel";
            this.lLevel.Size = new System.Drawing.Size(54, 20);
            this.lLevel.TabIndex = 5;
            this.lLevel.Text = "Level:";
            // 
            // cbLevel
            // 
            this.cbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Club",
            "Division I",
            "Division II",
            "Division III",
            "High School",
            "Middle School",
            "Premier Club",
            "Recreation",
            "(Other)"});
            this.cbLevel.Location = new System.Drawing.Point(161, 268);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(273, 28);
            this.cbLevel.TabIndex = 6;
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.Level_SelectedIndexChanged);
            // 
            // tbOther
            // 
            this.tbOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOther.Location = new System.Drawing.Point(161, 316);
            this.tbOther.Name = "tbOther";
            this.tbOther.Size = new System.Drawing.Size(273, 26);
            this.tbOther.TabIndex = 7;
            this.tbOther.Visible = false;
            // 
            // lOther
            // 
            this.lOther.AutoSize = true;
            this.lOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOther.Location = new System.Drawing.Point(33, 319);
            this.lOther.Name = "lOther";
            this.lOther.Size = new System.Drawing.Size(77, 20);
            this.lOther.TabIndex = 9;
            this.lOther.Text = "*If Other*";
            this.lOther.Visible = false;
            // 
            // lTeamName
            // 
            this.lTeamName.AutoSize = true;
            this.lTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTeamName.Location = new System.Drawing.Point(33, 76);
            this.lTeamName.Name = "lTeamName";
            this.lTeamName.Size = new System.Drawing.Size(105, 20);
            this.lTeamName.TabIndex = 10;
            this.lTeamName.Text = "Team Name:";
            // 
            // tbTeamName
            // 
            this.tbTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTeamName.Location = new System.Drawing.Point(161, 73);
            this.tbTeamName.Name = "tbTeamName";
            this.tbTeamName.Size = new System.Drawing.Size(250, 26);
            this.tbTeamName.TabIndex = 11;
            // 
            // cbSports
            // 
            this.cbSports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSports.FormattingEnabled = true;
            this.cbSports.Location = new System.Drawing.Point(161, 33);
            this.cbSports.Name = "cbSports";
            this.cbSports.Size = new System.Drawing.Size(250, 28);
            this.cbSports.TabIndex = 12;
            this.cbSports.SelectedIndexChanged += new System.EventHandler(this.Sports_SelectedIndexChanged);
            // 
            // bActivate
            // 
            this.bActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bActivate.Location = new System.Drawing.Point(173, 360);
            this.bActivate.Name = "bActivate";
            this.bActivate.Size = new System.Drawing.Size(116, 38);
            this.bActivate.TabIndex = 13;
            this.bActivate.Text = "Activate";
            this.bActivate.UseVisualStyleBackColor = true;
            // 
            // ActivateSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 420);
            this.Controls.Add(this.bActivate);
            this.Controls.Add(this.cbSports);
            this.Controls.Add(this.tbTeamName);
            this.Controls.Add(this.lTeamName);
            this.Controls.Add(this.lOther);
            this.Controls.Add(this.tbOther);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.lLevel);
            this.Controls.Add(this.lSeason);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.lSportName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActivateSport";
            this.Text = "Activate New Sport";
            this.TopMost = true;
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lSportName;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lSeason;
        private System.Windows.Forms.Label lLevel;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.TextBox tbOther;
        private System.Windows.Forms.Label lOther;
        private System.Windows.Forms.Label lTeamName;
        private System.Windows.Forms.TextBox tbTeamName;
        private System.Windows.Forms.ComboBox cbSports;
        private System.Windows.Forms.Button bActivate;
    }
}