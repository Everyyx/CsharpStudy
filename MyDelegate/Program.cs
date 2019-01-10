using System;
using static MyDelegate.Greeting;

namespace MyDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            #region lesson1-2
                //MyDelegate.show();               
            #endregion

            #region lesson3
                //非委托形式   
                System.Console.WriteLine("==========非委托============");
                Greeting.SayHi("安文瑞",Greeting.Country.Chinese);
                Greeting.SayHi("Every",Greeting.Country.American);

                //委托形式
                System.Console.WriteLine("============委托============");                
                //SayHiHandler sayHiHandler=new SayHiHandler(Greeting.SayHiChinese);
                Greeting.SayHiDelegate("安文瑞",SayHiChinese);
                Greeting.SayHiDelegate("every",SayHiAmerican);
            #endregion

        }
    }
}
