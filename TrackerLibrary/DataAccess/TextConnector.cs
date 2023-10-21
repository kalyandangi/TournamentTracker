using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModels.csv";
        private const string MatchupFile = "MatchupModels.csv";
        private const string MatchupEntryFile = "MatchEntryModels.csv";


        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;

            }
            model .Id = currentId;
            people.Add(model);
            people.SaveToPeopleFile(PeopleFile);

            return model;
        }

        /// TODO -- Wireup the CreatePrize for the textfiles


        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load the textfile
            //Convert the text to List<prizemodel>
            List<PrizeModel>prizes =PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //Find the max id
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;

            }
            model.Id = currentId;

            //Add the new record with the new ID (max+1)
            prizes.Add(model);

            //Convert the prizes to List<string>
            //Save the List<string>to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;   
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;

            }
            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile(TeamFile);

            return model;
        }

        public void  CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile
                .FullFilePath()
                .LoadFile() 
                .ConvertToTournamentModels();

            int currentId = 1;
                if (tournaments.Count > 0)
                {
                    currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;

                }
            model.Id = currentId;

           // tournaments.SaveToTournamentFile(model, MatchupFile, MatchupEntryFile);

            model.SaveRoundsToFile();

            tournaments .Add(model);

            tournaments.SaveToTournamentFile(TournamentFile);
        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels().ToList();

        }

        public List<TeamModel> GetTeam_All()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
        }

        public List<TournamentModel> GetTournament_All()
        {
            return GlobalConfig.TournamentFile
                  .FullFilePath()
                  .LoadFile()
                  .ConvertToTournamentModels();

        }
    }
}
