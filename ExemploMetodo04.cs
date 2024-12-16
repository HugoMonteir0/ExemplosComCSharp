using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class ExemploMetodo04
    {
        static void PaisOrigem(string pais = "Brasil")
        {
            Console.WriteLine("Meu país de origem é: " + pais);
        } 

        public static void Main(string[] args)
        {
            PaisOrigem("Argentina");
            PaisOrigem("Portugal");
            PaisOrigem();
            PaisOrigem("Holanda");
        }
    }
}
