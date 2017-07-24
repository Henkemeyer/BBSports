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
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lState = new System.Windows.Forms.Label();
            this.lCity = new System.Windows.Forms.Label();
            this.dgvDirectory = new System.Windows.Forms.DataGridView();
            this.bSearch = new System.Windows.Forms.Button();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.mtbAthleteId = new System.Windows.Forms.MaskedTextBox();
            this.lSport = new System.Windows.Forms.Label();
            this.lLast = new System.Windows.Forms.Label();
            this.lFirst = new System.Windows.Forms.Label();
            this.lAthleteId = new System.Windows.Forms.Label();
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectory)).BeginInit();
            this.SuspendLayout();
            // 
            // tbState
            // 
            this.tbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbState.Location = new System.Drawing.Point(1093, 62);
            this.tbState.MaxLength = 2;
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(100, 26);
            this.tbState.TabIndex = 47;
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(831, 62);
            this.tbCity.MaxLength = 50;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(235, 26);
            this.tbCity.TabIndex = 46;
            // 
            // lState
            // 
            this.lState.AutoSize = true;
            this.lState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lState.Location = new System.Drawing.Point(1089, 23);
            this.lState.Name = "lState";
            this.lState.Size = new System.Drawing.Size(48, 20);
            this.lState.TabIndex = 45;
            this.lState.Text = "State";
            // 
            // lCity
            // 
            this.lCity.AutoSize = true;
            this.lCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCity.Location = new System.Drawing.Point(827, 23);
            this.lCity.Name = "lCity";
            this.lCity.Size = new System.Drawing.Size(38, 20);
            this.lCity.TabIndex = 44;
            this.lCity.Text = "City";
            // 
            // dgvDirectory
            // 
            this.dgvDirectory.AllowUserToAddRows = false;
            this.dgvDirectory.AllowUserToDeleteRows = false;
            this.dgvDirectory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDirectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectory.Location = new System.Drawing.Point(19, 105);
            this.dgvDirectory.MultiSelect = false;
            this.dgvDirectory.Name = "dgvDirectory";
            this.dgvDirectory.RowTemplate.Height = 24;
            this.dgvDirectory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDirectory.Size = new System.Drawing.Size(1178, 455);
            this.dgvDirectory.TabIndex = 43;
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(314, 592);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(133, 42);
            this.bSearch.TabIndex = 42;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // tbLast
            // 
            this.tbLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLast.Location = new System.Drawing.Point(344, 61);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(219, 26);
            this.tbLast.TabIndex = 41;
            // 
            // mtbAthleteId
            // 
            this.mtbAthleteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbAthleteId.Location = new System.Drawing.Point(19, 61);
            this.mtbAthleteId.Mask = "############";
            this.mtbAthleteId.Name = "mtbAthleteId";
            this.mtbAthleteId.PromptChar = ' ';
            this.mtbAthleteId.Size = new System.Drawing.Size(112, 26);
            this.mtbAthleteId.TabIndex = 40;
            this.mtbAthleteId.Text = "0";
            this.mtbAthleteId.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lSport
            // 
            this.lSport.AutoSize = true;
            this.lSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSport.Location = new System.Drawing.Point(589, 23);
            this.lSport.Name = "lSport";
            this.lSport.Size = new System.Drawing.Size(54, 20);
            this.lSport.TabIndex = 39;
            this.lSport.Text = "Sport:";
            // 
            // lLast
            // 
            this.lLast.AutoSize = true;
            this.lLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLast.Location = new System.Drawing.Point(340, 23);
            this.lLast.Name = "lLast";
            this.lLast.Size = new System.Drawing.Size(96, 20);
            this.lLast.TabIndex = 38;
            this.lLast.Text = "Last Name:";
            // 
            // lFirst
            // 
            this.lFirst.AutoSize = true;
            this.lFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFirst.Location = new System.Drawing.Point(148, 23);
            this.lFirst.Name = "lFirst";
            this.lFirst.Size = new System.Drawing.Size(97, 20);
            this.lFirst.TabIndex = 37;
            this.lFirst.Text = "First Name:";
            // 
            // lAthleteId
            // 
            this.lAthleteId.AutoSize = true;
            this.lAthleteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAthleteId.Location = new System.Drawing.Point(15, 23);
            this.lAthleteId.Name = "lAthleteId";
            this.lAthleteId.Size = new System.Drawing.Size(84, 20);
            this.lAthleteId.TabIndex = 36;
            this.lAthleteId.Text = "Athlete Id:";
            // 
            // tbFirst
            // 
            this.tbFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirst.Location = new System.Drawing.Point(152, 61);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(165, 26);
            this.tbFirst.TabIndex = 35;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(593, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 28);
            this.comboBox1.TabIndex = 34;
            // 
            // bSelect
            // 
            this.bSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSelect.Location = new System.Drawing.Point(683, 592);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(155, 42);
            this.bSelect.TabIndex = 33;
            this.bSelect.Text = "Select";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.Select_Click);
            // 
            // Directory
            // 
            this.AcceptButton = this.bSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 657);
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.lState);
            this.Controls.Add(this.lCity);
            this.Controls.Add(this.dgvDirectory);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.tbLast);
            this.Controls.Add(this.mtbAthleteId);
            this.Controls.Add(this.lSport);
            this.Controls.Add(this.lLast);
            this.Controls.Add(this.lFirst);
            this.Controls.Add(this.lAthleteId);
            this.Controls.Add(this.tbFirst);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bSelect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Directory";
            this.Text = "Directory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lState;
        private System.Windows.Forms.Label lCity;
        private System.Windows.Forms.DataGridView dgvDirectory;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.MaskedTextBox mtbAthleteId;
        private System.Windows.Forms.Label lSport;
        private System.Windows.Forms.Label lLast;
        private System.Windows.Forms.Label lFirst;
        private System.Windows.Forms.Label lAthleteId;
        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bSelect;
    }
}