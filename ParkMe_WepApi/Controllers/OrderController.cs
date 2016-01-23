using ParkMe_WepApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ParkMe_WepApi.DAL;
using System.Data.Entity.Core.Objects;
using System.Globalization;

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
        [HttpPost]
        //   public string SetOrder([FromBody]string token, [FromBody]string orderTime, [FromBody]string orderAddress)
        public string SetOrder(string token, string orderTime, string orderAddress)

        {


            //using (TestDBEntities1 context = new TestDBEntities1())
            //{
            //  //  context.spCreateOrder(token, DateTime.Parse(orderTime), orderAddress);
            //}


            return "fff";
        }


        [HttpGet]
        //   public string SetOrder([FromBody]string token, [FromBody]string orderTime, [FromBody]string orderAddress)
        public string SetOrderGet(string token, string orderTime, string orderAddress)

        {
            string result="";
            int? d;
            try
            {
                CultureInfo provider = CultureInfo.InvariantCulture;
                string format = "dd-MM-yyyy HH:mm";
                DateTime time = DateTime.ParseExact(orderTime,format,provider);

                using (TestDBEntities1 context = new TestDBEntities1())
                {
                    //  result = context.spCreateOrder(token, time, orderAddress,returnVal:d).ToString();
                 var dd= context.spCreateOrder1(token, time, orderAddress).FirstOrDefault();


                    result = dd.ToString(); 
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

            return result;
        }

        public string Post()
        {

            return "POST Hello";
        }
    }
}
