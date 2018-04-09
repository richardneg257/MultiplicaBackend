using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multiplica.ServiceModels
{
    public class Ubigeo
    {
        public int Id { get; set; }
        public string CodigoDepartamento { get; set; }
        public string CodigoProvincia { get; set; }
        public string CodigoDistrito { get; set; }
        public string Nombre { get; set; }
    }
}