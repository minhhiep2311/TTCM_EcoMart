//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TTCM_EcoMart.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBill_details
    {
        public string Bill_details_ID { get; set; }
        public string Bill_ID { get; set; }
        public long Quantity { get; set; }
        public string product_ID { get; set; }
    
        public virtual tblBill tblBill { get; set; }
        public virtual tblProduct tblProduct { get; set; }
    }
}
