using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class ExibirCarro
    {
        public static void Main(string[] args)
        {
            Carro carroHugo = new Carro();

            Console.WriteLine("O nome do carro é: " + carroHugo);
            Console.WriteLine("A coor do carro é: " + carroHugo);
            Console.WriteLine("O ano de fabricação do carro é: " + carroHugo);
        }
    }
}
