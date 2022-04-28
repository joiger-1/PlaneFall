using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneFall.Classes.Logic
{
    class Country
    {
        public static List<Country> Countries { get; private set; }

        public int Id { get; private set; }
        public string Name { get; private set; }

        static Country()
        {

        }
        public Country() { }
    }
}
