﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace actividadWebApi.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
    }
}