using ParkMe_WepApi.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace ParkMe_WepApi.Controllers
{
   
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

       

      
        [HttpPost]
        public string GetToken([FromBody]string user, [FromBody]string password)
        {
            throw new Exception();
        }

      
        [HttpPost]
        public AccountInfoModel GetAccount([FromBody]string token)
        {
            throw new Exception();
        }

        [HttpPost]
        public string SetUp([FromBody]string user, [FromBody]string password)
        {
            throw new Exception();
        }





    }
}
