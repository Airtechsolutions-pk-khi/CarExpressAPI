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
    
    public partial class PurchaseReturn
    {
        public int ID { get; set; }
        public Nullable<int> PurchaseOrderID { get; set; }
        public string Name { get; set; }
        public Nullable<double> Cost { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<int> CurrentStock { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<int> StatusId { get; set; }
    
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
