using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneFall
{
    class Seats
    {
        static public Seats Instance { get; private set; }
        static private Dictionary<int, Seat> _seats;
        static private int _max_id;
        public Seats()
        {
            Instance = this;
            _seats = new Dictionary<int, Seat>();

            string SqlText = $"select * from [Seats]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, Program.ConStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Seats]");

            for (int i = 0; i < ds.Tables["[Seats]"].Rows.Count; i++)
            {
                object[] data = ds.Tables["[Seats]"].Rows[i].ItemArray;
                (int id, DateTime datetime, string begin, string end) seat = ((int)data[0], (DateTime)data[1], data[2] as string, data[3] as string);

                _seats[seat.id] = seat;
                if (seat.id >= _max_id)
                    _max_id = seat.id + 1;
            }
        }

        public (int id, DateTime datetime, string begin, string end)[] GetSeats(string begin = null, string end = null)
        {
            (int id, DateTime datetime, string begin, string end)[] seats = _seats.Select(x => x.Value).ToArray();

            if (begin != null)
                seats = seats.Where(x => x.begin == begin).ToArray();
            if (end != null)
                seats = seats.Where(x => x.end == end).ToArray();

            return seats;
        }
        public void Add((DateTime datetime, string begin, string end) seat)
        {
            _seats[_max_id] = (_max_id, seat.datetime, seat.begin, seat.end);

            string command = $"insert into [Seats] values({_max_id}, '{seat.datetime}', N'{seat.begin}', N'{seat.end}')";
            Program.MyExecuteNonQuery(command);
            _max_id++;
        }
        public void Update(int id, (DateTime datetime, string begin, string end) seat)
        {
            _seats[id] = (_max_id, seat.datetime, seat.begin, seat.end);

            string command = $"update [Seats] set [DateTime]='{_seats[id].datetime.ToString("yyyy-MM-dd")}T{_seats[id].datetime.ToString("hh:mm:ss")}', [Begin]='{_seats[id].begin}', [End]='{_seats[id].end}' where [Id]={id}";
            Program.MyExecuteNonQuery(command);
        }
        public void Delete(int id)
        {
            string command = $"delete from [Seats] where [Id]={id}";
            _seats.Remove(id);
            Program.MyExecuteNonQuery(command);
        }
    }
}
