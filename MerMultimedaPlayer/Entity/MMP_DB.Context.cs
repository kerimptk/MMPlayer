﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MMP_DBEntities : DbContext
    {
        public MMP_DBEntities()
            : base("name=MMP_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<calma_liste_detay> calma_liste_detay { get; set; }
        public virtual DbSet<calma_listesi_kart> calma_listesi_kart { get; set; }
    }
}
