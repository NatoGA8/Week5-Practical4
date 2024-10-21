using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Practical4
{
    internal class W5P4
    {
        private static void Main(string[] args)
        {
            Question1();
            Question2();
            Question3();
            Question5();
            Question6();
        }
        private static void Question1() 
        {
            Console.WriteLine("-------Question 1-------");
            for (int number = 1; number <= 10; number++)
            {
                Console.WriteLine(number);
            }
        }

        private static void Question2()
        {
            Console.WriteLine("\n-------Question 2-------");
            for (int number = 10; number > 0; number--)
            {
                Console.WriteLine(number);
            }
        }

        private static void Question3()
        {
            Console.WriteLine("\n-------Question 3-------");
            int sum = 0;
            Console.WriteLine("Enter numbers to add to the sum. Enter 0 to stop.");
            int userInput;
            do
            {
                Console.Write("Enter a number: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                sum += userInput;
            }
            while (userInput != 0);
            Console.WriteLine($"The total sum is: {sum}");
        }

        private static void Question5()
        {
            Console.WriteLine("\n-------Question 5-------");
            Person person = new Person("John", "Doe", 23);
            Person person2 = new Person("Mary", "Smith", 25);
            person.PrintName();
            person2.PrintName();
        }

        private static void Question6()
        {
            Console.WriteLine("\n-------Question 6-------");
            Person person = new Person("Fred", "Jones", 44);
            Person person2 = new Person("Susan", "Gates", 33);
            Person oldest = person.CalculateOldest(person, person2);
            Console.WriteLine("The oldest person is:");
            Console.WriteLine("Name: " + oldest.FirstName + " " + oldest.LastName);
            Console.WriteLine($"Age: {oldest.Age}");
        }
    }

