//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.DBEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserPaymentInfo
    {
        public int UserPaymentInfoID { get; set; }
        public Nullable<int> PackageInfoID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public Nullable<bool> AccountActivated { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
    }
}
