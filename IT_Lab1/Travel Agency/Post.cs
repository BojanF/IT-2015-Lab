using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Agency
{
    class Post
    {
        public int Id { get; set; }
        public List<Ticket> TicketsSold;

        public Post(int Id)
        {
            this.Id = Id;
            TicketsSold = new List<Ticket>();
        }

        public void AddTicket(Ticket ticket)
        {
            TicketsSold.Add(ticket);
        }

        public List<Ticket> getTickets()
        {
            return TicketsSold;
        }

        public List<Ticket> soldTicketsIntervalDetails(DateTime start, DateTime end)
        {
            List<Ticket> result = new List<Ticket>();
            foreach(Ticket t in TicketsSold)
            {
                if (t.PurchaseTime.CompareTo(start) == 1 && t.PurchaseTime.CompareTo(end) == -1)
                    result.Add(t);
            }
            return result;
        }

        public int soldTicketsInterval(DateTime start, DateTime end)
        {
            int result = 0;
            foreach (Ticket t in TicketsSold)
            {
                if (t.PurchaseTime.CompareTo(start) == 1 && t.PurchaseTime.CompareTo(end) == -1)
                    result += 1;
            }
            return result;
        }

        public int getRevenueInterval(DateTime start, DateTime end)
        {
            int result = 0;
            foreach (Ticket t in TicketsSold)
            {
                if (t.PurchaseTime.CompareTo(start) == 1 && t.PurchaseTime.CompareTo(end) == -1)
                    result+=t.Price;
            }
            return result;
        }

        public int postRevenue()
        {
            int revenue = 0;
            foreach(Ticket t in TicketsSold)
            {
                revenue += t.Price;
            }
            return revenue;
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
