//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XML_İle_Döviz_Kuru_Cekme.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tablocurrency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tablocurrency()
        {
            this.Tablocurrencyvalues = new HashSet<Tablocurrencyvalues>();
            this.Tabloislem = new HashSet<Tabloislem>();
        }
    
        public int ID { get; set; }
        public string kurisim { get; set; }
        public string kursembol { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tablocurrencyvalues> Tablocurrencyvalues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tabloislem> Tabloislem { get; set; }
    }
}
