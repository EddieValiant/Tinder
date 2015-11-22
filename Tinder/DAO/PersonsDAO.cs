using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tinder.Models;

namespace Tinder.DAO
{
    /// <summary>
    /// Implement these in order to connect to your backend system.
    /// </summary>
    public class PersonsDAO : IPersonsDAO
    {
        /// <summary>
        /// The instance
        /// </summary>
        public static PersonsDAO instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static PersonsDAO Instance
        {
            get
            {
                if (instance == null)
                    {
                        instance = new PersonsDAO();
                    }
                return instance;
            }
        }

        /// <summary>
        /// Gets the person.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Person GetPerson(string username)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the persons.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IQueryable<Person> GetPersons()
        {            
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the matches.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IQueryable<Person> GetMatches(string username)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the not interested persons.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IQueryable<Person> GetNotInterestedPersons(string username)
        {
            throw new NotImplementedException();
        }
       
        /// <summary>
        /// Updates the person record.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void UpdatePersonRecord(int id, Person username)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds the new person.
        /// </summary>
        public void AddNewPerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}