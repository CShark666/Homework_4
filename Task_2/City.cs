using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class City
    {
        public string Name { get; set; }
        public int Population { get; set; }

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public static City operator +(City city, int value)
        {
            city.Population += value;
            return city;
        }


        public static City operator -(City city, int value)
        {
            city.Population -= value;
            return city;
        }

 
        public static bool operator ==(City city1, City city2)
        {
            return city1.Population == city2.Population;
        }


        public static bool operator !=(City city1, City city2)
        {
            return city1.Population != city2.Population;
        }


        public static bool operator >(City city1, City city2)
        {
            return city1.Population > city2.Population;
        }


        public static bool operator <(City city1, City city2)
        {
            return city1.Population < city2.Population;
        }


        public override bool Equals(object obj)
        {
            if (obj is City city)
            {
                return this.Population == city.Population;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Population.GetHashCode();
        }

        public override string ToString()
        {
            return $"City: {Name}, Population: {Population}";
        }
    }
}
