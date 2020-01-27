using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace actividadWebApi.Models
{
    public class PaisNMCiudades
    {
        public int ID { get; set; }
        public int PaisId { get; set; }
        public Pais Pais { get; set; }
        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }
    }
}