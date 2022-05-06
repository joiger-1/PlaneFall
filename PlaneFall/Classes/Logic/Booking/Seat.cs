using PlaneFall.Classes.Logic.Location;
using PlaneFall.Classes.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneFall.Classes.Logic.Booking
{
    class Seat
    {
        public static List<Seat> Seats;
        private static int maxId;

        static Seat()
        {
            Seats = new List<Seat>();
        }
        public static void Load()
        {
            (int id, int begin, int end, DateTime dateTime)[] seatData = Repository.GetSeatsData();
            foreach ((int id, int begin, int end, DateTime dateTime) item in seatData)
            {
                Seats.Add(new Seat(item.id, Airport.GetById(item.begin), Airport.GetById(item.end), item.dateTime));
            }

            (int id, int seat, bool isBooking)[] bookData = Repository.GetBooksData();
            foreach ((int id, int seat, bool isBooking) item in bookData)
            {
                Seat tempSeat;
                try
                {
                    tempSeat = Seat.GetById(item.seat);
                }
                catch
                {
                    continue;
                }
                tempSeat.AddBooks(new Book(item.id, tempSeat, item.isBooking));
            }

        }

        public static Seat GetById(int id)
        {
            Seat[] res = Seats.Where(x => x.Id == id).ToArray();
            if(res.Length == 0)
            {
                throw new Exception("Рейс не найден");
            }
            return res[0];
        }

        public int Id { get; private set; }
        public (Airport begin, Airport end) Way { get; private set; }
        public DateTime DateTime { get; private set; }
        public List<Book> Books { get; private set; }

        private Seat(int id, Airport begin, Airport end, DateTime dateTime)
        {
            if (id >= maxId)
                maxId = id + 1;
            Id = id;
            Way = (begin, end);
            DateTime = dateTime;
            Books = new List<Book>();
        }
        private void AddBooks(Book books)
        {
            Books.Add(books);
        }

        public Seat(Airport begin, Airport end, DateTime dateTime)
        {
            Id = maxId++;
            Way = (begin, end);
            DateTime = dateTime;
            Books = new List<Book>();

            Repository.AddSeat(ToDataArray());
        }
        private (int, int, int, DateTime) ToDataArray()
        {
            return (Id, Way.begin.Id, Way.end.Id, DateTime);
        }
    }
}
