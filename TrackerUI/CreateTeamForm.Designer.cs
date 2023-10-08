namespace TrackerUI
{
    partial class CreateTeamForm
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
            teamNameLabel = new Label();
            teamNameValue = new TextBox();
            selectTeamMemberLabel = new Label();
            selectTeamMemberDropDown = new ComboBox();
            addTeamMemberButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            addNewMemberGroupBox = new GroupBox();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            emailAddressValue = new TextBox();
            emailAddressLabel = new Label();
            phoneValue = new TextBox();
            label3 = new Label();
            createMemberButton = new Button();
            tournamentTeamMembersListBox = new ListBox();
            deleteSelectedTeamMemberButton = new Button();
            createTeamButton = new Button();
            createTeamLabel = new Label();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Location = new Point(34, 69);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(105, 25);
            teamNameLabel.TabIndex = 0;
            teamNameLabel.Text = "Team Name";
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(34, 97);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(290, 31);
            teamNameValue.TabIndex = 3;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Location = new Point(34, 141);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(176, 25);
            selectTeamMemberLabel.TabIndex = 4;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(28, 169);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(296, 33);
            selectTeamMemberDropDown.TabIndex = 7;
            // 
            // addTeamMemberButton
            // 
            addTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            addTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.White;
            addTeamMemberButton.FlatStyle = FlatStyle.Flat;
            addTeamMemberButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamMemberButton.Location = new Point(74, 208);
            addTeamMemberButton.Name = "addTeamMemberButton";
            addTeamMemberButton.Size = new Size(212, 40);
            addTeamMemberButton.TabIndex = 17;
            addTeamMemberButton.Text = "Add Member";
            addTeamMemberButton.UseVisualStyleBackColor = true;
            addTeamMemberButton.Click += addTeamButton_Click;
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.BackColor = Color.White;
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(phoneValue);
            addNewMemberGroupBox.Controls.Add(label3);
            addNewMemberGroupBox.Controls.Add(emailAddressValue);
            addNewMemberGroupBox.Controls.Add(emailAddressLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addNewMemberGroupBox.Location = new Point(34, 263);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(303, 259);
            addNewMemberGroupBox.TabIndex = 18;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(109, 39);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(181, 31);
            firstNameValue.TabIndex = 11;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(6, 39);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(102, 25);
            firstNameLabel.TabIndex = 10;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(109, 76);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(181, 31);
            lastNameValue.TabIndex = 13;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(6, 76);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(99, 25);
            lastNameLabel.TabIndex = 12;
            lastNameLabel.Text = "Last Name";
            // 
            // emailAddressValue
            // 
            emailAddressValue.Location = new Point(109, 113);
            emailAddressValue.Name = "emailAddressValue";
            emailAddressValue.Size = new Size(181, 31);
            emailAddressValue.TabIndex = 15;
            // 
            // emailAddressLabel
            // 
            emailAddressLabel.AutoSize = true;
            emailAddressLabel.Location = new Point(6, 113);
            emailAddressLabel.Name = "emailAddressLabel";
            emailAddressLabel.Size = new Size(56, 25);
            emailAddressLabel.TabIndex = 14;
            emailAddressLabel.Text = "Email";
            // 
            // phoneValue
            // 
            phoneValue.Location = new Point(109, 150);
            phoneValue.Name = "phoneValue";
            phoneValue.Size = new Size(181, 31);
            phoneValue.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 150);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 16;
            label3.Text = "Phone";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.White;
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberButton.Location = new Point(40, 201);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(212, 40);
            createMemberButton.TabIndex = 18;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // tournamentTeamMembersListBox
            // 
            tournamentTeamMembersListBox.FormattingEnabled = true;
            tournamentTeamMembersListBox.ItemHeight = 25;
            tournamentTeamMembersListBox.Location = new Point(388, 93);
            tournamentTeamMembersListBox.Name = "tournamentTeamMembersListBox";
            tournamentTeamMembersListBox.Size = new Size(273, 429);
            tournamentTeamMembersListBox.TabIndex = 20;
            // 
            // deleteSelectedTeamMemberButton
            // 
            deleteSelectedTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            deleteSelectedTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.White;
            deleteSelectedTeamMemberButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedTeamMemberButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedTeamMemberButton.Location = new Point(667, 275);
            deleteSelectedTeamMemberButton.Name = "deleteSelectedTeamMemberButton";
            deleteSelectedTeamMemberButton.Size = new Size(124, 74);
            deleteSelectedTeamMemberButton.TabIndex = 21;
            deleteSelectedTeamMemberButton.Text = "Delete Selected";
            deleteSelectedTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.White;
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.Location = new Point(207, 547);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(383, 45);
            createTeamButton.TabIndex = 24;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamLabel.ForeColor = Color.RoyalBlue;
            createTeamLabel.Location = new Point(28, 18);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(154, 32);
            createTeamLabel.TabIndex = 25;
            createTeamLabel.Text = "Create Team";
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 605);
            Controls.Add(createTeamLabel);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedTeamMemberButton);
            Controls.Add(tournamentTeamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addTeamMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label teamNameLabel;
        private TextBox teamNameValue;
        private Label selectTeamMemberLabel;
        private ComboBox selectTeamMemberDropDown;
        private Button addTeamMemberButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox addNewMemberGroupBox;
        private TextBox phoneValue;
        private Label label3;
        private TextBox emailAddressValue;
        private Label emailAddressLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private Button createMemberButton;
        private ListBox tournamentTeamMembersListBox;
        private Button deleteSelectedTeamMemberButton;
        private Button createTeamButton;
        private Label createTeamLabel;
    }
}