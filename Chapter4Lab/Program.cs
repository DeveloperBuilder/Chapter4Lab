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
            // Perform the following operations on them:
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
            Ternary();
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
        }
        static void Ternary()
        {
            var henkAge = 14;
            var janAge = 37;
            var keesAge = 66;
            var result = henkAge > janAge ? "The older of the two is henkAge" : "The older of the two is janAge";
            var result1 = henkAge > keesAge ? "The older of the two is henkAge" : "The older of the two is keesAge";
            var result2 = janAge > henkAge ? "The older of the two is janAge" : "The older of the two is henkAge";
            var result3 = janAge > keesAge ? "The older of the two is janAge" : "The older of the two is keesAge";
            var result4 = keesAge > henkAge ? "The older of the two is keesAge" : "The older of the two is henkAge";
            var result5 = keesAge > janAge ? "The older of the two is keesAge" : "The older of the two is janAge";
            {
                Console.WriteLine(result + "\n" + result1 + "\n" + result2 + "\n" + result3 + "\n" + result4 + "\n" + result5);
            }
        }
    }
}
