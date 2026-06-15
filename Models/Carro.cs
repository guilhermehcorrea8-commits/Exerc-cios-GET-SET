using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_API_3.Models
{
    public class Carro
    {
        
    }
}public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

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
