using Week5_Practical4;
using System.IO.Pipes;
using System.Reflection.PortableExecutable;

namespace W5P4
{
    internal class W5P4
    {
        static void Main(string[] args)
        {
            // Do not edit this code
            Question1();
            Question2();
            Question3();
            Question5();
            Question6();
        }
        static void Question1()
        {
            // Question1:
            Console.WriteLine("--------Question 1--------");
            //Enter code and comments here...

            //Start with number =1 and increment by 1 until number <=10
            for (int number = 1; number <= 10; number++)
            {
                Console.WriteLine(number);
            }
        }
        static void Question2()
        {
            // Question 2:
            Console.WriteLine("\n--------Question 2--------");
            // Enter code and comments here...

            // Initialise starting number for the while loop
            int number = 10;

            // Number must be greater than 0 since output
            // begins at 1
            while (number > 0)
            {
                Console.WriteLine(number);
                // Decrease count by 1
                number--;
            }
        }
        static void Question3()
        {
            // Question 3:
            Console.WriteLine("\n--------Question 3--------");
            // Enter code and comments here...

            // Initialise sum and user input variables
            int sum = 0;
            int userInput;
            Console.WriteLine("Enter numbers to add to the sum. Enter 0 to stop.");
            //Repeat loop until user enters 0
            do
            {
                Console.Write("Enter a number: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                sum += userInput;
            } while (userInput != 0); // repeat until input = 0

            Console.WriteLine($"The total sum is: {sum}");
        }

        static void Question5()
        {
            // Question 5:
            Console.WriteLine("\n--------Question 5--------");
            // Enter code and comments here...
            // Create 2 instances of the Person class called
            // person1 and person2
            Person person = new Person("John", "Doe", 23);
            Person person2 = new Person("Mary", "Smith", 25);

            // Print person details using the PrintName() method
            // in the Person class
            person.PrintName();
            person1.PrintName();
        }

        static void Question6()
        {
            // Question 6:
            Console.WriteLine("\n--------Question 6--------");

            // Create 2 instances of the person class and populate
            Person person = new Person("Fread", "Jones", 44);
            Person person1 = new Person("Susan", "Gates", 33);

            //Intialise the CalculateOlders method with 2 person objects 
            Person oldest = person.CalculateOldest(person, person1);

            //Output the oldest persons information to the screen

            Console.WriteLine($"The oldest person is:");
            Console.WriteLine($"Name:{oldest.FirstName} {oldest.LastName}");
            Console.WriteLine($"Age: {oldest.Age}");
        }
    }
}