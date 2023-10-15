using System.Configuration;
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
            // E:\dotNetDemo\TournamentTrackerDataFile\prizeModel.csv
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
        public static void SaveToPrizeFile(this List<PrizeModel> models, string filename)
        {
            List<string> lines = new List<string>();
            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id}, {p.PlaceName}, {p.PlaceNumber},{p.PrizeAmount}, {p.PrizePercentage}");

            }
            File.WriteAllLines(filename.FullFilePath(), lines);
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();


            foreach (string line in lines)
            {
                string[] cols = line.Split(",");
                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split("|");

                foreach (string id  in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());

                }
                output.Add(t);
            }
          

            return output;
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string filename)
        {
            List<string> lines = new List<string>();
            foreach(PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.PhoneNumber}");
            }
            File.WriteAllLines (filename.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string filename)
        {
            List<string> lines = new List<string> ();
            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");

            }

            File.WriteAllLines(filename.FullFilePath(), lines);
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

        