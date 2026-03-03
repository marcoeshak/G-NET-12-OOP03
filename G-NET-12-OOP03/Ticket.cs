using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP03
{
    internal class Ticket
    {
        public class Ticket
        {
            private static int counter = 0;

            public int TicketId { get; }
            public string MovieName { get; set; }

            private decimal price;
            public decimal Price
            {
                get => price;
                set
                {
                    if (value <= 0)
                        throw new ArgumentException("Price must be greater than 0");
                    price = value;
                }
            }

            public decimal PriceAfterTax => Price * 1.14m;

            public Ticket(string movieName, decimal price)
            {
                TicketId = ++counter;
                MovieName = movieName;
                Price = price;
            }

            public static int GetTotalTickets()
            {
                return counter;
            }

            public override string ToString()
            {
                return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
            }
        }
    }
}
