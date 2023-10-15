namespace TrackerUI
{
    partial class CreateTournamentForm
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
            tournamentNameLabel = new Label();
            tournamentNameValue = new TextBox();
            entryFeeLabel = new Label();
            entryFeeValue = new TextBox();
            selectTeamLabel = new Label();
            selectTeamDropDown = new ComboBox();
            createNewTeamLink = new LinkLabel();
            createPrizeButton = new Button();
            addTeamButton = new Button();
            teamPalyersLabel = new Label();
            tournamentTeamListBox = new ListBox();
            RemoveSelectedPlayersTeamButton = new Button();
            removeSelectedPrizeButton = new Button();
            prizesListBox = new ListBox();
            PrizesLabel = new Label();
            createTournamentButton = new Button();
            createTournamentLabel = new Label();
            SuspendLayout();
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Location = new Point(36, 90);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(158, 25);
            tournamentNameLabel.TabIndex = 1;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(39, 126);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(292, 31);
            tournamentNameValue.TabIndex = 2;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Location = new Point(39, 182);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(84, 25);
            entryFeeLabel.TabIndex = 3;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(149, 176);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(180, 31);
            entryFeeValue.TabIndex = 4;
            entryFeeValue.Text = "0";
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Location = new Point(39, 259);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(104, 25);
            selectTeamLabel.TabIndex = 5;
            selectTeamLabel.Text = "Select Team";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(149, 251);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(182, 33);
            selectTeamDropDown.TabIndex = 6;
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(229, 223);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(102, 25);
            createNewTeamLink.TabIndex = 7;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "Create New";
            createNewTeamLink.LinkClicked += createNewTeamLink_LinkClicked;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.White;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.Location = new Point(103, 371);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(164, 45);
            createPrizeButton.TabIndex = 15;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.White;
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamButton.Location = new Point(105, 312);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(162, 40);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // teamPalyersLabel
            // 
            teamPalyersLabel.AutoSize = true;
            teamPalyersLabel.Location = new Point(418, 76);
            teamPalyersLabel.Name = "teamPalyersLabel";
            teamPalyersLabel.Size = new Size(115, 25);
            teamPalyersLabel.TabIndex = 17;
            teamPalyersLabel.Text = "Team/Players";
            // 
            // tournamentTeamListBox
            // 
            tournamentTeamListBox.FormattingEnabled = true;
            tournamentTeamListBox.ItemHeight = 25;
            tournamentTeamListBox.Location = new Point(356, 104);
            tournamentTeamListBox.Name = "tournamentTeamListBox";
            tournamentTeamListBox.Size = new Size(256, 154);
            tournamentTeamListBox.TabIndex = 18;
            // 
            // RemoveSelectedPlayersTeamButton
            // 
            RemoveSelectedPlayersTeamButton.FlatAppearance.BorderColor = Color.Silver;
            RemoveSelectedPlayersTeamButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            RemoveSelectedPlayersTeamButton.FlatAppearance.MouseOverBackColor = Color.White;
            RemoveSelectedPlayersTeamButton.FlatStyle = FlatStyle.Flat;
            RemoveSelectedPlayersTeamButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveSelectedPlayersTeamButton.Location = new Point(618, 151);
            RemoveSelectedPlayersTeamButton.Name = "RemoveSelectedPlayersTeamButton";
            RemoveSelectedPlayersTeamButton.Size = new Size(124, 74);
            RemoveSelectedPlayersTeamButton.TabIndex = 19;
            RemoveSelectedPlayersTeamButton.Text = "Remove Selected";
            RemoveSelectedPlayersTeamButton.UseVisualStyleBackColor = true;
            RemoveSelectedPlayersTeamButton.Click += RemoveSelectedPlayersTeamButton_Click;
            // 
            // removeSelectedPrizeButton
            // 
            removeSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.White;
            removeSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            removeSelectedPrizeButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedPrizeButton.Location = new Point(618, 342);
            removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            removeSelectedPrizeButton.Size = new Size(124, 74);
            removeSelectedPrizeButton.TabIndex = 22;
            removeSelectedPrizeButton.Text = "Remove Selected";
            removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            removeSelectedPrizeButton.Click += removeSelectedPrizeButton_Click;
            // 
            // prizesListBox
            // 
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 25;
            prizesListBox.Location = new Point(356, 301);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(256, 154);
            prizesListBox.TabIndex = 21;
            // 
            // PrizesLabel
            // 
            PrizesLabel.AutoSize = true;
            PrizesLabel.Location = new Point(445, 273);
            PrizesLabel.Name = "PrizesLabel";
            PrizesLabel.Size = new Size(57, 25);
            PrizesLabel.TabIndex = 20;
            PrizesLabel.Text = "Prizes";
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.White;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.Location = new Point(229, 489);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(383, 45);
            createTournamentButton.TabIndex = 23;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentLabel
            // 
            createTournamentLabel.AutoSize = true;
            createTournamentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentLabel.ForeColor = Color.RoyalBlue;
            createTournamentLabel.Location = new Point(34, 26);
            createTournamentLabel.Name = "createTournamentLabel";
            createTournamentLabel.Size = new Size(233, 32);
            createTournamentLabel.TabIndex = 24;
            createTournamentLabel.Text = "Create Tournament";
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 552);
            Controls.Add(createTournamentLabel);
            Controls.Add(createTournamentButton);
            Controls.Add(removeSelectedPrizeButton);
            Controls.Add(prizesListBox);
            Controls.Add(PrizesLabel);
            Controls.Add(RemoveSelectedPlayersTeamButton);
            Controls.Add(tournamentTeamListBox);
            Controls.Add(teamPalyersLabel);
            Controls.Add(addTeamButton);
            Controls.Add(createPrizeButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label tournamentNameLabel;
        private TextBox tournamentNameValue;
        private Label entryFeeLabel;
        private TextBox entryFeeValue;
        private Label selectTeamLabel;
        private ComboBox selectTeamDropDown;
        private LinkLabel createNewTeamLink;
        private Button createPrizeButton;
        private Button addTeamButton;
        private Label teamPalyersLabel;
        private ListBox tournamentTeamListBox;
        private Button RemoveSelectedPlayersTeamButton;
        private Button removeSelectedPrizeButton;
        private ListBox prizesListBox;
        private Label PrizesLabel;
        private Button createTournamentButton;
        private Label createTournamentLabel;
    }
}