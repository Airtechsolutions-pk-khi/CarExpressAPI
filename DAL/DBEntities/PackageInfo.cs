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
    
    public partial class PackageInfo
    {
        public int PackageInfoID { get; set; }
        public string PackageName { get; set; }
        public Nullable<decimal> SetupFee { get; set; }
        public Nullable<decimal> PackagePrice { get; set; }
        public Nullable<bool> AdminPanel { get; set; }
        public Nullable<bool> LimitedDevice { get; set; }
        public Nullable<int> DevicesCount { get; set; }
        public Nullable<bool> Support { get; set; }
        public Nullable<int> TrialPeriod { get; set; }
        public Nullable<bool> PaymentIntegration { get; set; }
        public string IOSApp { get; set; }
        public string AndriodApp { get; set; }
        public string Website { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CountryCode { get; set; }
        public Nullable<int> BranchLimit { get; set; }
    }
}
