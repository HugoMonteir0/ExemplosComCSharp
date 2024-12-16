using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos.POO
{
    internal class ExibirComputador
    {
        public static void Main(string[] args)
        {
            Computador meuPc = new Computador();
            Console.WriteLine("O id do computador é: " + meuPc);
            Console.WriteLine("A marca do computador é: " + meuPc);
            Console.WriteLine("A placa mãe do computador é: " + meuPc);
            Console.WriteLine("A memória RAM do computador é: " + meuPc);
            Console.WriteLine("A memória interna do computadoir é: " + meuPc);
            Console.WriteLine("A placa de vídeo do computador é: " + meuPc);
            Console.WriteLine("A fonte do computador é: " + meuPc);
        }
    }
}
