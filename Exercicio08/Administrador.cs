using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio08
{
     public class Administrador : IAutenticavel
    {
        public string Nome = "";
        public string Senha = "";
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}