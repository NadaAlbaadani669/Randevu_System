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
    
    public partial class Hasta_durumu
    {
        public int id { get; set; }
        public Nullable<int> Hasta_id { get; set; }
        public Nullable<int> Doktor_id { get; set; }
        public Nullable<int> Randevu_no { get; set; }
        public string Tashis { get; set; }
        public string Resete { get; set; }
    
        public virtual Hasta Hasta { get; set; }
    }
}
