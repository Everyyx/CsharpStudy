using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork.netframework
{
    class Program
    {
        static void Main(string[] args)
        {
            AdventureWorks2012Entities adventureWorks2012EntitiesProxy = new AdventureWorks2012Entities();
            foreach (Product product in adventureWorks2012EntitiesProxy.Products)
            {
                Console.WriteLine(product.Name.ToString());
            }
            Console.WriteLine("============================================");
            Console.WriteLine(adventureWorks2012EntitiesProxy.Products.Count());
        }
    }
}
