using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplica.Application.Polizas.Commands.CreatePoliza
{
    public class CreatePolizaParamModel
    {
        public int DepartamentoId { get; set; }
        public int ProvinciaId { get; set; }
        public int DistritoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
