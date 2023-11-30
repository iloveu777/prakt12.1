using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace prakt12._1
{
    internal class Address
    {
        public int Index;
        public string Country;
        public string City;
        public string Street;
        public int House;
        public int Apartament;
        public Address() { }
        public Address(int index, string country, string city, string street, int house, int apartament)
        {
            this.Index = index;
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.House = house;
            this.Apartament = apartament;
        }
        public void Print()
        {
            WriteLine($"Почтовый индекс- {Index}, Страна- {Country}, Город - {City}, Улица - {Street}, Номер дома- {House}, Номер квартиры- {Apartament}");
        }
    }
}
