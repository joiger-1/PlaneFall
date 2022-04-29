using PlaneFall.Classes.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneFall.Classes.Logic.Location
{
    class Airport
    {
        public static List<Airport> Airports { get; private set; }
        public City Country { get; private set; }

        public int Id { get; private set; }
        public string Name { get; private set; }

        static Airport()
        {
            Airports = new List<Airport>();

            (int, string, int)[] data = Repository.GetCityData();

            foreach ((int id, string name, int cityId) item in data)
            {
                new Airport(item.id, item.name, item.cityId);
            }
        }
        private Airport(int id, string name, int countryId)
        {
            Id = id;
            Name = name;
            Country = City.GetById(countryId);

            Airports.Add(this);
        }

        public override string ToString()
        {
            return $"{Name}, {Country}";
        }

        static public Airport GetById(int id)
        {
            Airport[] result = Airports.Where(x => x.Id == id).ToArray();
            if (result.Count() == 0)
                throw new Exception("Город по указаному индексу не найдена");

            return result[0];
        }
    }
}
