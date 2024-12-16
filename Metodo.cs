using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class Metodo
    {
        static int Soma(int x, int y)
        {
            return x + y;
        }

      static double Soma(double x, double y)
        {
            return x + y;
        }

        static string Soma(string x, string y)
        {
            return x + y;
        }

        public static void Main(string[] args)
        {
            int numero01 = Soma(1, 6);
            double numero02 = Soma(2.5, 3.5);
            string meuNome = Soma("Hugo", " Monteiro");

            Console.WriteLine("Int: " + numero01);
            Console.WriteLine("Double: " + numero02);
            Console.WriteLine("Nome: " + meuNome);
            Console.WriteLine("Nome: " + Soma("Opa", ", Tudo bem?"));
        }
    }
}
