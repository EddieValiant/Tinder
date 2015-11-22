using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tinder.DAO;
using Tinder.Models;

namespace Tinder.Controllers
{
    public class PersonsController : ApiController
    {      
        private IPersonsDAO personsDAO = PersonsDAO.Instance;


        // GET api/persons/{username}
        public IQueryable<Person> Get()
        {
            return personsDAO.GetPersons();
        }

        // GET api/persons/{username}
        public Person Get(string username)
        {
            return personsDAO.GetPerson(username);
        }

        // POST api/persons
        public void Post([FromBody]Person person)
        {
            personsDAO.AddNewPerson(person);
        }

        // PUT api/persons/{id}
        public void Put([FromBody]Person person)
        {
            personsDAO.UpdatePersonRecord(person);
        }
    }
}
