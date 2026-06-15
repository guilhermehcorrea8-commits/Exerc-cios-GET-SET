using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_API_3.Models
{
    public class Empresa
    {
        public string Nome { get; set; }

        private List<Funcionario> funcionarios = new();

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }

        public double FolhaPagamento
        {
            get
            {
                return funcionarios.Sum(f => f.Salario);
            }
        }
    }
}