using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_API_3.Models
{
    public class Voo
    {
        public string NumeroVoo { get; set; }

        private string origem;
        private string destino;

        public string Origem
        {
            get => origem;
            set
            {
                if (value != destino)
                    origem = value;
            }
        }

        public string Destino
        {
            get => destino;
            set
            {
                if (value != origem)
                    destino = value;
            }
        }
    }
}