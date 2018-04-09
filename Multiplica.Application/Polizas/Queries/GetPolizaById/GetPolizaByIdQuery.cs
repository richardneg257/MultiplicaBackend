using AutoMapper;
using Multiplica.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplica.Application.Polizas.Queries.GetPolizaById
{
    public class GetPolizaByIdQuery : IGetPolizaByIdQuery
    {
        private Entities _database;

        public GetPolizaByIdQuery()
        {

        }

        public GetPolizaByIdModel Execute(int id)
        {
            using (_database = new Entities())
            {
                var polizaBD = _database.Polizas.FirstOrDefault(x => x.Id == id);
                var polizaModel = Mapper.Map<GetPolizaByIdModel>(polizaBD);
                polizaModel.DepartamentoDescripcion = polizaBD.Departamento.Descripcion;
                polizaModel.ProvinciaDescripcion = polizaBD.Provincia.Descripcion;
                polizaModel.DistritoDescripcion = polizaBD.Distrito.Descripcion;
                return polizaModel;
            }
        }
    }
}
