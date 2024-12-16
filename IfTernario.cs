using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class IfTernario
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt16(Console.ReadLine());
            string mensgaem = (numero < 10)? "Esse número é maior que 10" : "Esse número é menor que 10";
        }
    }
}
