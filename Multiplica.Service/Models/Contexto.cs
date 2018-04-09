using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Multiplica.ServiceModels
{
    public class Contexto : DbContext
    {
        public Contexto() : base("PolizaDB")
        {

        }

        public DbSet<Ubigeo> Ubigeos { get; set; }
    }
}