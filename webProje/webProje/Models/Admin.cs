//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webProje.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Admin()
        {
            this.Haber = new HashSet<Haber>();
        }
    
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KulAdi { get; set; }
        public string Sifre { get; set; }
        public string Yetki { get; set; }
        public Nullable<System.DateTime> UyelikTarihi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Haber> Haber { get; set; }
    }
}