using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppTerceira.Models
{
    public class Fisica : Pessoa
    {
        public Int64 CPF { get; set; }
        public int RG { get; set; }
        public char Dig_RG {get; set; }
    }
}