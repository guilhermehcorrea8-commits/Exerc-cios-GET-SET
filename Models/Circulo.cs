using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_API_3.Models
{
    public class Circulo
    {
        public double Raio { get; set; }

        public double Diametro => Raio * 2;

        public double Area => Math.PI * Math.Pow(Raio, 2);
    }
}