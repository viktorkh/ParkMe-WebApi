using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkMe_WepApi.Models
{
    public class OrderInfoModel
    {
        public string ID { get; set; }

        public List<TaskInfoModel> MyProperty { get; set; }

    }
}