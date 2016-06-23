//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class FARMACIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FARMACIA()
        {
            this.MEDICAMENTO_FARMACIA = new HashSet<MEDICAMENTO_FARMACIA>();
            this.PROMOCIONs = new HashSet<PROMOCION>();
        }
    
        public int ID_FAR { get; set; }
        public int ID_DIS { get; set; }
        public string NOM_FAR { get; set; }
        public string DIR_FAR { get; set; }
        public Nullable<float> CORX_FAR { get; set; }
        public Nullable<float> CORDY_FAR { get; set; }
        public Nullable<int> HORARIO_FAR { get; set; }
        public System.Data.Entity.Spatial.DbGeography GEO_LUGAR { get; set; }
    
        public virtual DISTRITO DISTRITO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEDICAMENTO_FARMACIA> MEDICAMENTO_FARMACIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROMOCION> PROMOCIONs { get; set; }
    }
}
