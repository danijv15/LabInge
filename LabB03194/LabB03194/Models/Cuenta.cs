//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabB03194.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cuenta
    {
        public string tipo { get; set; }
        public int numero { get; set; }
        public string cedulaCliente { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}