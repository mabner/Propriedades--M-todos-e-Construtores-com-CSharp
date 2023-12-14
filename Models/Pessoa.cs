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
            get => _name.ToUpper();
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
            get => _age;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(
                    value,
                    "A idade não pode ser menor do que zero."
                );
                _age = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Name}, Idade: {Age}");
        }
    }
}
