//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VeriTabani
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hasta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hasta()
        {
            this.Hasta_durumu = new HashSet<Hasta_durumu>();
            this.Randevus = new HashSet<Randevu>();
        }
    
        public int Hasta_id { get; set; }
        public string Hasta_TC { get; set; }
        public string Hasta_ad { get; set; }
        public string Hasta_telefon { get; set; }
        public string Hasta_email { get; set; }
        public Nullable<System.DateTime> Hasta_DOB { get; set; }
        public string Hasta_cinsiyet { get; set; }
        public string Hasta_sifresi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hasta_durumu> Hasta_durumu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Randevu> Randevus { get; set; }
    }
}
