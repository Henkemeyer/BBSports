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

        #region Component Designer generated code

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
            this.tbState.Location = new System.Drawing.Point(1122, 87);
            this.tbState.MaxLength = 2;
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(100, 26);
            this.tbState.TabIndex = 32;
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(860, 87);
            this.tbCity.MaxLength = 50;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(235, 26);
            this.tbCity.TabIndex = 31;
            // 
            // lState
            // 
            this.lState.AutoSize = true;
            this.lState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lState.Location = new System.Drawing.Point(1118, 48);
            this.lState.Name = "lState";
            this.lState.Size = new System.Drawing.Size(48, 20);
            this.lState.TabIndex = 30;
            this.lState.Text = "State";
            // 
            // lCity
            // 
            this.lCity.AutoSize = true;
            this.lCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCity.Location = new System.Drawing.Point(856, 48);
            this.lCity.Name = "lCity";
            this.lCity.Size = new System.Drawing.Size(38, 20);
            this.lCity.TabIndex = 29;
            this.lCity.Text = "City";
            // 
            // dgvDirectory
            // 
            this.dgvDirectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectory.Location = new System.Drawing.Point(48, 130);
            this.dgvDirectory.Name = "dgvDirectory";
            this.dgvDirectory.RowTemplate.Height = 24;
            this.dgvDirectory.Size = new System.Drawing.Size(1178, 455);
            this.dgvDirectory.TabIndex = 28;
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(343, 617);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(133, 42);
            this.bSearch.TabIndex = 27;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            // 
            // tbLast
            // 
            this.tbLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLast.Location = new System.Drawing.Point(373, 86);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(219, 26);
            this.tbLast.TabIndex = 26;
            // 
            // mtbAthleteId
            // 
            this.mtbAthleteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbAthleteId.Location = new System.Drawing.Point(48, 86);
            this.mtbAthleteId.Mask = "############";
            this.mtbAthleteId.Name = "mtbAthleteId";
            this.mtbAthleteId.PromptChar = ' ';
            this.mtbAthleteId.Size = new System.Drawing.Size(112, 26);
            this.mtbAthleteId.TabIndex = 25;
            this.mtbAthleteId.Text = "0";
            this.mtbAthleteId.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lSport
            // 
            this.lSport.AutoSize = true;
            this.lSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSport.Location = new System.Drawing.Point(618, 48);
            this.lSport.Name = "lSport";
            this.lSport.Size = new System.Drawing.Size(54, 20);
            this.lSport.TabIndex = 24;
            this.lSport.Text = "Sport:";
            // 
            // lLast
            // 
            this.lLast.AutoSize = true;
            this.lLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLast.Location = new System.Drawing.Point(369, 48);
            this.lLast.Name = "lLast";
            this.lLast.Size = new System.Drawing.Size(96, 20);
            this.lLast.TabIndex = 23;
            this.lLast.Text = "Last Name:";
            // 
            // lFirst
            // 
            this.lFirst.AutoSize = true;
            this.lFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFirst.Location = new System.Drawing.Point(177, 48);
            this.lFirst.Name = "lFirst";
            this.lFirst.Size = new System.Drawing.Size(97, 20);
            this.lFirst.TabIndex = 22;
            this.lFirst.Text = "First Name:";
            // 
            // lAthleteId
            // 
            this.lAthleteId.AutoSize = true;
            this.lAthleteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAthleteId.Location = new System.Drawing.Point(44, 48);
            this.lAthleteId.Name = "lAthleteId";
            this.lAthleteId.Size = new System.Drawing.Size(84, 20);
            this.lAthleteId.TabIndex = 21;
            this.lAthleteId.Text = "Athlete Id:";
            // 
            // tbFirst
            // 
            this.tbFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirst.Location = new System.Drawing.Point(181, 86);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(165, 26);
            this.tbFirst.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(622, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 28);
            this.comboBox1.TabIndex = 19;
            // 
            // bSelect
            // 
            this.bSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSelect.Location = new System.Drawing.Point(712, 617);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(155, 42);
            this.bSelect.TabIndex = 18;
            this.bSelect.Text = "Select";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.Select_Click);
            // 
            // Directory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "Directory";
            this.Size = new System.Drawing.Size(1276, 680);
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
