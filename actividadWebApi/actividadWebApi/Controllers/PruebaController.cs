using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace actividadWebApi.Controllers
{
    public class PruebaController : ApiController
    {
        //http://localhost:57487/api/Prueba/ObtenerValor
        [HttpGet]
        public IHttpActionResult ObtenerValor(){
            return Ok("Hola Mundo");
        }
    }
}
