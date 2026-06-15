using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_API_3.Models
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }

    public class Agenda
    {
        public Contato Contato { get; set; }
    }
}