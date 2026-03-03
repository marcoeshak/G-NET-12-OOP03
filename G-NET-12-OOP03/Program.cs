
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






        }
    }
}
