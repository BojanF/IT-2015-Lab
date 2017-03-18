using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Agency
{
    class Ticket
    {
        public string Destination { get; set; }
        public int Price { get; set; }
        public DateTime PurchaseTime { get; set; }
        public Person TicketHolder { get; set; }

        public Ticket(string Destination, int Price, Person TicketHolder, DateTime PurchaseTime)
        {
            this.Destination = Destination;
            this.Price = Price;
            this.TicketHolder = TicketHolder;
            this.PurchaseTime = PurchaseTime;
        }

        override public string ToString()
        {
            return string.Format("Holder: {0}\n{1}-{2:0,0.00}\nPurchased in: {3}", TicketHolder, Destination, Price, PurchaseTime);
        }
        
    }
}
