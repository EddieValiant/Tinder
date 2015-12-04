using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeItEasy;
using Tinder;
using Tinder.Models;
using Tinder.DAO;
using Tinder.Controllers;

namespace TinderTests
{
    [TestClass]
    public class PersonsControllerTest
    {
        private IPersonsDAO mockedPersonsDAO;
        private PersonsController personsController;
        private Person mockedPerson;

        [TestInitialize]
        public void SetUp()
        {
            this.mockedPersonsDAO = A.Fake<IPersonsDAO>();
            this.personsController = new PersonsController(mockedPersonsDAO);
            this.mockedPerson = A.Fake<Person>();
        }

        [TestMethod]
        public void TestGetOnePerson()
        {
            this.personsController.Get("testUser");

            A.CallTo(() => this.mockedPersonsDAO.GetPerson("testUser")).MustHaveHappened();
        }

        [TestMethod]
        public void TestGetMultiplePeople()
        {
            this.personsController.Get();

            A.CallTo(() => this.mockedPersonsDAO.GetPersons()).MustHaveHappened();
        }

        [TestMethod]
        public void TestPost()
        {
            this.personsController.Post(this.mockedPerson);

            A.CallTo(() => this.mockedPersonsDAO.UpdatePersonRecord(this.mockedPerson)).MustHaveHappened();
        }

        [TestMethod]
        public void TestPut()
        {
            this.personsController.Put(this.mockedPerson);

            A.CallTo(() => this.mockedPersonsDAO.UpdatePersonRecord(this.mockedPerson)).MustHaveHappened();
        }
    }
}
