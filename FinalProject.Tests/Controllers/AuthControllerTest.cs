using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject.Controllers;

namespace FinalProject.Tests.Controllers
{
    [TestClass]
    public class AuthControllerTest
    {
        [TestMethod]
        public void TestValidLogin()
        {
            AuthController controller = new AuthController();
            Assert.AreEqual("\"true\"", controller.User(new Models.UserModel("fido", "1234pass")));
        }

        [TestMethod]
        public void TestBadLogin()
        {
            AuthController controller = new AuthController();
            Assert.AreEqual("\"false\"", controller.User(new Models.UserModel("fido", "badpass")));
        }
    }
}
