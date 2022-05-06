using PlaneFall.Classes.Other;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlaneFall.Classes.Logic.Location
{
    class City
    {
        public static List<City> Cities { get; private set; }
        public Country Country { get; private set; }

        public int Id { get; private set; }
        public string Name { get; private set; }

        static City()
        {
            Cities = new List<City>();

            (int, string, int)[] data = Repository.GetCityData();

            foreach ((int id, string name, int countryId) item in data)
            {
                new City(item.id, item.name, item.countryId);
            }
        }
        private City(int id, string name, int countryId)
        {
            Id = id;
            Name = name;
            Country = Country.GetById(countryId);

            Cities.Add(this);
        }

        public override string ToString()
        {
            return $"{Name}, {Country}";
        }

        static public City GetById(int id)
        {
            City[] result = Cities.Where(x => x.Id == id).ToArray();
            if (result.Count() == 0)
                throw new Exception("Город по указаному индексу не найдена");

            return result[0];
        }
    }
}
