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
    
    public partial class OrderDealDetail
    {
        public int ID { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> OrderDetailID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
    }
}
