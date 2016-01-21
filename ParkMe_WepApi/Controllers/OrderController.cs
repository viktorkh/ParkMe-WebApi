using ParkMe_WepApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ParkMe_WepApi.Controllers
{
    public class OrderController : ApiController
    {
        // GET: api/Order
       
        [HttpPost]
        public IEnumerable<OrderInfoModel> GetOrders([FromBody]string token)
        {
            throw new Exception();
        }
        [HttpPost]
        public OrderInfoModel GetOrderById([FromBody]string token, [FromBody]string orderId)
        {
            throw new Exception();
        }
        [HttpPost]
        public bool ConfirmTaskById([FromBody]string token, [FromBody]string orderId, [FromBody]string taskId)
        {
            throw new Exception();
        }
    }
}
