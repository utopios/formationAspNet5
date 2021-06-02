using System;
using System.Collections.Generic;
using FormationApiRest.Controllers;
using FormationApiRest.Interfaces;
using FormationApiRest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ProjectTest
{

    [TestClass]
    public class PersonControllerTest
    {
        public PersonControllerTest()
        {
        }

        [TestMethod]
        public  void Get_Test()
        {
            //AAA
            //Arange
            PersonController controller = new PersonController();

            //Act

            var result = controller.Get().Result;

            //Assert

            Assert.IsInstanceOfType(result, typeof(ObjectResult));
        }

        [TestMethod]
        public void Get_Test_Return_Person()
        {
            //AAA
            //Arange
            PersonController controller = new PersonController();

            //Act

            ObjectResult result =  controller.Get().Result as ObjectResult;

            //Assert

            Assert.AreEqual((result.Value as List<Person>).Count, 2);
        }

        [TestMethod]
        public void Test_Avec_Mock()
        {
            //Arange

            var o = Mock.Of<ITokenGenerator>();
            //Act
            Mock.Get(o).Setup(m => m.GenerateToken("login","password")).Returns("notretoken");
            LoginController l = new LoginController(o);
            l.Post(new UserRecord("login", "password"));
            //Assert.AreEqual(o.GenerateToken("login", "password"), "notretoken");
            Mock.Verify(Mock.Get(o));
        }
    }
}
