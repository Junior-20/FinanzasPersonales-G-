//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanzasPersonales_G_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class INGRESO
    {
        public int ID { get; set; }
        [Required]
        public int Tipo_Ingreso { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 5)]
        public string Descripcion { get; set; }
        [Required]
        public string Tipo_Obtencion { get; set; }
        public bool Estado { get; set; }
    
        public virtual INGRESO_TIPO INGRESO_TIPO { get; set; }
    }
}
