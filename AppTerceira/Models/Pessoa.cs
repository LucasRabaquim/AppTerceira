using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppTerceira.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }

        public Pessoa SelectPessoa()
        {
            Pessoa ObjPessoa = new Pessoa();
            return ObjPessoa;
        }
    }
}