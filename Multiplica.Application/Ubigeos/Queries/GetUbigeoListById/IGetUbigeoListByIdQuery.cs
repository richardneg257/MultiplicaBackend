using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplica.Application.Ubigeos.Queries.GetUbigeoListById
{
    public interface IGetUbigeoListByIdQuery
    {
        List<GetUbigeoListByIdModel> Execute(int? id);
    }
}
