using System;
using System.Timers;

namespace MyEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer time=new Timer();
            time.Interval=1000;
            time.Elapsed+=boy.Action;
            time.Elapsed+=girl.Action;
            time.Start();
            Console.ReadLine();          
        }
    }

    class boy
    {
        internal static void Action(object sender,ElapsedEventArgs e)
        {
            System.Console.WriteLine("Jump!");
        }
    }

    class girl
    {
        internal static void Action(object sender, ElapsedEventArgs e)
        {
            System.Console.WriteLine("sing!");
        }
    }
}
