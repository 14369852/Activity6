//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Activity6_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public int SaleID { get; set; }
        public Nullable<int> CusID { get; set; }
        public Nullable<int> empID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> Sale_Date { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
