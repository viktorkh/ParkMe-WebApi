//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParkMe_WepApi.DAL
{
    using System;
    
    public partial class spGetAllOrders_Result
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string PhoneNumber { get; set; }
        public int OrderStatusID { get; set; }
        public string Description { get; set; }
        public System.DateTime StartDateTime { get; set; }
        public Nullable<System.DateTime> FinishDateTime { get; set; }
    }
}
