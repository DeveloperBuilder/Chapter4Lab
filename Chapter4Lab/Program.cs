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
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            person1.Age = 14;
            person1.Name = "Henk";

            person2.Age = 37;
            person2.Name = "Jan";

            person3.Age = 66;
            person3.Name = "Kees";

            if (Person.Older(person2.Age, person1.Age))
            {
                Console.WriteLine(person2.Name + " is ouder dan " + person1.Name);
            }
            else
            {
                Console.WriteLine(person2.Name + " is jonger dan of even oud als " + person1.Name);
            }

            if (Person.Older(person2.Age, person3.Age))
            {
                Console.WriteLine(person2.Name + " is ouder dan " + person3.Name);
            }
            else
            {
                Console.WriteLine(person2.Name + " is jonger dan of even oud als " + person3.Name);
            }
            Console.ReadLine();
        }
        }
        public class Person
        {
            int _age;
            string _name;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public static bool Older(int age1, int age2)
        {
            return (age1 > age2) ? true : false; // ternary operator
        }

        public static bool Oldest(int age1, int age2, int age3)
        {
            if ((age1 > age2) && (age1 > age3))
                {
                    Console.WriteLine("The oldest of the three is {0}", age1);
                }
            else if ((age2 > age1) && (age2 > age3))
                {
                    Console.WriteLine("The oldest of the three is {1}", age2);
                }
            else if ((age3 > age1) && (age3 > age2))
                {
                    Console.WriteLine("The oldest of the three is {3}", age3);
                }
            }

        public static bool Youngest(int age1, int age2, int age3)
        {
             if ((age1 > age2) && (age1 > age3))
                {
                    Console.WriteLine("The youngest of the three is {4} ", age1);
                }
             else if ((age2 > age1) && (age2 > age3))
                {
                    Console.WriteLine("The youngest of the three is {5}", age2);
                }
             else if ((age3 > age1) && (age3 > age2))
                {
                    Console.WriteLine("The youngest of the three is {6}", age3);
                }
            }
        }
    }

