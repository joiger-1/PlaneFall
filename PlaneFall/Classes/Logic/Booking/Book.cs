using PlaneFall.Classes.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneFall.Classes.Logic.Booking
{
    class Book
    {
        private static int maxId;

        public int Id { get; private set; }
        public Seat Seat { get; private set; }
        public bool IsBooking { get; private set; }

        public Book(Seat seat)
        {
            Id = maxId++;

            Seat = seat;
            IsBooking = false;
        }
        public Book(int id, Seat seat, bool isBokking)
        {
            if (id >= maxId)
                maxId = id + 1;
            Id = id;

            Seat = seat;
            IsBooking = isBokking;
        }
        public void Booking()
        {
            if (IsBooking)
                throw new Exception("Место уже забронировано");
            IsBooking = true;

            Repository.UpdateBook(this.ToDataArray());
        }
        public void Unbooking()
        {
            IsBooking = false;

            Repository.UpdateBook(this.ToDataArray());
        }
        private (int, int, bool) ToDataArray()
        {
            return (Id, Seat.Id, IsBooking);
        }
    }
}
