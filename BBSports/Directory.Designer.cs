namespace BBSports
{
    partial class Directory
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
            this.bPerformances = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.lAthleteId = new System.Windows.Forms.Label();
            this.lFirst = new System.Windows.Forms.Label();
            this.lLast = new System.Windows.Forms.Label();
            this.lSport = new System.Windows.Forms.Label();
            this.mtbAthleteId = new System.Windows.Forms.MaskedTextBox();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.lOrg = new System.Windows.Forms.Label();
            this.cbOrganization = new System.Windows.Forms.ComboBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bPerformances
            // 
            this.bPerformances.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPerformances.Location = new System.Drawing.Point(199, 588);
            this.bPerformances.Name = "bPerformances";
            this.bPerformances.Size = new System.Drawing.Size(205, 42);
            this.bPerformances.TabIndex = 0;
            this.bPerformances.Text = "See Performances";
            this.bPerformances.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(570, 588);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(155, 42);
            this.bAdd.TabIndex = 1;
            this.bAdd.Text = "Add to Team";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(958, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // tbFirst
            // 
            this.tbFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirst.Location = new System.Drawing.Point(178, 57);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(201, 26);
            this.tbFirst.TabIndex = 3;
            // 
            // lAthleteId
            // 
            this.lAthleteId.AutoSize = true;
            this.lAthleteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAthleteId.Location = new System.Drawing.Point(24, 19);
            this.lAthleteId.Name = "lAthleteId";
            this.lAthleteId.Size = new System.Drawing.Size(84, 20);
            this.lAthleteId.TabIndex = 4;
            this.lAthleteId.Text = "Athlete Id:";
            // 
            // lFirst
            // 
            this.lFirst.AutoSize = true;
            this.lFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFirst.Location = new System.Drawing.Point(174, 19);
            this.lFirst.Name = "lFirst";
            this.lFirst.Size = new System.Drawing.Size(97, 20);
            this.lFirst.TabIndex = 5;
            this.lFirst.Text = "First Name:";
            // 
            // lLast
            // 
            this.lLast.AutoSize = true;
            this.lLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLast.Location = new System.Drawing.Point(402, 19);
            this.lLast.Name = "lLast";
            this.lLast.Size = new System.Drawing.Size(96, 20);
            this.lLast.TabIndex = 6;
            this.lLast.Text = "Last Name:";
            // 
            // lSport
            // 
            this.lSport.AutoSize = true;
            this.lSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSport.Location = new System.Drawing.Point(954, 19);
            this.lSport.Name = "lSport";
            this.lSport.Size = new System.Drawing.Size(54, 20);
            this.lSport.TabIndex = 7;
            this.lSport.Text = "Sport:";
            // 
            // mtbAthleteId
            // 
            this.mtbAthleteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbAthleteId.Location = new System.Drawing.Point(28, 57);
            this.mtbAthleteId.Mask = "############";
            this.mtbAthleteId.Name = "mtbAthleteId";
            this.mtbAthleteId.PromptChar = ' ';
            this.mtbAthleteId.Size = new System.Drawing.Size(126, 26);
            this.mtbAthleteId.TabIndex = 8;
            this.mtbAthleteId.Text = "0";
            this.mtbAthleteId.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbLast
            // 
            this.tbLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLast.Location = new System.Drawing.Point(406, 57);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(219, 26);
            this.tbLast.TabIndex = 9;
            // 
            // lOrg
            // 
            this.lOrg.AutoSize = true;
            this.lOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrg.Location = new System.Drawing.Point(641, 19);
            this.lOrg.Name = "lOrg";
            this.lOrg.Size = new System.Drawing.Size(109, 20);
            this.lOrg.TabIndex = 10;
            this.lOrg.Text = "Organization:";
            // 
            // cbOrganization
            // 
            this.cbOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrganization.FormattingEnabled = true;
            this.cbOrganization.Location = new System.Drawing.Point(645, 57);
            this.cbOrganization.Name = "cbOrganization";
            this.cbOrganization.Size = new System.Drawing.Size(291, 28);
            this.cbOrganization.TabIndex = 11;
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(936, 588);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(133, 42);
            this.bSearch.TabIndex = 12;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            // 
            // Directory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 642);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.cbOrganization);
            this.Controls.Add(this.lOrg);
            this.Controls.Add(this.tbLast);
            this.Controls.Add(this.mtbAthleteId);
            this.Controls.Add(this.lSport);
            this.Controls.Add(this.lLast);
            this.Controls.Add(this.lFirst);
            this.Controls.Add(this.lAthleteId);
            this.Controls.Add(this.tbFirst);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bPerformances);
            this.Name = "Directory";
            this.Text = "Directory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPerformances;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.Label lAthleteId;
        private System.Windows.Forms.Label lFirst;
        private System.Windows.Forms.Label lLast;
        private System.Windows.Forms.Label lSport;
        private System.Windows.Forms.MaskedTextBox mtbAthleteId;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.Label lOrg;
        private System.Windows.Forms.ComboBox cbOrganization;
        private System.Windows.Forms.Button bSearch;
    }
}