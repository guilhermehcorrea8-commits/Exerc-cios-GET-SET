using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_API_3.Models
{
    public class Triangulo
    {
        private double a, b, c;

        public bool DefinirLados(double ladoA, double ladoB, double ladoC)
        {
            if (ladoA + ladoB > ladoC &&
                ladoA + ladoC > ladoB &&
                ladoB + ladoC > ladoA)
            {
                a = ladoA;
                b = ladoB;
                c = ladoC;
                return true;
            }

            return false;
        }
    }
}