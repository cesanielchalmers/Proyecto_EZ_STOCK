﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Correo
    {
        public int IdCorreo { get; set; }
        public string ExtensionDominio { get; set; }
        public string Dominio { get; set; }
        public string UsuarioCorreo { get; set; }
    }
}
