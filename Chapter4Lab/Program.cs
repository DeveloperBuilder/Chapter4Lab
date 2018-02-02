using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a console application and declare age and name variables of three peoples. 
            // Performthe following operations on them:
            // 1. Using a ternary operator, print who is older between two people.
            // 2. Using comparison and logical operators, evaluate and print who is the oldest and the youngest in the group of three.
            var henkAge = 14;
            var janAge = 37;
            var keesAge = 66;
            if ((henkAge > janAge) && (henkAge > keesAge))
            {
                Console.WriteLine("The oldest of the three is henkAge");
            }
            else if ((janAge > henkAge) && (janAge > keesAge))
            {
                Console.WriteLine("The oldest of the three is janAge");
            }
            else if ((keesAge > henkAge) && (keesAge > janAge))
            {
                Console.WriteLine("The oldest of the three is keesAge");
            }
            Youngest();
            Console.ReadLine();
        }
        static void Youngest()
        {
            var henkAge = 14;
            var janAge = 37;
            var keesAge = 66;
            if ((henkAge < janAge) && (henkAge < keesAge))
            {
                Console.WriteLine("The youngest of the three is henkAge");
            }
            else if ((janAge < henkAge) && (janAge < keesAge))
            {
                Console.WriteLine("The youngest of the three is janAge");
            }
            else if ((keesAge < henkAge) && (keesAge < janAge))
            {
                Console.WriteLine("The youngest of the three is keesAge");
            }
            Console.ReadLine();
        }
    }
}
