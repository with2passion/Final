﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WFormDBEntities : DbContext
    {
        public WFormDBEntities()
            : base("name=WFormDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DersTab> DersTab { get; set; }
        public virtual DbSet<OgrenciDersTab> OgrenciDersTab { get; set; }
        public virtual DbSet<OgrenciTab> OgrenciTab { get; set; }
        public virtual DbSet<OkulYonetimTab> OkulYonetimTab { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}