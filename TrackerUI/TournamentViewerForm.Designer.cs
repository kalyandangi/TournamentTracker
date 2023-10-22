namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            roundLabel = new Label();
            tournamentLabel = new Label();
            tournamentName = new Label();
            roundDropDown = new ComboBox();
            unPlayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneNameLabel = new Label();
            scoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoNameLabel = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Location = new Point(34, 74);
            roundLabel.Margin = new Padding(2, 0, 2, 0);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(42, 15);
            roundLabel.TabIndex = 0;
            roundLabel.Text = "Round";
            // 
            // tournamentLabel
            // 
            tournamentLabel.AutoSize = true;
            tournamentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tournamentLabel.ForeColor = Color.RoyalBlue;
            tournamentLabel.Location = new Point(34, 25);
            tournamentLabel.Margin = new Padding(2, 0, 2, 0);
            tournamentLabel.Name = "tournamentLabel";
            tournamentLabel.Size = new Size(107, 21);
            tournamentLabel.TabIndex = 2;
            tournamentLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tournamentName.ForeColor = Color.RoyalBlue;
            tournamentName.Location = new Point(150, 25);
            tournamentName.Margin = new Padding(2, 0, 2, 0);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(74, 21);
            tournamentName.TabIndex = 3;
            tournamentName.Text = "<None>";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(83, 70);
            roundDropDown.Margin = new Padding(2);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(129, 23);
            roundDropDown.TabIndex = 4;
            // 
            // unPlayedOnlyCheckBox
            // 
            unPlayedOnlyCheckBox.AutoSize = true;
            unPlayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
            unPlayedOnlyCheckBox.Location = new Point(106, 93);
            unPlayedOnlyCheckBox.Margin = new Padding(2);
            unPlayedOnlyCheckBox.Name = "unPlayedOnlyCheckBox";
            unPlayedOnlyCheckBox.Size = new Size(101, 19);
            unPlayedOnlyCheckBox.TabIndex = 5;
            unPlayedOnlyCheckBox.Text = "Unplayed Only";
            unPlayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 15;
            matchupListBox.Location = new Point(42, 119);
            matchupListBox.Margin = new Padding(2);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(174, 77);
            matchupListBox.TabIndex = 6;
            matchupListBox.SelectedIndexChanged += matchupListBox_SelectedIndexChanged;
            // 
            // teamOneNameLabel
            // 
            teamOneNameLabel.AutoSize = true;
            teamOneNameLabel.Location = new Point(326, 68);
            teamOneNameLabel.Margin = new Padding(2, 0, 2, 0);
            teamOneNameLabel.Name = "teamOneNameLabel";
            teamOneNameLabel.Size = new Size(76, 15);
            teamOneNameLabel.TabIndex = 7;
            teamOneNameLabel.Text = "<Team One>";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(284, 93);
            scoreLabel.Margin = new Padding(2, 0, 2, 0);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(36, 15);
            scoreLabel.TabIndex = 8;
            scoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(323, 93);
            teamOneScoreValue.Margin = new Padding(2);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(106, 23);
            teamOneScoreValue.TabIndex = 9;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(326, 176);
            teamTwoScoreValue.Margin = new Padding(2);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(106, 23);
            teamTwoScoreValue.TabIndex = 12;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Location = new Point(286, 176);
            teamTwoScoreLabel.Margin = new Padding(2, 0, 2, 0);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(36, 15);
            teamTwoScoreLabel.TabIndex = 11;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoNameLabel
            // 
            teamTwoNameLabel.AutoSize = true;
            teamTwoNameLabel.Location = new Point(328, 152);
            teamTwoNameLabel.Margin = new Padding(2, 0, 2, 0);
            teamTwoNameLabel.Name = "teamTwoNameLabel";
            teamTwoNameLabel.Size = new Size(75, 15);
            teamTwoNameLabel.TabIndex = 10;
            teamTwoNameLabel.Text = "<Team Two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Location = new Point(346, 122);
            versusLabel.Margin = new Padding(2, 0, 2, 0);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(40, 15);
            versusLabel.TabIndex = 13;
            versusLabel.Text = "--VS--";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            scoreButton.FlatAppearance.MouseOverBackColor = Color.White;
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            scoreButton.Location = new Point(461, 122);
            scoreButton.Margin = new Padding(2);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(70, 26);
            scoreButton.TabIndex = 14;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(560, 270);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoNameLabel);
            Controls.Add(teamOneScoreValue);
            Controls.Add(scoreLabel);
            Controls.Add(teamOneNameLabel);
            Controls.Add(matchupListBox);
            Controls.Add(unPlayedOnlyCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(tournamentName);
            Controls.Add(tournamentLabel);
            Controls.Add(roundLabel);
            Margin = new Padding(2);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label roundLabel;
        private Label tournamentLabel;
        private Label tournamentName;
        private ComboBox roundDropDown;
        private CheckBox unPlayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Label teamOneNameLabel;
        private Label scoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoNameLabel;
        private Label versusLabel;
        private Button scoreButton;
    }
}