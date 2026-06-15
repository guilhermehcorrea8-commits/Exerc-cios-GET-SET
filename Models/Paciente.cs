using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_API_3.Models
{
    public class Paciente
    {
        public string Nome { get; set; }

        private double peso;

        public double Peso
        {
            get => peso;
            set
            {
                if (value > 0)
                    peso = value;
            }
        }
    }
}