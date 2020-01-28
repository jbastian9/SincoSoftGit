using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.DAL;
using WebApplication.DTO;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class UsuarioController : ApiController
    {
        private Context db = new Context();

        [HttpGet]
        public IHttpActionResult GetUsuarios()
        {
            return Ok(db.Usuario);
        }

        [HttpGet]
        public IHttpActionResult GetUsuarioPorID(int ID)
        {
            return Ok(db.Usuario.Where(x => x.ID.Equals(ID)));
        }
        [HttpPost]
        public IHttpActionResult CrearUsuario (Usuario u){
            u.ID = 1;
            u.Nombre = "Daniela";
            u.Apellido = "Mesa";
            u.Correo = "Danyme@Hotmail.com";
            u.Telefono = "255442454242";
            u.CiudadId = 2;
            db.Usuario.Add(u);
            db.SaveChanges();
            return Ok(db.Usuario);
        }
        
        [HttpGet]
        public IHttpActionResult GetUsuarioPorIDDos(int? id)
        {

            var query = (from U in db.Usuario
                         join C in db.Ciudad on U.CiudadId equals C.ID
                         join P in db.Pais on C.PaisId equals P.ID
                         select new DTOUsuario { 
                             ID = U.ID,
                             Nombre = U.Nombre,
                             Apellido = U.Apellido,
                             Correo = U.Correo,
                             Telefono = U.Telefono,
                             CiudadNombre= C.Nombre,
                             PaisNombre = P.Nombre
                             
                         });

            return Ok(query); 

            //return Ok(db.Usuario.Include("Ciudad"));
        }

    }
}
