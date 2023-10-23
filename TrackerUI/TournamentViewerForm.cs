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
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        List<int> rounds = new List<int>();
        List<MatchupModel> selectedMatchups = new List<MatchupModel>();
        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();
            tournament = tournamentModel;
            LoadFormData();
            LoadRounds();

        }

        void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
        }

        private void WireUpRoundsLists()
        {
            roundDropDown.DataSource = null;
            roundDropDown.DataSource = rounds;
        }

        private void WireUpMatchupsLists()
        {
            matchupListBox.DataSource = null;
            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "DisplayName";
        }
        private void LoadRounds()
        {

            rounds = new List<int>();
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

            WireUpRoundsLists();
        }
        private void loadExistingTournamentDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private void LoadMatchups()
        {
            int round = (int)roundDropDown.SelectedItem;
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups = matchups;
                }
            }
            WireUpMatchupsLists();
        }
        private void LoadMatchup()
        {
            if (matchupListBox.SelectedItem != null)
            {
                MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;
                for (int i = 0; i < m.Entries.Count; i++)
                {
                    if (i == 0)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {
                            teamOneNameLabel.Text = m.Entries[0].TeamCompeting.TeamName;
                            teamOneScoreValue.Text = m.Entries[0].Score.ToString();
                        }
                        else
                        {
                            teamOneNameLabel.Text = "NotYet Set";
                            teamOneScoreValue.Text = "";
                        }
                    }
                    if (i == 1)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {
                            teamTwoNameLabel.Text = m.Entries[0].TeamCompeting.TeamName;
                            teamTwoScoreValue.Text = m.Entries[0].Score.ToString();
                        }
                        else
                        {
                            teamTwoNameLabel.Text = "NotYet Set";
                            teamTwoScoreValue.Text = "";
                        }
                    }
                }
            }
        }
        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup();
        }
    }
}