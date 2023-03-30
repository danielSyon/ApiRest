using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiRest.DAO;

namespace ApiRest.Controllers
{
    [RoutePrefix("data/pitotos")]
    public class PilotosF1Controller : ApiController
    {
        /// <summary>
        /// Este método permite obtener los datos de un piloto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HttpResponseMessage Get(int id)
        {
            //Para obtener el dato de base de datos hay que llamar al DAO correspondiente, en este caso el de pilotos
            var piloto = new PilotoDAO().ObtenerPorId(id);

            return Request.CreateResponse(HttpStatusCode.OK, piloto);
        }
    }
}
