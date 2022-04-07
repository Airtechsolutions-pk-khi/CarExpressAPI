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
    
    public partial class sp_OrderReportHeaderMultiLoc_Result
    {
        public int ID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> TransactionNo { get; set; }
        public Nullable<int> OrderNo { get; set; }
        public Nullable<int> TableNo { get; set; }
        public Nullable<int> WaiterNo { get; set; }
        public Nullable<int> OrderTakerID { get; set; }
        public Nullable<System.DateTime> OrderCreatedDT { get; set; }
        public string OrderType { get; set; }
        public Nullable<int> GuestCount { get; set; }
        public string DeliveryAddress { get; set; }
        public Nullable<int> AgentID { get; set; }
        public string AgentName { get; set; }
        public string DeliveryTime { get; set; }
        public Nullable<double> Points { get; set; }
        public string OrderMode { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string SessionID { get; set; }
        public string LastUpdateBy { get; set; }
        public Nullable<System.DateTime> LastUpdateDT { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<bool> IsAvailiable { get; set; }
        public string CounterType { get; set; }
        public Nullable<double> AmountDiscount { get; set; }
        public Nullable<double> AmountPaid { get; set; }
        public Nullable<double> AmountTotal { get; set; }
        public Nullable<double> ServiceCharges { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumberPayment { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public string ReferenceNo { get; set; }
        public string Location { get; set; }
        public string CustomerName { get; set; }
        public Nullable<System.DateTime> CheckoutDate { get; set; }
        public Nullable<double> GrandTotal { get; set; }
        public Nullable<int> PaymentMode { get; set; }
        public Nullable<double> Tax { get; set; }
    }
}
