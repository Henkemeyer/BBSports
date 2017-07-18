namespace BBSports
{
    partial class NewUser
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
            this.cxbNewOrg = new System.Windows.Forms.CheckBox();
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.tbMiddle = new System.Windows.Forms.TextBox();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPWCheck = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.lIntro = new System.Windows.Forms.Label();
            this.lFirst = new System.Windows.Forms.Label();
            this.lMiddle = new System.Windows.Forms.Label();
            this.lLast = new System.Windows.Forms.Label();
            this.lBirthday = new System.Windows.Forms.Label();
            this.lCity = new System.Windows.Forms.Label();
            this.lState = new System.Windows.Forms.Label();
            this.lIdCheck = new System.Windows.Forms.Label();
            this.mtbBirthday = new System.Windows.Forms.MaskedTextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.lDouble = new System.Windows.Forms.Label();
            this.pNewOrg = new System.Windows.Forms.Panel();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lClass = new System.Windows.Forms.Label();
            this.lOrgState = new System.Windows.Forms.Label();
            this.lOrgCity = new System.Windows.Forms.Label();
            this.tbOrgState = new System.Windows.Forms.TextBox();
            this.tbOrgCity = new System.Windows.Forms.TextBox();
            this.lNumTeams = new System.Windows.Forms.Label();
            this.numericTeams = new System.Windows.Forms.NumericUpDown();
            this.tbOrgName = new System.Windows.Forms.TextBox();
            this.lOrgName = new System.Windows.Forms.Label();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.lGrade = new System.Windows.Forms.Label();
            this.bSubmit = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lTempPW = new System.Windows.Forms.Label();
            this.tbTempPW = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTMI = new System.Windows.Forms.ToolStripMenuItem();
            this.pLeft = new System.Windows.Forms.Panel();
            this.pRight = new System.Windows.Forms.Panel();
            this.numericAthleteId = new System.Windows.Forms.NumericUpDown();
            this.pNewOrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTeams)).BeginInit();
            this.gbGender.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAthleteId)).BeginInit();
            this.SuspendLayout();
            // 
            // cxbNewOrg
            // 
            this.cxbNewOrg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cxbNewOrg.AutoSize = true;
            this.cxbNewOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxbNewOrg.Location = new System.Drawing.Point(356, 524);
            this.cxbNewOrg.Name = "cxbNewOrg";
            this.cxbNewOrg.Size = new System.Drawing.Size(173, 24);
            this.cxbNewOrg.TabIndex = 0;
            this.cxbNewOrg.Text = "New Organization?";
            this.cxbNewOrg.UseVisualStyleBackColor = true;
            this.cxbNewOrg.CheckedChanged += new System.EventHandler(this.NewOrg_CheckedChanged);
            // 
            // tbFirst
            // 
            this.tbFirst.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirst.Location = new System.Drawing.Point(354, 200);
            this.tbFirst.MaxLength = 25;
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(190, 26);
            this.tbFirst.TabIndex = 1;
            // 
            // tbMiddle
            // 
            this.tbMiddle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMiddle.Location = new System.Drawing.Point(578, 200);
            this.tbMiddle.Name = "tbMiddle";
            this.tbMiddle.Size = new System.Drawing.Size(100, 26);
            this.tbMiddle.TabIndex = 2;
            // 
            // tbLast
            // 
            this.tbLast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLast.Location = new System.Drawing.Point(716, 200);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(284, 26);
            this.tbLast.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(354, 401);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(425, 26);
            this.tbEmail.TabIndex = 4;
            // 
            // tbPWCheck
            // 
            this.tbPWCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPWCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPWCheck.Location = new System.Drawing.Point(893, 479);
            this.tbPWCheck.Name = "tbPWCheck";
            this.tbPWCheck.Size = new System.Drawing.Size(273, 26);
            this.tbPWCheck.TabIndex = 5;
            this.tbPWCheck.UseSystemPasswordChar = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(354, 479);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(296, 26);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbCity
            // 
            this.tbCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(516, 281);
            this.tbCity.MaxLength = 50;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(263, 26);
            this.tbCity.TabIndex = 8;
            // 
            // tbState
            // 
            this.tbState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbState.Location = new System.Drawing.Point(818, 281);
            this.tbState.MaxLength = 2;
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(80, 26);
            this.tbState.TabIndex = 9;
            // 
            // lIntro
            // 
            this.lIntro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lIntro.AutoSize = true;
            this.lIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIntro.Location = new System.Drawing.Point(328, 111);
            this.lIntro.Name = "lIntro";
            this.lIntro.Size = new System.Drawing.Size(501, 24);
            this.lIntro.TabIndex = 10;
            this.lIntro.Text = "Please fill in the following information for your new account:";
            // 
            // lFirst
            // 
            this.lFirst.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lFirst.AutoSize = true;
            this.lFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFirst.Location = new System.Drawing.Point(352, 166);
            this.lFirst.Name = "lFirst";
            this.lFirst.Size = new System.Drawing.Size(92, 20);
            this.lFirst.TabIndex = 11;
            this.lFirst.Text = "First Name";
            // 
            // lMiddle
            // 
            this.lMiddle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lMiddle.AutoSize = true;
            this.lMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMiddle.Location = new System.Drawing.Point(574, 166);
            this.lMiddle.Name = "lMiddle";
            this.lMiddle.Size = new System.Drawing.Size(58, 20);
            this.lMiddle.TabIndex = 12;
            this.lMiddle.Text = "Middle";
            // 
            // lLast
            // 
            this.lLast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lLast.AutoSize = true;
            this.lLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLast.Location = new System.Drawing.Point(712, 166);
            this.lLast.Name = "lLast";
            this.lLast.Size = new System.Drawing.Size(91, 20);
            this.lLast.TabIndex = 13;
            this.lLast.Text = "Last Name";
            // 
            // lBirthday
            // 
            this.lBirthday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lBirthday.AutoSize = true;
            this.lBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBirthday.Location = new System.Drawing.Point(352, 252);
            this.lBirthday.Name = "lBirthday";
            this.lBirthday.Size = new System.Drawing.Size(71, 20);
            this.lBirthday.TabIndex = 14;
            this.lBirthday.Text = "Birthday";
            // 
            // lCity
            // 
            this.lCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lCity.AutoSize = true;
            this.lCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCity.Location = new System.Drawing.Point(513, 252);
            this.lCity.Name = "lCity";
            this.lCity.Size = new System.Drawing.Size(38, 20);
            this.lCity.TabIndex = 15;
            this.lCity.Text = "City";
            // 
            // lState
            // 
            this.lState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lState.AutoSize = true;
            this.lState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lState.Location = new System.Drawing.Point(814, 252);
            this.lState.Name = "lState";
            this.lState.Size = new System.Drawing.Size(48, 20);
            this.lState.TabIndex = 16;
            this.lState.Text = "State";
            // 
            // lIdCheck
            // 
            this.lIdCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lIdCheck.AutoSize = true;
            this.lIdCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIdCheck.Location = new System.Drawing.Point(328, 50);
            this.lIdCheck.Name = "lIdCheck";
            this.lIdCheck.Size = new System.Drawing.Size(543, 26);
            this.lIdCheck.TabIndex = 17;
            this.lIdCheck.Text = "If you have an athlete ID already please enter that now.";
            // 
            // mtbBirthday
            // 
            this.mtbBirthday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtbBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbBirthday.Location = new System.Drawing.Point(354, 281);
            this.mtbBirthday.Mask = "00/00/0000";
            this.mtbBirthday.Name = "mtbBirthday";
            this.mtbBirthday.Size = new System.Drawing.Size(100, 26);
            this.mtbBirthday.TabIndex = 19;
            this.mtbBirthday.ValidatingType = typeof(System.DateTime);
            // 
            // lEmail
            // 
            this.lEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(351, 363);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(299, 20);
            this.lEmail.TabIndex = 20;
            this.lEmail.Text = "E-Mail (This will be used as your login)";
            // 
            // lPassword
            // 
            this.lPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lPassword.AutoSize = true;
            this.lPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassword.Location = new System.Drawing.Point(352, 449);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(83, 20);
            this.lPassword.TabIndex = 21;
            this.lPassword.Text = "Password";
            // 
            // lDouble
            // 
            this.lDouble.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lDouble.AutoSize = true;
            this.lDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDouble.Location = new System.Drawing.Point(889, 449);
            this.lDouble.Name = "lDouble";
            this.lDouble.Size = new System.Drawing.Size(201, 20);
            this.lDouble.TabIndex = 22;
            this.lDouble.Text = "Please re-enter password";
            // 
            // pNewOrg
            // 
            this.pNewOrg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pNewOrg.Controls.Add(this.cbClass);
            this.pNewOrg.Controls.Add(this.lClass);
            this.pNewOrg.Controls.Add(this.lOrgState);
            this.pNewOrg.Controls.Add(this.lOrgCity);
            this.pNewOrg.Controls.Add(this.tbOrgState);
            this.pNewOrg.Controls.Add(this.tbOrgCity);
            this.pNewOrg.Controls.Add(this.lNumTeams);
            this.pNewOrg.Controls.Add(this.numericTeams);
            this.pNewOrg.Controls.Add(this.tbOrgName);
            this.pNewOrg.Controls.Add(this.lOrgName);
            this.pNewOrg.Enabled = false;
            this.pNewOrg.Location = new System.Drawing.Point(332, 573);
            this.pNewOrg.Name = "pNewOrg";
            this.pNewOrg.Size = new System.Drawing.Size(961, 222);
            this.pNewOrg.TabIndex = 23;
            // 
            // cbClass
            // 
            this.cbClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(492, 160);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(274, 28);
            this.cbClass.TabIndex = 22;
            // 
            // lClass
            // 
            this.lClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lClass.AutoSize = true;
            this.lClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClass.Location = new System.Drawing.Point(352, 164);
            this.lClass.Name = "lClass";
            this.lClass.Size = new System.Drawing.Size(110, 20);
            this.lClass.TabIndex = 21;
            this.lClass.Text = "Classification";
            // 
            // lOrgState
            // 
            this.lOrgState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lOrgState.AutoSize = true;
            this.lOrgState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrgState.Location = new System.Drawing.Point(483, 98);
            this.lOrgState.Name = "lOrgState";
            this.lOrgState.Size = new System.Drawing.Size(48, 20);
            this.lOrgState.TabIndex = 20;
            this.lOrgState.Text = "State";
            // 
            // lOrgCity
            // 
            this.lOrgCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lOrgCity.AutoSize = true;
            this.lOrgCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrgCity.Location = new System.Drawing.Point(49, 98);
            this.lOrgCity.Name = "lOrgCity";
            this.lOrgCity.Size = new System.Drawing.Size(38, 20);
            this.lOrgCity.TabIndex = 19;
            this.lOrgCity.Text = "City";
            // 
            // tbOrgState
            // 
            this.tbOrgState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbOrgState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrgState.Location = new System.Drawing.Point(561, 98);
            this.tbOrgState.MaxLength = 2;
            this.tbOrgState.Name = "tbOrgState";
            this.tbOrgState.Size = new System.Drawing.Size(80, 26);
            this.tbOrgState.TabIndex = 18;
            // 
            // tbOrgCity
            // 
            this.tbOrgCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbOrgCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrgCity.Location = new System.Drawing.Point(97, 98);
            this.tbOrgCity.MaxLength = 50;
            this.tbOrgCity.Name = "tbOrgCity";
            this.tbOrgCity.Size = new System.Drawing.Size(352, 26);
            this.tbOrgCity.TabIndex = 17;
            // 
            // lNumTeams
            // 
            this.lNumTeams.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lNumTeams.AutoSize = true;
            this.lNumTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNumTeams.Location = new System.Drawing.Point(49, 164);
            this.lNumTeams.Name = "lNumTeams";
            this.lNumTeams.Size = new System.Drawing.Size(143, 20);
            this.lNumTeams.TabIndex = 3;
            this.lNumTeams.Text = "Number of Teams";
            // 
            // numericTeams
            // 
            this.numericTeams.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTeams.Location = new System.Drawing.Point(227, 164);
            this.numericTeams.Name = "numericTeams";
            this.numericTeams.Size = new System.Drawing.Size(74, 26);
            this.numericTeams.TabIndex = 2;
            // 
            // tbOrgName
            // 
            this.tbOrgName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbOrgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrgName.Location = new System.Drawing.Point(314, 42);
            this.tbOrgName.MaxLength = 50;
            this.tbOrgName.Name = "tbOrgName";
            this.tbOrgName.Size = new System.Drawing.Size(528, 26);
            this.tbOrgName.TabIndex = 1;
            // 
            // lOrgName
            // 
            this.lOrgName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lOrgName.AutoSize = true;
            this.lOrgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrgName.Location = new System.Drawing.Point(48, 42);
            this.lOrgName.Name = "lOrgName";
            this.lOrgName.Size = new System.Drawing.Size(194, 20);
            this.lOrgName.TabIndex = 0;
            this.lOrgName.Text = "Organizations Full Name";
            // 
            // gbGender
            // 
            this.gbGender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.Location = new System.Drawing.Point(959, 252);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(311, 93);
            this.gbGender.TabIndex = 24;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbFemale.AutoSize = true;
            this.rbFemale.Checked = true;
            this.rbFemale.Location = new System.Drawing.Point(38, 42);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(85, 24);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(191, 42);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(66, 24);
            this.rbMale.TabIndex = 0;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // cbGrade
            // 
            this.cbGrade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Location = new System.Drawing.Point(1046, 200);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(224, 28);
            this.cbGrade.TabIndex = 25;
            // 
            // lGrade
            // 
            this.lGrade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lGrade.AutoSize = true;
            this.lGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGrade.Location = new System.Drawing.Point(1042, 166);
            this.lGrade.Name = "lGrade";
            this.lGrade.Size = new System.Drawing.Size(55, 20);
            this.lGrade.TabIndex = 26;
            this.lGrade.Text = "Grade";
            // 
            // bSubmit
            // 
            this.bSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubmit.Location = new System.Drawing.Point(558, 811);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(92, 46);
            this.bSubmit.TabIndex = 27;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(880, 811);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(92, 46);
            this.bCancel.TabIndex = 28;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // lTempPW
            // 
            this.lTempPW.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lTempPW.AutoSize = true;
            this.lTempPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTempPW.Location = new System.Drawing.Point(889, 363);
            this.lTempPW.Name = "lTempPW";
            this.lTempPW.Size = new System.Drawing.Size(168, 20);
            this.lTempPW.TabIndex = 29;
            this.lTempPW.Text = "Temperary Password";
            this.lTempPW.Visible = false;
            // 
            // tbTempPW
            // 
            this.tbTempPW.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTempPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTempPW.Location = new System.Drawing.Point(893, 401);
            this.tbTempPW.Name = "tbTempPW";
            this.tbTempPW.Size = new System.Drawing.Size(273, 26);
            this.tbTempPW.TabIndex = 30;
            this.tbTempPW.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewUser});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1770, 28);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuNewUser
            // 
            this.menuNewUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearTMI,
            this.cancelTMI,
            this.exitTMI});
            this.menuNewUser.Name = "menuNewUser";
            this.menuNewUser.Size = new System.Drawing.Size(44, 24);
            this.menuNewUser.Text = "File";
            // 
            // clearTMI
            // 
            this.clearTMI.Name = "clearTMI";
            this.clearTMI.Size = new System.Drawing.Size(128, 26);
            this.clearTMI.Text = "Clear";
            // 
            // cancelTMI
            // 
            this.cancelTMI.Name = "cancelTMI";
            this.cancelTMI.Size = new System.Drawing.Size(128, 26);
            this.cancelTMI.Text = "Cancel";
            this.cancelTMI.Click += new System.EventHandler(this.CancelTMI_Click);
            // 
            // exitTMI
            // 
            this.exitTMI.Name = "exitTMI";
            this.exitTMI.Size = new System.Drawing.Size(128, 26);
            this.exitTMI.Text = "Exit";
            this.exitTMI.Click += new System.EventHandler(this.ExitTMI_Click);
            // 
            // pLeft
            // 
            this.pLeft.BackColor = System.Drawing.SystemColors.Window;
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 28);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(274, 851);
            this.pLeft.TabIndex = 32;
            // 
            // pRight
            // 
            this.pRight.BackColor = System.Drawing.SystemColors.Window;
            this.pRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRight.Location = new System.Drawing.Point(1456, 28);
            this.pRight.Name = "pRight";
            this.pRight.Size = new System.Drawing.Size(314, 851);
            this.pRight.TabIndex = 33;
            // 
            // numericAthleteId
            // 
            this.numericAthleteId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericAthleteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericAthleteId.Location = new System.Drawing.Point(1015, 61);
            this.numericAthleteId.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numericAthleteId.Name = "numericAthleteId";
            this.numericAthleteId.Size = new System.Drawing.Size(159, 26);
            this.numericAthleteId.TabIndex = 34;
            this.numericAthleteId.Leave += new System.EventHandler(this.NumericAthleteId_Leave);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(1770, 879);
            this.ControlBox = false;
            this.Controls.Add(this.numericAthleteId);
            this.Controls.Add(this.pRight);
            this.Controls.Add(this.pLeft);
            this.Controls.Add(this.tbTempPW);
            this.Controls.Add(this.lTempPW);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.lGrade);
            this.Controls.Add(this.cbGrade);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.pNewOrg);
            this.Controls.Add(this.lDouble);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.mtbBirthday);
            this.Controls.Add(this.lIdCheck);
            this.Controls.Add(this.lState);
            this.Controls.Add(this.lCity);
            this.Controls.Add(this.lBirthday);
            this.Controls.Add(this.lLast);
            this.Controls.Add(this.lMiddle);
            this.Controls.Add(this.lFirst);
            this.Controls.Add(this.lIntro);
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbPWCheck);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbLast);
            this.Controls.Add(this.tbMiddle);
            this.Controls.Add(this.tbFirst);
            this.Controls.Add(this.cxbNewOrg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NewUser";
            this.Text = "New User";
            this.pNewOrg.ResumeLayout(false);
            this.pNewOrg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTeams)).EndInit();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAthleteId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cxbNewOrg;
        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.TextBox tbMiddle;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPWCheck;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.Label lIntro;
        private System.Windows.Forms.Label lFirst;
        private System.Windows.Forms.Label lMiddle;
        private System.Windows.Forms.Label lLast;
        private System.Windows.Forms.Label lBirthday;
        private System.Windows.Forms.Label lCity;
        private System.Windows.Forms.Label lState;
        private System.Windows.Forms.Label lIdCheck;
        private System.Windows.Forms.MaskedTextBox mtbBirthday;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lDouble;
        private System.Windows.Forms.Panel pNewOrg;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.Label lGrade;
        private System.Windows.Forms.Label lNumTeams;
        private System.Windows.Forms.NumericUpDown numericTeams;
        private System.Windows.Forms.TextBox tbOrgName;
        private System.Windows.Forms.Label lOrgName;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lClass;
        private System.Windows.Forms.Label lOrgState;
        private System.Windows.Forms.Label lOrgCity;
        private System.Windows.Forms.TextBox tbOrgState;
        private System.Windows.Forms.TextBox tbOrgCity;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lTempPW;
        private System.Windows.Forms.TextBox tbTempPW;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuNewUser;
        private System.Windows.Forms.ToolStripMenuItem clearTMI;
        private System.Windows.Forms.ToolStripMenuItem cancelTMI;
        private System.Windows.Forms.ToolStripMenuItem exitTMI;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Panel pRight;
        private System.Windows.Forms.NumericUpDown numericAthleteId;
    }
}