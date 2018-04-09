using Multiplica.Application.Polizas.Commands.CreatePoliza;
using Multiplica.Application.Polizas.Queries.GetPolizaById;
using Multiplica.Application.Ubigeos.Queries.GetUbigeoListById;
using Multiplica.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplica.Application.Infraestructure
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Ubigeo, GetUbigeoListByIdModel>().ReverseMap();
            CreateMap<Poliza, CreatePolizaParamModel>().ReverseMap();
            CreateMap<Poliza, CreatePolizaModel>().ReverseMap();
            CreateMap<Poliza, GetPolizaByIdModel>().ReverseMap();
        }
    }
}
