﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace onBoardingApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbOnboardingEntities : DbContext
    {
        public dbOnboardingEntities()
            : base("name=dbOnboardingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TActividad> TActividads { get; set; }
        public virtual DbSet<TArea> TAreas { get; set; }
        public virtual DbSet<TAsignacion> TAsignacions { get; set; }
        public virtual DbSet<TColaborador> TColaboradors { get; set; }
        public virtual DbSet<TDetalleEvaluacion> TDetalleEvaluacions { get; set; }
        public virtual DbSet<TObjetivo> TObjetivoes { get; set; }
        public virtual DbSet<TPlanOnBoarding> TPlanOnBoardings { get; set; }
        public virtual DbSet<TPuesto> TPuestoes { get; set; }
        public virtual DbSet<TRecurso> TRecursoes { get; set; }
        public virtual DbSet<TTipoObjetivo> TTipoObjetivoes { get; set; }
        public virtual DbSet<VCuadranteEmpleado> VCuadranteEmpleadoes { get; set; }
        public virtual DbSet<VEscalasEmpleadoPlanOB> VEscalasEmpleadoPlanOBs { get; set; }
        public virtual DbSet<VResultadoColaboradorSkill> VResultadoColaboradorSkills { get; set; }
        public virtual DbSet<VResultadoColaboradorWill> VResultadoColaboradorWills { get; set; }
    }
}
