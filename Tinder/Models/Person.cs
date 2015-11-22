using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tinder.Models
{

    // In the hypothetical world where this api is used, 
    // there are no pictures because people are only 
    // interested in a person's personality. Also, metadata
    // about a person could get a good bit more complicated
    // than this. It should also probably contain "looking 
    // for" information like age, sexual preference, etc.
    public class Person
    {
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the sex.
        /// </summary>
        /// <value>
        /// The sex.
        /// </value>
        public string Sex { get; set; }
                
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the matches.
        /// </summary>
        /// <value>
        /// The matches.
        /// </value>
        public List<Person> Matches { get; set; }

        /// <summary>
        /// Gets or sets the not interested.
        /// </summary>
        /// <value>
        /// The not interested.
        /// </value>
        public List<Person> NotInterested { get; set; }
    }
}