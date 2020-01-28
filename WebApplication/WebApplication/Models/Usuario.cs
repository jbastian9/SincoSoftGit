using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int PaisId { get; set; }
        public Pais Pais { get; set; }
        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }

    }
}