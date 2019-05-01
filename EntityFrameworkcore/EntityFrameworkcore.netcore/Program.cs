using EntityFrameworkcore.netcore.Models;
using System;
using System.Linq;

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
        }
    }
}
