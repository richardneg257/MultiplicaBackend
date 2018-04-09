using Multiplica.Application.Polizas.Commands.CreatePoliza;
using Multiplica.Application.Polizas.Queries.GetPolizaById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Multiplica.Service.Controllers
{
    public class PolizaController : ApiController
    {
        private readonly IGetPolizaByIdQuery _getPolizaByIdQuery;
        private readonly ICreatePolizaCommand _createPolizaCommand;

        public PolizaController(IGetPolizaByIdQuery getPolizaByIdQuery, ICreatePolizaCommand createPolizaCommand)
        {
            _getPolizaByIdQuery = getPolizaByIdQuery;
            _createPolizaCommand = createPolizaCommand;
        }

        [HttpGet]
        public HttpResponseMessage GetPolizaById(int id)
        {
            var poliza = _getPolizaByIdQuery.Execute(id);
            return Request.CreateResponse(HttpStatusCode.OK, poliza);
        }

        // POST: api/Poliza
        [ResponseType(typeof(CreatePolizaModel))]
        public IHttpActionResult PostProduct(CreatePolizaParamModel poliza)
        {
            var polizaResult = _createPolizaCommand.Execute(poliza);

            return Created(Request.RequestUri, polizaResult);
        }
    }
}
