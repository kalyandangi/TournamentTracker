using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

        //BindingSource roundsBinding = new BindingSource();
        //BindingSource matchupsBinding = new BindingSource();
        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();
            tournament = tournamentModel;

            WireUpLists();
            LoadFormData();
            LoadRounds();

        }

        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
        }

        private void WireUpLists()
        {
            //roundDropDown.DataSource = null;
            //roundsBinding.DataSource = rounds;
            roundDropDown.DataSource = rounds;
            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "DisplayName";
            //roundDropDown.DataSource = rounds;
        }


        private void LoadRounds()
        {

            //rounds = new BindingList<int>();
            rounds.Clear();
            rounds.Add(1);

            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {

                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }
            LoadMatchups(1);
            //WireUpRoundsLists();
            // roundsBinding.ResetBindings(false);
        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropDown.SelectedItem);

        }

        private void LoadMatchups(int round)
        {
            // int round = (int)roundDropDown.SelectedItem;
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        if (m.Winner == null || !unPlayedOnlyCheckBox.Checked)
                        {
                            selectedMatchups.Add(m);
                        }
                    }
                }
            }
            if (selectedMatchups.Count > 0)
            {
                LoadMatchup(selectedMatchups.First());
            }
            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);
            teamOneNameLabel.Visible = isVisible;
            teamOneScoreLabel.Visible = isVisible;
            teamOneScoreValue.Visible = isVisible;

            teamTwoNameLabel.Visible = isVisible;
            teamTwoScoreLabel.Visible = isVisible;
            teamTwoScoreValue.Visible = isVisible;
            
            versusLabel.Visible = isVisible;
            scoreButton.Visible = isVisible;




        }

        private void LoadMatchup(MatchupModel m)
        {
            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        teamOneNameLabel.Text = m.Entries[0].TeamCompeting.TeamName;
                        teamOneScoreValue.Text = m.Entries[0].Score.ToString();

                        teamTwoNameLabel.Text = "<bye>";
                        teamTwoScoreValue.Text = "";
                    }
                    else
                    {
                        teamOneNameLabel.Text = "NotYet Set";
                        teamOneScoreValue.Text = "";
                    }
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        teamTwoNameLabel.Text = m.Entries[1].TeamCompeting.TeamName;
                        teamTwoScoreValue.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        teamTwoNameLabel.Text = "NotYet Set";
                        teamTwoScoreValue.Text = "";
                    }
                }

            }
        }
        //private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (matchupListBox.SelectedItems.Count > 0)
        //    {
        //        MatchupModel selectedMatchup = (MatchupModel)matchupListBox.SelectedItems[0];
        //        LoadMatchup(selectedMatchup);
        //    }
        //}

        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matchupListBox.SelectedItem != null)
            {
                LoadMatchup((MatchupModel)matchupListBox.SelectedItem);
            }
        }

        private void unPlayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            LoadMatchups((int)roundDropDown.SelectedItem);

        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            if (matchupListBox.SelectedItem != null)
            {
                MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;
                double teamOneScore = 0;
                double teamTwoScore = 0;
                for (int i = 0; i < m.Entries.Count; i++)
                {
                    if (i == 0)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {
                            teamOneNameLabel.Text = m.Entries[0].TeamCompeting.TeamName;
                            bool ScoreValid = double.TryParse(teamOneScoreValue.Text, out teamOneScore);
                            if (ScoreValid)
                            {
                                m.Entries[0].Score = teamOneScore;
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid score for team 1.");
                                return;
                            }
                        }
                    }
                    if (i == 1)
                    {
                        if (m.Entries[1].TeamCompeting != null)
                        {
                            bool ScoreValid = double.TryParse(teamTwoScoreValue.Text, out teamTwoScore);
                            if (ScoreValid)
                            {
                                m.Entries[0].Score = teamTwoScore;
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid score for team 2.");
                                return;
                            }
                        }
                    }
                }

                if (teamOneScore > teamTwoScore)
                {
                    //Team One Wins
                    m.Winner = m.Entries[0].TeamCompeting;
                }
                else if (teamTwoScore > teamOneScore)
                {
                    m.Winner = m.Entries[1].TeamCompeting;
                }
                else
                {
                    MessageBox.Show("I do not handle tie games.");
                }
                LoadMatchups((int)roundDropDown.SelectedItem);

                GlobalConfig.Connection.UpdateMatchup(m);


            }
        }
    }
}