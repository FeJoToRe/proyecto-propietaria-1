﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CuentasPorCobrar
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Cuentas_por_cobrarEntities : DbContext
    {
        public Cuentas_por_cobrarEntities()
            : base("name=Cuentas_por_cobrarEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BALANCE> BALANCE { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<ROLES> ROLES { get; set; }
        public virtual DbSet<TIPO_DOCUMENTO> TIPO_DOCUMENTO { get; set; }
        public virtual DbSet<TRANSACCION> TRANSACCION { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
    }
}
