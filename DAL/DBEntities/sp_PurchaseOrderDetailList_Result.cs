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
    
    public partial class sp_PurchaseOrderDetailList_Result
    {
        public int ID { get; set; }
        public Nullable<int> PurchaseOrderID { get; set; }
        public Nullable<int> ItemId { get; set; }
        public string Name { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public Nullable<int> RequestedQty { get; set; }
        public string Remarks { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<int> StatusId { get; set; }
    }
}
