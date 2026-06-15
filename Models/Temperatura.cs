using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_API_3.Models
{
    public class Temperatura
    {
        public double Celsius { get; set; }

        public double Fahrenheit()
        {
            return (Celsius * 9 / 5) + 32;
        }
    }
}