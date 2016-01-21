using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkMe_WepApi.Models
{
    public class AccountInfoModel
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Password { get; set; }

        public string Token { get; set; }

        public List<OrderInfoModel> Orders { get; set; }

    }
}