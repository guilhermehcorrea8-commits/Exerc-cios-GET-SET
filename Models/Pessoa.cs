using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_API_3.Models
{
    public class Pessoa
    {
        private int idade;

        public int GetIdade()
        {
            return idade;
        }

        public bool SetIdade(int idade)
        {
            if (idade >= 0)
            {
                this.idade = idade;
                return idade >= 18;
            }

            return false;
        }

        public bool MaiorDeIdade()
        {
            return idade >= 18;
        }
    }
}