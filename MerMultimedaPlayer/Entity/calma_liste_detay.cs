//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MerMultimedaPlayer.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class calma_liste_detay
    {
        public int id { get; set; }
        public Nullable<int> calma_listesi_id { get; set; }
        public string parca_url { get; set; }
        public Nullable<int> sil_id { get; set; }
        public Nullable<System.DateTime> olusturma_tarihi { get; set; }
        public Nullable<System.DateTime> guncelleme_tarihi { get; set; }
    
        public virtual calma_listesi_kart calma_listesi_kart { get; set; }
    }
}
