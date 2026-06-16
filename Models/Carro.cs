using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_API_3.Models
{

    public class Carro
    {
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;

        private int ano;

        public int Ano
        {
            get => ano;
            set
            {
                if (value >= 1886)
                    ano = value;
            }
        }
    }
}