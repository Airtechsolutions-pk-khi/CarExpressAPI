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
    
    public partial class OrderDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderDetail()
        {
            this.OrderDealDetails = new HashSet<OrderDealDetail>();
            this.OrderModifierDetails = new HashSet<OrderModifierDetail>();
        }
    
        public int ID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> ItemId { get; set; }
        public Nullable<int> TransactionNo { get; set; }
        public Nullable<int> OrderNo { get; set; }
        public string Name { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> DiscountPrice { get; set; }
        public Nullable<double> PriceWithVAT { get; set; }
        public Nullable<double> Cost { get; set; }
        public Nullable<double> TotalCost { get; set; }
        public Nullable<double> LoyaltyPoints { get; set; }
        public string ClientOrderTakeDT { get; set; }
        public Nullable<double> CurrentQty { get; set; }
        public Nullable<bool> IsComplementory { get; set; }
        public string OrderMode { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string LastUpdateBy { get; set; }
        public Nullable<System.DateTime> LastUpdateDT { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ItemType { get; set; }
        public Nullable<int> DealID { get; set; }
        public Nullable<bool> IsVATApplied { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDealDetail> OrderDealDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderModifierDetail> OrderModifierDetails { get; set; }
    }
}
