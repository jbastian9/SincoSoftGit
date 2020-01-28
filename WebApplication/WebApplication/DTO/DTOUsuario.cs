using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.DTO
{
    public class DTOUsuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int CiudadId { get; set; }
        public string PaisNombre { get; set; }
        public string CiudadNombre { get; set; }

    }
}