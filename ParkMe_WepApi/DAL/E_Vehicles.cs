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
    
    public partial class E_Vehicles
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string VehicleNumber { get; set; }
        public Nullable<int> VehicleTypeID { get; set; }
        public Nullable<int> VehicleColorID { get; set; }
    
        public virtual E_Customers E_Customers { get; set; }
        public virtual LT_VehicleColors LT_VehicleColors { get; set; }
        public virtual LT_VehicleTypes LT_VehicleTypes { get; set; }
    }
}