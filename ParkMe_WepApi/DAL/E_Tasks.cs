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
    using System.Collections.Generic;
    
    public partial class E_Tasks
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public Nullable<int> ValetID { get; set; }
        public int StatusID { get; set; }
        public Nullable<double> FromLatitude { get; set; }
        public Nullable<double> FromLongitude { get; set; }
        public int TaskTypeID { get; set; }
        public string AddressFrom { get; set; }
        public string AddressTo { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<System.DateTime> FinishDateTime { get; set; }
    
        public virtual E_Orders E_Orders { get; set; }
        public virtual E_Valets E_Valets { get; set; }
        public virtual LT_TaskStatuses LT_TaskStatuses { get; set; }
    }
}
