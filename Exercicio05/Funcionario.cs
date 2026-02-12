using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio05
{
    public class Funcionario : Pessoa
    {
        public float Salario;

        public Funcionario(string N, int I) : base(N, I)
        {
        }
    }
}