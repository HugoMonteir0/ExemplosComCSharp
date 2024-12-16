using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class ExemploIfElse
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());
            if (idade < 18)
            {
                Console.WriteLine("Não pode iniciar o processo de habilitação");
            }
            else
            {
                Console.WriteLine("Pode iniciar o processo de habilitação");
            }
        }
    }
}
