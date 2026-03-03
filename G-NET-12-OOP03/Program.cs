
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


           





            #endregion




        }
    }
}
