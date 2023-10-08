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
        /// TODO -- Wireup the CreatePrize for the textfiles
       
        
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load the textfile
            //Convert the text to List<prizemodel>
            List<PrizeModel>prizes =PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            
            //Find the max id
           
            int currentId = prizes.OrderByDescending(x=>x.Id).First().Id + 1;
            model.Id = currentId;

            //Add the new record with the new ID (max+1)
            prizes.Add(model);

            //Convert the prizes to List<string>
            //Save the List<string>to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;   
        }
    }
}
