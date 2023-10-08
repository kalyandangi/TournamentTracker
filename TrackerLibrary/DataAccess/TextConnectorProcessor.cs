using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
        public static void SaveToPrizeFile(this List<PrizeModel> models, string filename)
        {
            List<string> lines = new List<string>();
            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id}, {p.PlaceName}, {p.PlaceNumber},{p.PrizeAmount}, {p.PrizePercentage}");

            }
            File.WriteAllLines(filename.FullFilePath(),lines);
        }
    }
}

        