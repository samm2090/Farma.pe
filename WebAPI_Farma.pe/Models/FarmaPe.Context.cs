﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI_Farma.pe.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD_FARMACIAEntities : DbContext
    {
        public BD_FARMACIAEntities()
            : base("name=BD_FARMACIAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADVERTENCIA> ADVERTENCIA { get; set; }
        public virtual DbSet<DEPARTAMENTO> DEPARTAMENTO { get; set; }
        public virtual DbSet<DISTRITO> DISTRITO { get; set; }
        public virtual DbSet<FARMACIA> FARMACIA { get; set; }
        public virtual DbSet<FAVORITO> FAVORITO { get; set; }
        public virtual DbSet<FORMA_USO> FORMA_USO { get; set; }
        public virtual DbSet<LABORATORIO> LABORATORIO { get; set; }
        public virtual DbSet<LABORATORIO_MEDICAMENTO> LABORATORIO_MEDICAMENTO { get; set; }
        public virtual DbSet<MEDICAMENTO> MEDICAMENTO { get; set; }
        public virtual DbSet<MEDICAMENTO_FARMACIA> MEDICAMENTO_FARMACIA { get; set; }
        public virtual DbSet<MEDICAMENTO_SINTOMA> MEDICAMENTO_SINTOMA { get; set; }
        public virtual DbSet<PERSONA> PERSONA { get; set; }
        public virtual DbSet<PROMOCION> PROMOCION { get; set; }
        public virtual DbSet<PROVINCIA> PROVINCIA { get; set; }
        public virtual DbSet<SINTOMA> SINTOMA { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
    }
}