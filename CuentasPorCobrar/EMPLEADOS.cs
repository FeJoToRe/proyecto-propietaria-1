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
    
    public partial class EMPLEADOS
    {
        public int ID_empleado { get; set; }
        public string Nombre { get; set; }
        public int ID_departamento { get; set; }
        public string Direccion { get; set; }
        public decimal Salario { get; set; }
    
        public virtual DEPARTAMENTOS DEPARTAMENTOS { get; set; }
    }
}