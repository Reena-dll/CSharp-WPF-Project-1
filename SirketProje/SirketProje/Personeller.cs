//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SirketProje
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personeller
    {
        public int ID { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public Nullable<int> Departman { get; set; }
        public Nullable<int> Sube { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string PersonelSifre { get; set; }
        public string PersonelFoto { get; set; }
        public string Maas { get; set; }
        public string Hakkinda { get; set; }
        public Nullable<bool> Durum { get; set; }
    
        public virtual Departman Departman1 { get; set; }
        public virtual Subeler Subeler { get; set; }
    }
}
