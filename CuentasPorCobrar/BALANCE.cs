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

    public partial class BALANCE
    {
        public int ID_cliente { get; set; }
        public System.DateTime Fecha_corte { get; set; }
        public decimal Monto { get; set; }
        public int ID_balance { get; set; }

        [Browsable(false)]
        public virtual CLIENTE CLIENTE { get; set; }
    }
}
