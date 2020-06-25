using System;
using System.Threading;

namespace DelegatesAndEvents
{
    class Program
    {
        //Declaring delegates
        //This is signature of any method that returns void and accepts strings as param
        public delegate void SayDelegate(string message);
        public delegate int NumbersDelegate(int num1, int num2);
        static void Main(string[] args)
        {
            #region Instatiating a delegate with methods
            SayDelegate hello = new SayDelegate(SayHello);
            SayDelegate bye = new SayDelegate(SayBye);


            //using a delegate (delegates point to methods)
            hello("Martin");
            bye("Martin");

            hello("Dejan");
            bye("Dejan");



            #endregion

            #region Passing method to an input param of type delegate parameter
            Thread.Sleep(1500);
            SayWhatever("Ivo", SayHello);
            SayWhatever("Bob", SayBye);

            Thread.Sleep(2000);
            //send method as input param to other m,ethod by using lambda expression (anon method)
            SayWhatever("John", x => Console.WriteLine($"Wow {x}"));

            ////send method as input param to other m,ethod by using lambda expression (anon method) with own scope
            SayWhatever("Ann", x =>
            {
                if (x == "Ann")
                {
                    Console.WriteLine($"Ohh {x}, it's you");
                } else
                {
                    Console.WriteLine($"Stuff with {x}");
                    Console.WriteLine($"Other stuff with {x}");
                }
                
            });
            #endregion

            #region Making a higher order function
            Console.WriteLine("NUMBER MASTER! IT IS REALLY MASTER AT NUMBERS!");

            NumberMaster(10, 20, (x, y) => x + y);
            NumberMaster(134, 112, (x, y) => x - y);
            NumberMaster(2, 5, (x, y) => 0);
            NumberMaster(22, 33, (x, y) => {

                if (x > y)
                    return y;
                return x;
            });
            #endregion


            Console.ReadLine();
        }

        public static void SayHello(string person)
        {
            Console.WriteLine($"Hello {person}!");
        }


        public static void SayBye(string person)
        {
            Console.WriteLine($"Bye {person}!");
        }

        public static void SayWhatever(string whatever, SayDelegate sayDel)
        {
            Console.WriteLine($"This message comes from chat bot:");
            sayDel(whatever);
        }

        public static void NumberMaster(int num1, int num2, NumbersDelegate numberDel)
        {
            Console.WriteLine($"The result is: {numberDel(num1, num2)}");
        }
    }
}
