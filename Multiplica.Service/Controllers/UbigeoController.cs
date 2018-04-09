using Multiplica.Application.Ubigeos.Queries.GetUbigeoListById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Multiplica.Service.Controllers
{
    public class UbigeoController : ApiController
    {
        private readonly IGetUbigeoListByIdQuery _getUbigeoListByIdQuery;

        public UbigeoController(IGetUbigeoListByIdQuery getUbigeoListByIdQuery)
        {
            _getUbigeoListByIdQuery = getUbigeoListByIdQuery;
        }

        [HttpGet]
        public HttpResponseMessage GetUbigeosById(int? id)
        {
            var ubigeos = _getUbigeoListByIdQuery.Execute(id);
            return Request.CreateResponse(HttpStatusCode.OK, ubigeos);
        }
    }
}
