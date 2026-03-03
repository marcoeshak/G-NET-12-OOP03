
using System.Collections;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.AccessControl;

namespace G_NET_12_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Part 1

            #region Q01
            /*
            a) 
             Composition

           b) 
             Association

           c) 
              Inheritance

            d) 
              Aggregation

            e) 
                Dependency
            */

            #endregion

            #region Q02

            // a) 

            // Child class in Diffrent Assembly  // Yes

            // من خلال object instance برا الكلاس // No

            // b) 
            // protected internal
            // Accessible :
            // أي كلاس في نفس Assembly
            // او أي Child class حتى لو Diffrent Assembly 
            //private protected
            // Accessible :

            // Child classes فقط

            // ولازم يكونوا في نفس Assembly

            // c) 
            //  sealed class
            // لا يمكن الوراثة منها
            //sealed method
            //لا يمكن override لها في child class

            // d) Create object from sealed class?
            //  Yes
            // لأن sealed يمنع inheritance فقط، مش إنشاء object.




            #endregion

            #endregion

            #region Part 2

            #region Q01


            /*
            بعمل كلاس جديد باسم تيكت وبكتب فيه ....

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


            */
            #endregion

            #region Q02

            // بعمل كلاس جديد باسم StandardTicket.cs

            /*
                public class StandardTicket : Ticket
            {
            public string SeatNumber { get; set; }

            public StandardTicket(string movie, decimal price, string seat)
                : base(movie, price)
            {
                SeatNumber = seat;
            }

            public override string ToString()
            {
                return base.ToString() + $" | Seat: {SeatNumber}";
            }
             }
            */

            #endregion

            #region Q02..
            //بعمل كلاس جديد باسم VIPTicket.cs
            /*
            public class VIPTicket : Ticket
        {
            public bool LoungeAccess { get; set; }
            public decimal ServiceFee { get; } = 50;

            public VIPTicket(string movie, decimal price, bool lounge)
                : base(movie, price)
            {
                LoungeAccess = lounge;
            }

            public override string ToString()
            {
                return base.ToString()
                     + $" | Lounge: {(LoungeAccess ? "Yes" : "No")}"
                     + $" | Service Fee: {ServiceFee} EGP";
            }
        }
            */
            //=======================

            //بعمل كلاس باسم IMAXTicket.cs
            /*
            public class IMAXTicket : Ticket
        {
            public bool Is3D { get; set; }

            public IMAXTicket(string movie, decimal price, bool is3D)
                : base(movie, is3D ? price + 30 : price)
            {
                Is3D = is3D;
            }

            public override string ToString()
            {
                return base.ToString() + $" | IMAX 3D: {(Is3D ? "Yes" : "No")}";
            }
        }
            */


            #endregion

            #region Q03
            // بعمل كلاس باسم Projector.cs

            /*
            public sealed class Projector
        {
            public void Start()
            {
                Console.WriteLine("Projector started.");
            }

            public void Stop()
            {
                Console.WriteLine("Projector stopped.");
            }
        }
            */

            //========= 

            // بعمل كلاس جديد باسم Cinema.cs
            /*
            public class Cinema
        {
            public string CinemaName { get; set; }

            private Projector projector = new Projector();
            private Ticket[] tickets = new Ticket[20];

            public Cinema(string name)
            {
                CinemaName = name;
            }

            public void OpenCinema()
            {
                Console.WriteLine("========== Cinema Opened ==========");
                projector.Start();
            }

            public void CloseCinema()
            {
                Console.WriteLine("\n========== Cinema Closed ==========");
                projector.Stop();
            }

            public void AddTicket(Ticket t)
            {
                for (int i = 0; i < tickets.Length; i++)
                {
                    if (tickets[i] == null)
                    {
                        tickets[i] = t;
                        break;
                    }
                }
            }

            public void PrintAllTickets()
            {
                Console.WriteLine("\n========== All Tickets ==========");
                foreach (Ticket t in tickets)
                {
                    if (t != null)
                        Console.WriteLine(t);
                }

                Console.WriteLine("\n========== Statistics ==========");
                Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");
            }
        }
            */



            #endregion

            #region Q04
            /*
            class Program
        {
            static void Main()
            {
                Cinema cinema = new Cinema("Galaxy Cinema");
                cinema.OpenCinema();

                cinema.AddTicket(new StandardTicket("Inception", 120, "A-5"));
                cinema.AddTicket(new VIPTicket("Avengers", 200, true));
                cinema.AddTicket(new IMAXTicket("Dune", 180, false));

                cinema.PrintAllTickets();
                cinema.CloseCinema();
            }
        }

            */
            #endregion


    }
    }
}
