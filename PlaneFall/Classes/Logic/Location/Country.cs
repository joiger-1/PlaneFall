using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaneFall.Classes.Other;

namespace PlaneFall.Classes.Logic.Location
{
    class Country
    {
        public static List<Country> Countries { get; private set; }

        public int Id { get; private set; }
        public string Name { get; private set; }

        static Country()
        {
            Countries = new List<Country>();

            (int, string)[] data = Repository.GetCountryData();
            
            foreach((int id, string name) item in data)
            {
                new Country(item.id, item.name);
            }
        }
        private Country(int id, string name) 
        {
            Id = id;
            Name = name;

            Countries.Add(this);
        }

        public override string ToString()
        {
            return Name;
        }

        static public Country GetById(int id)
        {
            Country[] result = Countries.Where(x => x.Id == id).ToArray();
            if (result.Count() == 0)
                throw new Exception("Страна по указаному индексу не найдена");

            return result[0];
        }
    }
}
