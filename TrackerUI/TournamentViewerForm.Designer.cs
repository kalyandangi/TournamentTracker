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
            teamOneScoreLabel = new Label();
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
            roundLabel.Location = new Point(49, 123);
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
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tournamentName.ForeColor = Color.RoyalBlue;
            tournamentName.Location = new Point(214, 42);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(110, 32);
            tournamentName.TabIndex = 3;
            tournamentName.Text = "<None>";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(119, 117);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(183, 33);
            roundDropDown.TabIndex = 4;
            roundDropDown.SelectedIndexChanged += roundDropDown_SelectedIndexChanged;
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
            unPlayedOnlyCheckBox.CheckedChanged += unPlayedOnlyCheckBox_CheckedChanged;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 25;
            matchupListBox.Location = new Point(60, 198);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(248, 127);
            matchupListBox.TabIndex = 6;
            matchupListBox.SelectedIndexChanged += matchupListBox_SelectedIndexChanged;
            // 
            // teamOneNameLabel
            // 
            teamOneNameLabel.AutoSize = true;
            teamOneNameLabel.Location = new Point(466, 113);
            teamOneNameLabel.Name = "teamOneNameLabel";
            teamOneNameLabel.Size = new Size(115, 25);
            teamOneNameLabel.TabIndex = 7;
            teamOneNameLabel.Text = "<Team One>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Location = new Point(406, 155);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(56, 25);
            teamOneScoreLabel.TabIndex = 8;
            teamOneScoreLabel.Text = "Score";
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
            teamTwoScoreValue.Location = new Point(466, 293);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(150, 31);
            teamTwoScoreValue.TabIndex = 12;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Location = new Point(409, 293);
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
            versusLabel.Location = new Point(494, 203);
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
            scoreButton.Location = new Point(659, 203);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(100, 43);
            scoreButton.TabIndex = 14;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            scoreButton.Click += scoreButton_Click;
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
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneNameLabel);
            Controls.Add(matchupListBox);
            Controls.Add(unPlayedOnlyCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(tournamentName);
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
        private Label tournamentName;
        private ComboBox roundDropDown;
        private CheckBox unPlayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Label teamOneNameLabel;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoNameLabel;
        private Label versusLabel;
        private Button scoreButton;
    }
}