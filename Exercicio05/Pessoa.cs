using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio05
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade;

    public Pessoa(string N, int I)
        {
            Nome = N;
            Idade = I;
            
        }
        public void ExibirDados()
        {
            Console.WriteLine($@"Nome: {Nome}
Idade: {Idade}");
        }

    public void DefinirIdade(int valor)
        {
            if (valor > 0)
            {
                Idade = valor;
            } else
            {
                Console.WriteLine($"Idade inválida!! Só pode ser modificada se a idade for maior que 0!");
                
            }
        }
    }
}