﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbFirstFlightProject.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbİstanbulAkademiFlightEntities2 : DbContext
    {
        public DbİstanbulAkademiFlightEntities2()
            : base("name=DbİstanbulAkademiFlightEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblCity> TblCity { get; set; }
        public virtual DbSet<TblFlight> TblFlight { get; set; }
        public virtual DbSet<TblPassenger> TblPassenger { get; set; }
        public virtual DbSet<TblDepartment> TblDepartment { get; set; }
        public virtual DbSet<TblEmployee> TblEmployee { get; set; }
    }
}