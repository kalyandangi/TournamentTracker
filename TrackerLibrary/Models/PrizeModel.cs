using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// uniquie identifier to Prize
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// the numeric identifier for the place( 3 for the third place...)
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// the friendly name for the place (first place, second place..)
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// the fix amount this place earns , if not used it is zero
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// the number that represents the percentages of the overall take 
        /// or zero if it is not used. the percentage is a fraction of 1.
        /// so (0.5 for 50%)
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
           
            PlaceName = placeName;
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;

        }

        public PrizeModel() 
        { 

        }

    }
}
