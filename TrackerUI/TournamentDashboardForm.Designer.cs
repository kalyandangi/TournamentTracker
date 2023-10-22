namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            tournamentDashboardLabel = new Label();
            loadExistingTournamentLabel = new Label();
            loadExistingTournamentDropDown = new ComboBox();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            tournamentDashboardLabel.AutoSize = true;
            tournamentDashboardLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tournamentDashboardLabel.ForeColor = Color.RoyalBlue;
            tournamentDashboardLabel.Location = new Point(103, 29);
            tournamentDashboardLabel.Margin = new Padding(2, 0, 2, 0);
            tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            tournamentDashboardLabel.Size = new Size(190, 21);
            tournamentDashboardLabel.TabIndex = 26;
            tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Location = new Point(124, 62);
            loadExistingTournamentLabel.Margin = new Padding(2, 0, 2, 0);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(138, 15);
            loadExistingTournamentLabel.TabIndex = 27;
            loadExistingTournamentLabel.Text = "Load Existing Tournment";
            // 
            // loadExistingTournamentDropDown
            // 
            loadExistingTournamentDropDown.FormattingEnabled = true;
            loadExistingTournamentDropDown.Location = new Point(132, 92);
            loadExistingTournamentDropDown.Margin = new Padding(2);
            loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            loadExistingTournamentDropDown.Size = new Size(129, 23);
            loadExistingTournamentDropDown.TabIndex = 28;
          //  loadExistingTournamentDropDown.SelectedIndexChanged += loadExistingTournamentDropDown_SelectedIndexChanged;
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.White;
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loadTournamentButton.Location = new Point(103, 128);
            loadTournamentButton.Margin = new Padding(2);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(187, 26);
            loadTournamentButton.TabIndex = 29;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            loadTournamentButton.Click += loadTournamentButton_Click;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.White;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.Location = new Point(103, 169);
            createTournamentButton.Margin = new Padding(2);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(187, 26);
            createTournamentButton.TabIndex = 30;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(405, 230);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentDropDown);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(tournamentDashboardLabel);
            Margin = new Padding(2);
            Name = "TournamentDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentDashboardLabel;
        private Label loadExistingTournamentLabel;
        private ComboBox loadExistingTournamentDropDown;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}