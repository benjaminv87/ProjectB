//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login
{
    using System;
    using System.Collections.Generic;
    
    public partial class BestellingProduct
    {
        public int BestellingProductID { get; set; }
        public Nullable<int> BestellingID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> Aantal { get; set; }
    
        public virtual Bestelling Bestelling { get; set; }
        public virtual Product Product { get; set; }
    }
}
