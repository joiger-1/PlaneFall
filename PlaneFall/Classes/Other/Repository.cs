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

        static public (int, int, int, DateTime)[] GetSeatsData()
        {
            object[][] data = Database.GetTable("[Seats]");
            (int, int, int, DateTime)[] resultData = data.Select(x => ((int)x[0], (int)x[0], (int)x[0], (DateTime)x[1])).ToArray();
            return resultData;
        }
        static public void UpdateSeat((int, int, int, DateTime) seat)
        {
            Database.Update("[Seats]", seat.Item1, "Begin", seat.Item2);
            Database.Update("[Seats]", seat.Item1, "End", seat.Item3);
            Database.Update("[Seats]", seat.Item1, "DateTime", seat.Item4);
        }
        static public void AddSeat((int, int, int, DateTime) seat)
        {
            Database.Insert("[Seats]", new object[] { seat.Item1, seat.Item2, seat.Item3, seat.Item4 });
        }

        static public (int, int, bool)[] GetBooksData()
        {
            object[][] data = Database.GetTable("[Books]");
            (int, int, bool)[] resultData = data.Select(x => ((int)x[0], (int)x[0], (bool)x[0])).ToArray();
            return resultData;
        }
        static public void UpdateBook((int, int, bool) seat)
        {
            Database.Update("[Books]", seat.Item1, "IsBooking", seat.Item3);
        }
        static public void AddBook((int, int, bool) seat)
        {
            Database.Insert("[Books]", new object[] { seat.Item1, seat.Item2, seat.Item3 });
        }

    }
}
