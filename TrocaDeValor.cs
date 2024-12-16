using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class TrocaDeValor
    {
        public static void Main(int[] args)
        {
            int numero1 = 10;
            int numero2 = 20;
            int numero3 = 0;
            numero3 = numero1;
            numero1 = numero2;
            numero2 = numero3;
            Console.WriteLine("O valor da variável número 1 é: " + numero1);
            Console.WriteLine("O valor da variável número 2 é: " + numero2);
            Console.WriteLine("O valor da variável número 3 é: " + numero3);
        }
    }
}

