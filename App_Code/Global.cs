using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Web;

namespace FinalProject.App_Code
{
    public class Global
    {
        public static List<LoginAttempt> LoginAttempts = new List<LoginAttempt>();
        public static List<UserModel> Users = new List<UserModel> { new UserModel("test", "test"), new UserModel("1234pass", "fido") };
    }
}
