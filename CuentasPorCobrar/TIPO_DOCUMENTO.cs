//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class TIPO_DOCUMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_DOCUMENTO()
        {
            this.TRANSACCION = new HashSet<TRANSACCION>();
        }

        [DisplayName("ID documento")]
        public int ID_documento { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        [Browsable(false)]
        public virtual ICollection<TRANSACCION> TRANSACCION { get; set; }
    }
}
