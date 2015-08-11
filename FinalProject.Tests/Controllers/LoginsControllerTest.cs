using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject.Controllers;
using FinalProject.App_Code;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FinalProject.Tests.Controllers
{
    [TestClass]
    public class LoginsControllerTest
    {
        [TestMethod]
        public void TestLoginAttemptOccurs()
        {
            Global.LoginAttempts.Clear();
            Assert.AreEqual(0, Global.LoginAttempts.Count);
            AuthController controller = new AuthController();
            Assert.AreEqual("\"true\"", controller.User(new Models.UserModel("fido", "1234pass")));
            Assert.AreEqual(1, Global.LoginAttempts.Count);
        }

        [TestMethod]
        public void TestDelete()
        {
            Global.LoginAttempts.Clear();
            Assert.AreEqual(0, Global.LoginAttempts.Count);
            AuthController controller = new AuthController();
            Assert.AreEqual("\"true\"", controller.User(new Models.UserModel("fido", "1234pass")));
            Assert.AreEqual(1, Global.LoginAttempts.Count);

            LoginsController loginsController = new LoginsController();
            loginsController.Delete(1);

            Assert.AreEqual(0, Global.LoginAttempts.Count);
        }
    }
}
