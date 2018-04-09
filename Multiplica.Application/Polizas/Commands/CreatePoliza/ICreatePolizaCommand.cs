using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplica.Application.Polizas.Commands.CreatePoliza
{
    public interface ICreatePolizaCommand
    {
        CreatePolizaModel Execute(CreatePolizaParamModel poliza);
    }
}
