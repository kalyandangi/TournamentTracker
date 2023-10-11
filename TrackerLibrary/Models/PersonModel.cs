using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// uniquie identifier to person
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The First name of the person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The primary email address of the person
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The primary phone of the person
        /// </summary>
        public string PhoneNumber { get; set; }

        public string  FullName 
        { get
            {
                return  $"{FirstName} {LastName}";
            }
               
        }
    }
}
