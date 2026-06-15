using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_API_3.Models
{
    public class Data
    {
        private int dia;

        public int Dia
        {
            get => dia;
            set
            {
                if (value >= 1 && value <= 31)
                    dia = value;
            }
        }

        public int Mes { get; set; }
        public int Ano { get; set; }
    }
}