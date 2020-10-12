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
    
    public partial class Leverancier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Leverancier()
        {
            this.Bestelling = new HashSet<Bestelling>();
            this.Product = new HashSet<Product>();
        }
    
        public int LeverancierID { get; set; }
        public string Contactpersoon { get; set; }
        public Nullable<int> Telefoonnummer { get; set; }
        public string Emailadres { get; set; }
        public string Straatnaam { get; set; }
        public Nullable<int> Huisnummer { get; set; }
        public string Bus { get; set; }
        public Nullable<int> PostcodeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bestelling> Bestelling { get; set; }
        public virtual Gemeente Gemeente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
    }
}