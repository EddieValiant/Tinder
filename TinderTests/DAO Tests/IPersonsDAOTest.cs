using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tinder.DAO;
using FakeItEasy;
using Tinder.Models;
using System.Linq;

namespace TinderTests.DAO_Tests
{
    /// <summary>
    /// Summary description for IPersonsDAOTest
    /// </summary>
    [TestClass]
    public class IPersonsDAOTest
    {
        private IPersonsDAO personsDAO = PersonsDAO.Instance;
        private Person mockedPerson;

        [TestInitialize]
        public void SetUp()
        {
            this.mockedPerson = A.Fake<Person>();
        }
        
        [TestMethod]
        public void TestGetPerson()
        {
            Person testPerson = this.personsDAO.GetPerson("testUser");

            Assert.IsNotNull(testPerson);
        }

        [TestMethod]
        public void TestGetPersons()
        {
            IQueryable<Person> testPersons = this.personsDAO.GetPersons();

            Assert.IsNotNull(testPersons);
        }

        [TestMethod]
        public void TestUpdatePersonRecord()
        {            
            this.personsDAO.UpdatePersonRecord(this.mockedPerson);
        }
    }
}
