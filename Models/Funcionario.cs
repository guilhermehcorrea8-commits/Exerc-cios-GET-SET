using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_API_3.Models
{
    public class Funcionario
    {
        public string Nome { get; set; }

        private double salario;

        public double Salario
        {
            get => salario;
            set
            {
                if (value >= salario)
                    salario = value;
            }
        }
    }
}

