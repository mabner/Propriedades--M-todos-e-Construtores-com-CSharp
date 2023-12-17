using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringCSharp.Models
{
    public class Person
    {
        // Default constructor
        public Person()
        {
        }

        // Custom constructor
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        private string _name;
        private int _age;

        public string Name
        {
            get => _name;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("The name field must not be empty.");
                }

                _name = value;
            }
        }

        public string Surname { get; set; }
        public string FullName => $"{Name} {Surname}".ToUpper();

        public int Age
        {
            get => _age;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(
                    value,
                    "The age cannot be a negative number."
                );
                _age = value;
            }
        }

        public void Present()
        {
            Console.WriteLine($"Name: {FullName}, Age: {Age}");
        }
    }
}