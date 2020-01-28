using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.DAL;

namespace WebApplication.Controllers
{
    public class UbicacionController : ApiController
    {
        private Context db = new Context();

        [HttpGet]
        public IHttpActionResult GetPaises()
        {
            return Ok(db.Pais);
        }

        [HttpGet]
        public IHttpActionResult GetPaisesPorNombre(string texto)
        {
            return Ok(db.Pais.Where(x => x.Nombre.Contains(texto)).Select(x=> x.Nombre.ToUpper()));
        }
        [HttpGet]
        public IHttpActionResult GetCiudadesDeUnPais(int IdPais)
        {
            return Ok(db.Ciudad.Where(x=>x.PaisId.Equals(IdPais)).Select(x=>x.Nombre.ToUpper()));
        }

    }
}
