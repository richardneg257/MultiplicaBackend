using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multiplica.Repository;

namespace Multiplica.Application.Ubigeos.Queries.GetUbigeoListById
{
    public class GetUbigeoListByIdQuery : IGetUbigeoListByIdQuery
    {
        private Entities _database;

        public GetUbigeoListByIdQuery()
        {

        }

        public List<GetUbigeoListByIdModel> Execute(int? id)
        {
            using (_database = new Entities())
            {
                var list = _database.Ubigeos
                    .Where(x => id.HasValue ? (x.ParentId == id) : x.ParentId == null)
                    .ToList();
                var listaUbigeosModel = Mapper.Map<List<GetUbigeoListByIdModel>>(list);
                return listaUbigeosModel;
            }
        }
    }
}
