using EntityFrameworkcore.netcore.Models;
using System;
using System.Linq;
using System.Threading;
namespace EntityFrameworkcore.netcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello EntityFrameworkcore");
            //PM控制台中的链接字符串：Scaffold-Dbcontext -Connection "Server=.;Database=AdventureWorks2012;uid=sa;pwd=an15222055120" Microsoft.EntityFrameworkcore.SqlServer -OutputDir "Models"
            using (Models.AdventureWorks2012Context dbcontext=new Models.AdventureWorks2012Context())
            {
                var person = dbcontext.Person.Where(b => b.FirstName.Contains("ken")).ToList();
                Console.WriteLine("First name          lastname");
                foreach (Person p in person)
                {

                    Console.WriteLine(p.FirstName+"            "+p.LastName);
                }
            }

            //Timer timer = new Timer();
            System.Timers.Timer timer2 = new System.Timers.Timer(1000);
            timer2.Elapsed += Timer2_Elapsed;
            timer2.Start();
            Console.ReadKey();
        }

        private static void Timer2_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString());
        }
    }
}
