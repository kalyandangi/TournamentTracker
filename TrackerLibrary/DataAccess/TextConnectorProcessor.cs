﻿using System.Configuration;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using TrackerLibrary.Models;


//Load the textfile
//Convert the text to List<prizemodel>
//Find the max id
//Add the new record with the new ID (max+1)
//Convert the prizes to List<string>
//Save the List<string>to the text file

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string filename) //prizeModel.csv
        {
           
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{filename}";
        }
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file)) //File.Exists(file)==false
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceName = cols[1];
                p.PlaceNumber = int.Parse(cols[2]);
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }
            return output;
        }
        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.PhoneNumber = cols[4];
                output.Add(p);

            }
            return output;
        }
        public static void SaveToPrizeFile(this List<PrizeModel> models)
        {
            List<string> lines = new List<string>();
            foreach (PrizeModel p in models)
            {
                lines.Add($"{ p.Id }, { p.PlaceName }, { p.PlaceNumber },{ p.PrizeAmount }, { p.PrizePercentage }");

            }
            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);
        }
        public static List<TeamModel> ConvertToTeamModels(this List<string> lines)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();


            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TeamModel t = new TeamModel
                {
                    Id = int.Parse(cols[0]),
                    TeamName = cols[1],
                };


                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());

                }
                output.Add(t);
            }


            return output;
        }
        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines)
        {
            //id =0
            //TournamentName = 1
            //EntryFee = 2
            //EnteredTeams = 3
            //Prizes =4
            //Rounds = 5
            //id,TournamentName,EntryFee,(id|id|id -- Entered Team),(id|id|id , Prizes), 
            //(Rounds - id^id^id| id^id^id|id^id^id)
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');

                foreach (string id in teamIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());

                }
                if (cols[4].Length > 0)
                {
                    string[] prizeIds = cols[4].Split('|');

                    foreach (string id in prizeIds)
                    {
                        tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                    }
                }
               //Captures Round Information
               string[] rounds = cols[5].Split('|');

               

                foreach (string round in rounds)
                {
                    string[] msText = round.Split('^');
                    List<MatchupModel> ms = new List<MatchupModel>();

                    foreach (string matchupModelTextId in msText)
                    {
                        ms.Add(matchups.Where(x => x.Id == int.Parse(matchupModelTextId)).First());
                    }

                    tm.Rounds.Add(ms);
                }

                output.Add(tm);
            }
            return output;
        }
        public static void SaveToPeopleFile(this List<PersonModel> models)
        {
            List<string> lines = new List<string>();
            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.PhoneNumber}");
            }
            File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(), lines);
        }
        public static void SaveToTeamFile(this List<TeamModel> models)
        {
            List<string> lines = new List<string>();
            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");

            }

            File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), lines);
        }
        public static void SaveRoundsToFile(this TournamentModel model)
        {
            //loop through each round
            //loop through each matchup
            //get the id for the new matchup and save the record
            //loop through each Entry, get the id and   it   
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    //load all of the matchus from file
                    //Get the top id and add one
                    //store the id
                    // save the matchup record
                    matchup.SaveMatchupToFile();
                }
            }
        }
        public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                MatchupEntryModel me = new MatchupEntryModel();

                me.Id = int.Parse(cols[0]);

                if (cols[1].Length == 0)
                {
                    me.TeamCompeting = null;
                }
                else
                {
                    int teamId;
                    if (int.TryParse(cols[1], out teamId))
                    {
                        me.TeamCompeting = LookupTeamById(teamId);
                    }
                }

                if (double.TryParse(cols[2], out double score))
                {
                    me.Score = score;
                }
                else
                {
                    // Handle the case where the string cannot be parsed as a double.
                    // You can set a default value or handle the error as needed.
                    me.Score = 0.0; // Example: Set the score to 0.0 as a default value.
                }

                int parentId = 0;
                if (int.TryParse(cols[3], out parentId))
                {
                    me.ParentMatchup = LookupMatchupById(parentId);
                }
                else
                {
                    me.ParentMatchup = null;
                }
                output.Add(me);
            }

            return output;
        }
        private static List<MatchupEntryModel> ConvertStringToMatchupEntryModels(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
            List<string> matchingEntires= new List<string>();

            foreach (string id in ids)
            {
                foreach (string entry in entries)
                {
                    string[] cols = entry.Split(',');

                    if (cols[0] == id)
                    {
                        matchingEntires.Add(entry);
                    }
                }
            }
            output =matchingEntires.ConvertToMatchupEntryModels();
            return output;
        }
        private static TeamModel? LookupTeamById(int id)
        {
            List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();
            List<string> matchingTeams = new List<string>(); // Move this outside the loop

            foreach (string team in teams)
            {
                string[] cols = team.Split(',');
                if (cols[0] == id.ToString())
                {
                    matchingTeams.Add(team);
                }
            }

            return matchingTeams.ConvertToTeamModels()?.FirstOrDefault();
        }
        private static MatchupModel LookupMatchupById(int id)
        {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

            foreach (string matchup in matchups)
            {
                string[] cols = matchup.Split(',');
                if (cols[0] == id.ToString())
                {
                    List<string> matchingMatchups = new List<string>();
                    matchingMatchups.Add(matchup);
                    return matchingMatchups.ConvertToMatchupModels().First();
                }
            }
            return null;
        }
        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            //if = 0, entries = 1(pipe delimited by id), winner = 2, matchupRound = 3
            List<MatchupModel> output = new List<MatchupModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                MatchupModel m = new MatchupModel();

                if (int.TryParse(cols[0], out int id))
                {
                    m.Id = id;

                    m.Entries = ConvertStringToMatchupEntryModels(cols[1]);

                    if (int.TryParse(cols[2], out int winnerId))
                    {
                        m.Winner = LookupTeamById(winnerId);
                    }
                    else
                    {
                        m.Winner = null; // Handle the case where winner ID is not a valid integer.
                    }

                    if (int.TryParse(cols[3], out int matchupRound))
                    {
                        m.MatchupRound = matchupRound;
                    }
                    output.Add(m);
                }
               
            }
            return output;
        }
        public static void SaveMatchupToFile(this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile() .ConvertToMatchupModels();

            int currenId = 1;
            if (matchups.Count > 0)
            {
                currenId = matchups.OrderByDescending(x => x.Id).First().Id+1;
            }
            matchup.Id = currenId;

            matchups.Add(matchup);

            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.SaveEntryToFile();
            }

            // Save to File
            List<string> lines = new List<string>();
            foreach(MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{m.Id}, {ConvertMatchupEntryListToString(m.Entries)}, {winner}, {m.MatchupRound}");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }
        
        public static void UpdateMatchupToFile(this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            MatchupModel oldMatchup = new MatchupModel();

            foreach (MatchupModel m in matchups)
            {
                if (m.Id == matchup.Id)
                {
                    oldMatchup = m;
                }
            }

            matchups.Remove(oldMatchup);

            matchups.Add(matchup);

            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.UpdateEntryToFile();
            }

            List<string> lines = new List<string>();

            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{m.Id},{ConvertMatchupEntryListToString(m.Entries)},{winner},{m.MatchupRound}");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }

        public static void SaveEntryToFile(this MatchupEntryModel entry)
        {
            
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            int currentId = 1;

            if(entries.Count > 0)
            {
                currentId = entries.OrderByDescending(x => x.Id+1).First().Id+1;

            }
            entry.Id = currentId;
            entries.Add(entry);

            //save to File

            List<string> lines = new List<string>();
            foreach (MatchupEntryModel e in entries)
            {
                string parent = "";
                if(e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if(e.TeamCompeting != null)
                {
                   teamCompeting = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{e.Id}, {teamCompeting},{e.Score},{parent}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }
        public static void UpdateEntryToFile(this MatchupEntryModel entry)
        {

            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();
            MatchupEntryModel oldEntry = new MatchupEntryModel();
            foreach (MatchupEntryModel e in entries)
            {
                if(e.Id == entry.Id)
                {
                    oldEntry = e;
                }

            }
            entries.Remove(oldEntry);

            entries.Add(entry);

            List<string> lines = new List<string>();
            foreach (MatchupEntryModel e in entries)
            {
                string parent = "";
                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if (e.TeamCompeting != null)
                {
                    teamCompeting = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{e.Id}, {teamCompeting},{e.Score},{parent}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }
        public static void SaveToTournamentFile(this List<TournamentModel> models)
        {
            //id =0
            //TournamentName = 1
            //EntryFee = 2
            //EnteredTeams = 3
            //Prizes =4
            //Rounds = 5
            //(Rounds - id^id^id| id^id^id|id^id^id)

            List<string>lines = new List<string> ();

            foreach (TournamentModel tm in models)
            {
                lines.Add($"{tm.Id},{tm.TournamentName},{ tm.EntryFee},{ConvertTeamListToString(tm.EnteredTeams)},{ConvertPrizeListToString(tm.Prizes)},{ConvertRoundListToString(tm.Rounds)}");
            }
            File.WriteAllLines(GlobalConfig.TournamentFile.FullFilePath(), lines);
        }
        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            //(Rounds - id^id^id| id^id^id|id^id^id)
            string output = string.Empty;
            if (rounds.Count == 0)
            {
                return "";
            }
            foreach (List<MatchupModel> r in rounds)
            {
                output += $"{ConvertMatchupListToString(r) }|";

            }
            output = output.Substring(0, output.Length - 1);

            return output.Trim('|');
        }
        public static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = string.Empty;
            if(matchups.Count == 0)
            {
                return "";
            }
            foreach (MatchupModel m in matchups)
            {
                output += $"{m.Id}^";
            }
            output = output.Substring(0, output.Length-1);
            return output.Trim('|');
        }
        private static string ConvertMatchupEntryListToString(List<MatchupEntryModel> entries)
        {
            string output = "";

            if (entries.Count == 0)
                {
                return  "";
                 }
            foreach (MatchupEntryModel e in entries)
            {
                output += $"{e.Id}|";
            }
            output = output.Substring (0, output.Length-1);
            return output;
        }
        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";
            if (prizes.Count == 0)
            {
                return "";
            }
            foreach (PrizeModel p in prizes)
            {
                output += $"{p.Id}|";

            }
            output = output.Substring(0, output.Length - 1);

            return output;

        }
        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";
            if (teams.Count == 0)
            {
                return "";
            }
            foreach (TeamModel t in teams)
            {
                output += $"{t.Id}|";

            }
            output = output.Substring(0, output.Length - 1);

            return output;

        }             
        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";
            if(people.Count == 0)
            {
                return "";
            }
            foreach (PersonModel p in people)
            {
                output += $"{ p.Id }|";

            }
            output = output.Substring(0, output.Length -1);

            return output;
        }
    } 
}

        