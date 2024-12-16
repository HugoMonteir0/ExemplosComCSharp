using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class ExemploConversao
    {
        public static void Main(string[] args)
        {
            int myInt = 918;
            double myDouble = myInt;

            Console.WriteLine(myInt.GetType());
            Console.WriteLine(myDouble.GetType());
        }
    }
}
