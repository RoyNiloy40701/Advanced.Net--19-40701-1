//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public int orderid { get; set; }
        public string customername { get; set; }
        public string orderaddress { get; set; }
        public Nullable<System.DateTime> orderdate { get; set; }
        public int quantity { get; set; }
        public int ordercost { get; set; }
        public string productname { get; set; }
    }
}
