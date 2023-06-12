//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class TObjetivo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TObjetivo()
        {
            this.TActividads = new HashSet<TActividad>();
        }
    
        public int IdObjetivo { get; set; }
        public string NombreObjetivo { get; set; }
        public string DescripcionObjetivo { get; set; }
        public Nullable<int> IdTipoObjetivo { get; set; }
        public string UsuarioInserto { get; set; }
        public Nullable<System.DateTime> FechaInserto { get; set; }
        public string UsuarioModifico { get; set; }
        public Nullable<System.DateTime> FechaModifico { get; set; }
        public Nullable<bool> Eliminado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TActividad> TActividads { get; set; }
        public virtual TTipoObjetivo TTipoObjetivo { get; set; }
    }
}