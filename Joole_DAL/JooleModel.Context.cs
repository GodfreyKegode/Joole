﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Joole_DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Joole_TeamEntities : DbContext
    {
        public Joole_TeamEntities()
            : base("name=Joole_TeamEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCategory> tblCategories { get; set; }
        public virtual DbSet<tblManufacturer> tblManufacturers { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblSubCategory> tblSubCategories { get; set; }
        public virtual DbSet<tblType> tblTypes { get; set; }
        public virtual DbSet<tblTypeOptValue> tblTypeOptValues { get; set; }
        public virtual DbSet<tblTypeSpecValue> tblTypeSpecValues { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
    }
}
