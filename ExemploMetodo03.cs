using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class ExemploMetodo03
    { 
    
        public static void Dados(string nome, string sobrenome, int idade)
        {
            Console.WriteLine("Meus dados sao: Nome completo: " + nome + "" + sobrenome + ". " + "Minha idade é: " + idade);
        }

        public static void Main(string[] args)
        {
            Dados("Hugo ", "Monteiro Gomes da Silva", 21);
        }
    
    
    }

    }
    