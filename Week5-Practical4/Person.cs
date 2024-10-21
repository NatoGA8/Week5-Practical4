using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Practical4
{
    public class Person
    {
        private string firstname;
        private string lastname;
        private int age;

        // Public properties
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void PrintName()
        {
            Console.WriteLine($"Persons first name: {FirstName}");
            Console.WriteLine($"Persons Last name: {LastName}");
            Console.WriteLine($"Persons age: {Age}");
        }
        public int CalculateOldest(List<Person> people)
        {
            int oldest = 0;
            foreach (var person in people)
            {
                if (person.Age > oldest)
                {
                    oldest = person.Age;
                }
            }
            return oldest;
        }
        public int AddAlllAges(List<Person> people)
        {
            int totalAge = 0;
            foreach (var person in people)
            {
                totalAge += person.Age;
            }
            return totalAge;
        }
        public Person(string personFirstName, string personLastName, int personAge)
        {
            this.Firstname = personFirstName;
            this.LastName = personLastName;
            this.Age = personAge;
        }
        // Default constuctor with no arguments

        public Person()
        {

        }
        public Person CalculateOldest(Person p1, Person p2)
        {
            Person oldestPerson = new Person();

            if (p1.Age > p2.Age)
            {
                oldestPerson.Age = p1;
            }
            else // if oldest person is not p1 then it must be p2
            {
                oldestPerson.Age = p2;
            }
            // return oldest person to the calling code
            return oldestPerson;

        }
    }
}

