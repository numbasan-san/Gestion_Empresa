﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpresa.Clases
{
    class clsRegion
    {
        public int codigo { get; set; }
        public string continente { get; set; }
        public string pais { get; set; }

        public clsRegion(int codigo, string continente, string pais)
        {
            this.codigo = codigo;
            this.continente = continente;
            this.pais = pais;            
        }

        public clsRegion() { }
        
    }
}
