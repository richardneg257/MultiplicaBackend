using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplica.Application.Polizas.Queries.GetPolizaById
{
    public interface IGetPolizaByIdQuery
    {
        GetPolizaByIdModel Execute(int id);
    }
}
