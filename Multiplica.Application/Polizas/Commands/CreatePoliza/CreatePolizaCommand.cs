using AutoMapper;
using Multiplica.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplica.Application.Polizas.Commands.CreatePoliza
{
    public class CreatePolizaCommand : ICreatePolizaCommand
    {
        private Entities _database;

        public CreatePolizaCommand()
        {

        }

        public CreatePolizaModel Execute(CreatePolizaParamModel poliza)
        {
            using (_database = new Entities())
            {
                var product = Mapper.Map<Poliza>(poliza);
                _database.Polizas.Add(product);
                _database.SaveChanges();

                var productResult = Mapper.Map<CreatePolizaModel>(product);

                return productResult;
            }
        }
    }
}
