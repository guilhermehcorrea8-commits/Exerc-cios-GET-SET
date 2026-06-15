using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_API_3.Models
{
    public class Aluno
    {
        private string nome;
        private int matricula;
        private double nota;

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public int GetMatricula()
        {
            return matricula;
        }

        public void SetMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public double GetNota()
        {
            return nota;
        }

        public void SetNota(double nota)
        {
            if (nota >= 0 && nota <= 10)
            {
                this.nota = nota;
            }
            else
            {
                Console.WriteLine("Nota inválida.");
            }
        }
    }
}