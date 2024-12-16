using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class ExemploMetodo05
    {
        public static int Soma(int numero)
        {
            return numero + 10;
        }




        public static void Main(string[] args)
        {
            Console.WriteLine("A soma dos valoores é: " + Soma(3));
        }
    }
}
