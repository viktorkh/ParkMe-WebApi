using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkMe_WepApi.Models
{
    public class TaskInfoModel
    {
        public int ID { get; set; }

        public string taskName { get; set; }

        public string LatSource { get; set; }
        public string LongSource { get; set; }

        
        public string LatDestination { get; set; }
        public string LongDestination { get; set; }
    }
}