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
    
    public partial class E_Valets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public E_Valets()
        {
            this.E_Tasks = new HashSet<E_Tasks>();
            this.REL_ValetsViolations = new HashSet<REL_ValetsViolations>();
        }
    
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int DriverLicenseCategoryID { get; set; }
        public string DriverLicenseNumber { get; set; }
        public Nullable<System.DateTime> DriverLicenseExpDate { get; set; }
        public Nullable<System.DateTime> Birthdate { get; set; }
        public string PhoneNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<E_Tasks> E_Tasks { get; set; }
        public virtual LT_DriverLicenseCategories LT_DriverLicenseCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REL_ValetsViolations> REL_ValetsViolations { get; set; }
    }
}
