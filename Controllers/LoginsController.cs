using FinalProject.App_Code;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FinalProject.Controllers
{
    public class LoginsController : ApiController
    {
        [Route("logins")]
        // GET: Logins
        public string Get()
        {
            return JsonConvert.SerializeObject(Global.LoginAttempts);
        }

        [Route("logins/{id}")]
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(Global.LoginAttempts.ElementAt(id-1));
        }

        // DELETE: api/Auth/5
        [Route("logins/{id}")]
        public string Delete(int id)
        {
            Global.LoginAttempts.RemoveAt(id-1);
            return JsonConvert.SerializeObject("true");
        }
    }
}