using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkMe_WepApi.Models
{
    public class OrderInfoModel
    {
        public string ID { get; set; }

        //public List<TaskInfoModel> MyProperty { get; set; }

        public string CustomerID { get; set; }
        public string PhoneNumber { get; set; }
        public string OrderStatusID { get; set; }
        public string Description { get; set; }
        public string StartDateTime { get; set; }
        public string FinishDateTime { get; set; }

        //O.ID,O.CustomerID,C.PhoneNumber,O.OrderStatusID,OS.Description,O.StartDateTime,O.FinishDateTime

    }
}