using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade;

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