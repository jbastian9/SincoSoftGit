using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Ciudad
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        //llave foranea
        public int PaisId { get; set; }
        //navegación
        public Pais Pais { get; set; }
    }
}