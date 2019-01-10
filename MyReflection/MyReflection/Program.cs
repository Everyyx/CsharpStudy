//using Study;
using System;
using System.Reflection;

namespace MyReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //SqlserverHelper sqlserverHelper = new SqlserverHelper();
            //sqlserverHelper.Query();
            Console.WriteLine("Hello World!");
            

            Assembly assembly= Assembly.Load("Study");
            Module[] modules= assembly.GetModules();
            foreach (var item in modules)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
