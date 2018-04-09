using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplica.Application.Polizas.Queries.GetPolizaById
{
    public class GetPolizaByIdModel
    {
        public int Id { get; set; }
        public int DepartamentoId { get; set; }
        public string DepartamentoDescripcion { get; set; }
        public int ProvinciaId { get; set; }
        public string ProvinciaDescripcion { get; set; }
        public int DistritoId { get; set; }
        public string DistritoDescripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
