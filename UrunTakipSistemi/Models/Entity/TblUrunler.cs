//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UrunTakipSistemi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblUrunler
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Marka { get; set; }
        public Nullable<short> Stok { get; set; }
        public Nullable<decimal> AlisFiyat { get; set; }
        public Nullable<decimal> SatisFiyat { get; set; }
        public Nullable<int> Kategori { get; set; }
    
        public virtual TblKategori TblKategori { get; set; }
        public virtual TblSatislar TblSatislar { get; set; }
    }
}
