using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneFall.Classes.Other
{
    static class Repository
    {
        static public (int, string)[] GetCountryData()
        {
            object[][] data = Database.GetTable("[Countries]");
            (int, string)[] resultData = data.Select(x => ((int)x[0], x[1] as string)).ToArray();
            return resultData;
        }
        static public (int, string, int)[] GetCityData()
        {
            object[][] data = Database.GetTable("[Cities]");
            (int, string, int)[] resultData = data.Select(x => ((int)x[0], x[1] as string, (int)x[2])).ToArray();
            return resultData;
        }
        static public (int, string, int)[] GetAirportData()
        {
            object[][] data = Database.GetTable("[Airports]");
            (int, string, int)[] resultData = data.Select(x => ((int)x[0], x[1] as string, (int)x[2])).ToArray();
            return resultData;
        }
    }
}
