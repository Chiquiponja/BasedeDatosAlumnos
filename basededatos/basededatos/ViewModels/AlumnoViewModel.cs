﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basededatos.ViewModels
{
    public class AlumnoViewModel
    {
        public int Id { get; set; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Email { set; get; }
        public int Nota { get; set; }
    }
}

