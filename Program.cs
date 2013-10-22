using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            life life = new life();
            life.newBorn();

            characteristics characteristics = new characteristics();
            characteristics.addReligion();
            Console.Clear();
            characteristics.newBeing();

            Console.ReadKey();


        }
    }
}
