using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class ExemploFor2
    {
        public static void Main(string[] args)
        {
            for (int item = 0; item <=2; item++)
            {
                Console.WriteLine("Item: " + item);

                for (int subItem = 0; subItem <=3; subItem++)
                {
                    Console.WriteLine("SubItem: " + subItem);
                }
            }
        }
    }
}
