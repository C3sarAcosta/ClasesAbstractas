using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadro1 = new Cuadrado(3);
            Console.WriteLine(cuadro1.Area());
            Console.ReadKey();
        }
    }
}
