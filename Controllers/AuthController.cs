using FinalProject.App_Code;
using FinalProject.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{

    [Authorize]
    public class AuthController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Title = "Log In";

            return View();
        }

        // POST: api/Auth
        [HttpPost]
        public string User(UserModel login)
        {
            Global.LoginAttempts.Add(new LoginAttempt(new UserModel(login.username, login.password)));

            if (AuthenticateUser(login.password, login.username))
            {
                return JsonConvert.SerializeObject("true");
            }
            else
            {
                return JsonConvert.SerializeObject("false");
            }
        }

        private Boolean AuthenticateUser(string username, string password)
        {
            foreach (UserModel user in Global.Users) {
                if (user.username.Equals(username) && user.password.Equals(password))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
