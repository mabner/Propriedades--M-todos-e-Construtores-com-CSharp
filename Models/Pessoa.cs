using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _name;
        public string Name
        {
            get { return _name.ToUpper(); }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                _name = value;
            }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("A idade não pode ser negativa");
                }
                _age = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Name}, Idade: {Age}");
        }
    }
}
