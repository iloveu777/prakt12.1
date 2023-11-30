using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace prakt12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write("Введите имя: ");
            string name = ReadLine();
            Write("Введите фамилию: ");
            string surname = ReadLine();
            Write("Введите возраст: ");
            int age = int.Parse(ReadLine());
            Person person = new Person(name, surname, age);
            person.Print();*/
            /*
            Write("Введите X: ");
            double x = double.Parse(ReadLine());
            Write("Введите Y: ");
            double y = double.Parse(ReadLine());
            Point point = new Point(x, y);
            point.Print();
            point.Distance();
            */
            Write("Введите индекс: ");
            int index = int.Parse(ReadLine());
            Write("Введите название страны: ");
            string country = ReadLine();
            Write("Введите название города: ");
            string city = ReadLine();
            Write("Введите название улицы: ");
            string street = ReadLine();
            Write("Введите номер дома: ");
            int house = int.Parse(ReadLine());
            Write("Введите номер квартиры: ");
            int apartament = int.Parse(ReadLine());
            Address address = new Address(index, country, city, street, house, apartament);
            address.Print();
            ReadKey();
        }
    }
}
