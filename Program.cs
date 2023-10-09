using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3.Variebles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string name = "John";
            int age;

            //intitialisation
            name = "John";
            age = 10;

            //what will soon be on console
            Console.WriteLine("There once was a boy called " + name);
            Console.WriteLine(name + " was " + age + "of age. ");
            Console.WriteLine(name + " really never liked his name. ");

            //change variables values
            age = 18;
            name = "Tom";

            Console.WriteLine("At age " + age + "he changed his name to " + name);

            //to freeze the console
            Console.ReadLine();

        }
    }
}
