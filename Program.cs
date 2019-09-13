using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            string firstName;
            string lastName;
            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Hello, " + firstName);

            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();
            //Console.WriteLine("Nice to meet you, " + firstName + " " + lastName);
            //I'm just a comment

            Console.WriteLine("Nice to meet you, {0} {1}!", firstName, lastName);

            string color;

            Console.WriteLine("Whatś your favourite color?");
            color = Console.ReadLine();
            Console.WriteLine("You favourite color is {0}.", color);

            Console.WriteLine(firstName + ", " + "How old are you?");
            string input = Console.ReadLine();
            Console.WriteLine("You are" + " " + input + " " + "years oled.");
           




            Console.ReadLine();

        }
    }
}
