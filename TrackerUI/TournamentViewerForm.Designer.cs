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
            tournamentNameLabel = new Label();
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
            roundLabel.Location = new Point(49, 124);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(64, 25);
            roundLabel.TabIndex = 0;
            roundLabel.Text = "Round";
            // 
            // tournamentLabel
            // 
            tournamentLabel.AutoSize = true;
            tournamentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tournamentLabel.ForeColor = Color.RoyalBlue;
            tournamentLabel.Location = new Point(49, 42);
            tournamentLabel.Name = "tournamentLabel";
            tournamentLabel.Size = new Size(160, 32);
            tournamentLabel.TabIndex = 2;
            tournamentLabel.Text = "Tournament:";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = Color.RoyalBlue;
            tournamentNameLabel.Location = new Point(215, 42);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(110, 32);
            tournamentNameLabel.TabIndex = 3;
            tournamentNameLabel.Text = "<None>";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(119, 116);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(182, 33);
            roundDropDown.TabIndex = 4;
            // 
            // unPlayedOnlyCheckBox
            // 
            unPlayedOnlyCheckBox.AutoSize = true;
            unPlayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
            unPlayedOnlyCheckBox.Location = new Point(151, 155);
            unPlayedOnlyCheckBox.Name = "unPlayedOnlyCheckBox";
            unPlayedOnlyCheckBox.Size = new Size(150, 29);
            unPlayedOnlyCheckBox.TabIndex = 5;
            unPlayedOnlyCheckBox.Text = "Unplayed Only";
            unPlayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 25;
            matchupListBox.Location = new Point(60, 198);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(247, 127);
            matchupListBox.TabIndex = 6;
            // 
            // teamOneNameLabel
            // 
            teamOneNameLabel.AutoSize = true;
            teamOneNameLabel.Location = new Point(465, 114);
            teamOneNameLabel.Name = "teamOneNameLabel";
            teamOneNameLabel.Size = new Size(115, 25);
            teamOneNameLabel.TabIndex = 7;
            teamOneNameLabel.Text = "<Team One>";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(405, 155);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(56, 25);
            scoreLabel.TabIndex = 8;
            scoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(461, 155);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(150, 31);
            teamOneScoreValue.TabIndex = 9;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(465, 294);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(150, 31);
            teamTwoScoreValue.TabIndex = 12;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Location = new Point(409, 294);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(56, 25);
            teamTwoScoreLabel.TabIndex = 11;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoNameLabel
            // 
            teamTwoNameLabel.AutoSize = true;
            teamTwoNameLabel.Location = new Point(469, 253);
            teamTwoNameLabel.Name = "teamTwoNameLabel";
            teamTwoNameLabel.Size = new Size(114, 25);
            teamTwoNameLabel.TabIndex = 10;
            teamTwoNameLabel.Text = "<Team Two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Location = new Point(495, 204);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(61, 25);
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
            scoreButton.Location = new Point(659, 204);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(100, 43);
            scoreButton.TabIndex = 14;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
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
            Controls.Add(tournamentNameLabel);
            Controls.Add(tournamentLabel);
            Controls.Add(roundLabel);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label roundLabel;
        private Label tournamentLabel;
        private Label tournamentNameLabel;
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