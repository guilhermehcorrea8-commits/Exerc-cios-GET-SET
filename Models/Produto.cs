using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_API_3.Models
{
    public class Produto
    {
        private string nome;
        private double preco;
        private int quantidade;

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public double Preco
        {
            get => preco;
            set
            {
                if (value >= 0)
                    preco = value;
            }
        }

        public int Quantidade
        {
            get => quantidade;
            set => quantidade = value;
        }
    }
}