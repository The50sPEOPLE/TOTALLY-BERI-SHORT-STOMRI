using System;
using System.Threading;

namespace EP1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Changes the apperance of the programme
            Console.Title = "Terminal BOB THE POPPY POOPTISH";
            Console.ForegroundColor = ConsoleColor.Green;

            // INTRO
            Thread.Sleep(1000);
            Console.WriteLine("HELLO I AM A BOB CREATED BY 50s THE POOPER");
            Thread.Sleep(1000);
            Console.WriteLine("NO TALK LETS BEGIN!!!");
            // the actual shits over here
            Console.ForegroundColor = ConsoleColor.Yellow;

            Thread.Sleep(1000);

            Console.WriteLine("Once There was a ");

            Console.ForegroundColor = ConsoleColor.Cyan;

            String things1 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Thread.Sleep(1000);

            Console.WriteLine(things1 +" Name chimbo \nOne day " + things1 + " walked in the ");

            Console.ForegroundColor = ConsoleColor.Cyan;

            String things2 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Thread.Sleep(1000);

            Console.WriteLine("In the " + things2 + " he met a ");

            Console.ForegroundColor = ConsoleColor.Cyan;

            String things3 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Thread.Sleep(1000);

            Console.WriteLine(things3 + " Asked someone for");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("THE GOLDEN POOP");

            Console.ForegroundColor = ConsoleColor.Red;

            Thread.Sleep(1000);

            Console.WriteLine("But instead of getting");

            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("THE GOLDEN POOP");

            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A BIGFOOT killed both of them");

            // The end
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("DE END");
            Console.ReadKey();
            
        }
    }
}
