//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Multiplica.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Poliza
    {
        public int Id { get; set; }
        public int DepartamentoId { get; set; }
        public int ProvinciaId { get; set; }
        public int DistritoId { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
    
        public virtual Ubigeo Departamento { get; set; }
        public virtual Ubigeo Distrito { get; set; }
        public virtual Ubigeo Provincia { get; set; }
    }
}
