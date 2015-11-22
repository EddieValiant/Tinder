using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tinder.Models;

namespace Tinder.DAO
{
    public interface IPersonsDAO
    {
        /// <summary>
        /// Gets the person.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        Person GetPerson(string username);

        /// <summary>
        /// Gets the persons.
        /// </summary>
        /// <returns></returns>
        IQueryable<Person> GetPersons();

        /// <summary>
        /// Gets the matches.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        IQueryable<Person> GetMatches(string username);

        /// <summary>
        /// Gets the not interested persons.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        IQueryable<Person> GetNotInterestedPersons(string username);

        /// <summary>
        /// Updates the person record.
        /// </summary>
        /// <param name="person">The person.</param>
        void UpdatePersonRecord(Person person);

        /// <summary>
        /// Adds the new person.
        /// </summary>
        /// <param name="person">The person.</param>
        void AddNewPerson(Person person);
    }
}
