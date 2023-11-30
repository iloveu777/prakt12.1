using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace prakt12._1
{
    internal class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public Person() { }
        public Person(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public void Print()
        {
            WriteLine($"Имя - {Name}, Фамилия - {Surname}, Возраст - {Age}. ");
        }
    }
}
