namespace BBSports
{
    partial class AthleteManager
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgAthletes = new System.Windows.Forms.DataGridView();
            this.lHeader = new System.Windows.Forms.Label();
            this.lFirst = new System.Windows.Forms.Label();
            this.lMiddle = new System.Windows.Forms.Label();
            this.lLast = new System.Windows.Forms.Label();
            this.lNickname = new System.Windows.Forms.Label();
            this.lBirthday = new System.Windows.Forms.Label();
            this.lNotes = new System.Windows.Forms.Label();
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.tbMiddle = new System.Windows.Forms.TextBox();
            this.dateTPBirthday = new System.Windows.Forms.DateTimePicker();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.richTBNotes = new System.Windows.Forms.RichTextBox();
            this.clbTeams = new System.Windows.Forms.CheckedListBox();
            this.lAssign = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAthletes)).BeginInit();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgAthletes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lAssign);
            this.splitContainer1.Panel2.Controls.Add(this.clbTeams);
            this.splitContainer1.Panel2.Controls.Add(this.richTBNotes);
            this.splitContainer1.Panel2.Controls.Add(this.gbGender);
            this.splitContainer1.Panel2.Controls.Add(this.dateTPBirthday);
            this.splitContainer1.Panel2.Controls.Add(this.tbMiddle);
            this.splitContainer1.Panel2.Controls.Add(this.tbLast);
            this.splitContainer1.Panel2.Controls.Add(this.tbNickname);
            this.splitContainer1.Panel2.Controls.Add(this.tbFirst);
            this.splitContainer1.Panel2.Controls.Add(this.lNotes);
            this.splitContainer1.Panel2.Controls.Add(this.lBirthday);
            this.splitContainer1.Panel2.Controls.Add(this.lNickname);
            this.splitContainer1.Panel2.Controls.Add(this.lLast);
            this.splitContainer1.Panel2.Controls.Add(this.lMiddle);
            this.splitContainer1.Panel2.Controls.Add(this.lFirst);
            this.splitContainer1.Panel2.Controls.Add(this.lHeader);
            this.splitContainer1.Size = new System.Drawing.Size(1769, 859);
            this.splitContainer1.SplitterDistance = 674;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgAthletes
            // 
            this.dgAthletes.AllowUserToAddRows = false;
            this.dgAthletes.AllowUserToDeleteRows = false;
            this.dgAthletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAthletes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAthletes.Location = new System.Drawing.Point(0, 0);
            this.dgAthletes.Name = "dgAthletes";
            this.dgAthletes.ReadOnly = true;
            this.dgAthletes.RowTemplate.Height = 24;
            this.dgAthletes.Size = new System.Drawing.Size(674, 859);
            this.dgAthletes.TabIndex = 0;
            // 
            // lHeader
            // 
            this.lHeader.AutoSize = true;
            this.lHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeader.Location = new System.Drawing.Point(50, 26);
            this.lHeader.Name = "lHeader";
            this.lHeader.Size = new System.Drawing.Size(161, 31);
            this.lHeader.TabIndex = 0;
            this.lHeader.Text = "New Athlete";
            // 
            // lFirst
            // 
            this.lFirst.AutoSize = true;
            this.lFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFirst.Location = new System.Drawing.Point(50, 81);
            this.lFirst.Name = "lFirst";
            this.lFirst.Size = new System.Drawing.Size(49, 20);
            this.lFirst.TabIndex = 1;
            this.lFirst.Text = "First*";
            // 
            // lMiddle
            // 
            this.lMiddle.AutoSize = true;
            this.lMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMiddle.Location = new System.Drawing.Point(284, 81);
            this.lMiddle.Name = "lMiddle";
            this.lMiddle.Size = new System.Drawing.Size(58, 20);
            this.lMiddle.TabIndex = 2;
            this.lMiddle.Text = "Middle";
            // 
            // lLast
            // 
            this.lLast.AutoSize = true;
            this.lLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLast.Location = new System.Drawing.Point(442, 81);
            this.lLast.Name = "lLast";
            this.lLast.Size = new System.Drawing.Size(48, 20);
            this.lLast.TabIndex = 3;
            this.lLast.Text = "Last*";
            // 
            // lNickname
            // 
            this.lNickname.AutoSize = true;
            this.lNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNickname.Location = new System.Drawing.Point(678, 81);
            this.lNickname.Name = "lNickname";
            this.lNickname.Size = new System.Drawing.Size(83, 20);
            this.lNickname.TabIndex = 4;
            this.lNickname.Text = "Nickname";
            // 
            // lBirthday
            // 
            this.lBirthday.AutoSize = true;
            this.lBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBirthday.Location = new System.Drawing.Point(52, 172);
            this.lBirthday.Name = "lBirthday";
            this.lBirthday.Size = new System.Drawing.Size(71, 20);
            this.lBirthday.TabIndex = 5;
            this.lBirthday.Text = "Birthday";
            // 
            // lNotes
            // 
            this.lNotes.AutoSize = true;
            this.lNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNotes.Location = new System.Drawing.Point(52, 283);
            this.lNotes.Name = "lNotes";
            this.lNotes.Size = new System.Drawing.Size(53, 20);
            this.lNotes.TabIndex = 6;
            this.lNotes.Text = "Notes";
            // 
            // tbFirst
            // 
            this.tbFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirst.Location = new System.Drawing.Point(54, 114);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(213, 26);
            this.tbFirst.TabIndex = 7;
            // 
            // tbNickname
            // 
            this.tbNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNickname.Location = new System.Drawing.Point(682, 114);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(145, 26);
            this.tbNickname.TabIndex = 8;
            // 
            // tbLast
            // 
            this.tbLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLast.Location = new System.Drawing.Point(446, 114);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(217, 26);
            this.tbLast.TabIndex = 9;
            // 
            // tbMiddle
            // 
            this.tbMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMiddle.Location = new System.Drawing.Point(288, 114);
            this.tbMiddle.Name = "tbMiddle";
            this.tbMiddle.Size = new System.Drawing.Size(137, 26);
            this.tbMiddle.TabIndex = 10;
            // 
            // dateTPBirthday
            // 
            this.dateTPBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTPBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPBirthday.Location = new System.Drawing.Point(56, 209);
            this.dateTPBirthday.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dateTPBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTPBirthday.Name = "dateTPBirthday";
            this.dateTPBirthday.Size = new System.Drawing.Size(275, 26);
            this.dateTPBirthday.TabIndex = 11;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.Location = new System.Drawing.Point(446, 172);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(381, 77);
            this.gbGender.TabIndex = 12;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender*";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Checked = true;
            this.rbFemale.Location = new System.Drawing.Point(18, 37);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(85, 24);
            this.rbFemale.TabIndex = 0;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(240, 38);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(66, 24);
            this.rbMale.TabIndex = 1;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // richTBNotes
            // 
            this.richTBNotes.Location = new System.Drawing.Point(56, 315);
            this.richTBNotes.Name = "richTBNotes";
            this.richTBNotes.Size = new System.Drawing.Size(771, 104);
            this.richTBNotes.TabIndex = 13;
            this.richTBNotes.Text = "";
            // 
            // clbTeams
            // 
            this.clbTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbTeams.FormattingEnabled = true;
            this.clbTeams.Location = new System.Drawing.Point(56, 475);
            this.clbTeams.Name = "clbTeams";
            this.clbTeams.Size = new System.Drawing.Size(478, 344);
            this.clbTeams.TabIndex = 14;
            // 
            // lAssign
            // 
            this.lAssign.AutoSize = true;
            this.lAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAssign.Location = new System.Drawing.Point(53, 444);
            this.lAssign.Name = "lAssign";
            this.lAssign.Size = new System.Drawing.Size(140, 20);
            this.lAssign.TabIndex = 15;
            this.lAssign.Text = "Assign To Teams";
            // 
            // AthleteManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1769, 859);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AthleteManager";
            this.Text = "ManageAthletes";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAthletes)).EndInit();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgAthletes;
        private System.Windows.Forms.Label lNotes;
        private System.Windows.Forms.Label lBirthday;
        private System.Windows.Forms.Label lNickname;
        private System.Windows.Forms.Label lLast;
        private System.Windows.Forms.Label lMiddle;
        private System.Windows.Forms.Label lFirst;
        private System.Windows.Forms.Label lHeader;
        private System.Windows.Forms.TextBox tbMiddle;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.DateTimePicker dateTPBirthday;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lAssign;
        private System.Windows.Forms.CheckedListBox clbTeams;
        private System.Windows.Forms.RichTextBox richTBNotes;
    }
}