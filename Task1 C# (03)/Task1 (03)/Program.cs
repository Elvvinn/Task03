using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1__03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 58;
            int b = 65;
            int c = a + b ;

            if ( a > 50 &&  b >50)
            {
                Console.WriteLine("Cavabimiz : " +( c));
            }
            else
            {
                Console.WriteLine("Bu ededler sherti odemir");
            }
        }
    }
}
