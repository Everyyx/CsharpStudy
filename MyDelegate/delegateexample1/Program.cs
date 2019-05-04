using System;

namespace delegateexample1
{
    class Program
    {
        #region 模板方法 借用指定的外部方法来产生结果
        //相当于“填空题”
        //将委托作为参数传入方法
        //优点：当出现新业务时，只需拓展ProductFactory,无论添加什么产品，只需将产品的方法封装在委托里（模板方法）
        #endregion
        static void Main(string[] args)
        {
            ProductFactory productfactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();

            Func<Product> func1 = new Func<Product>(productfactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productfactory.MakeToycar);

            Logger logger = new Logger();
            Action<Product> actionlog = new Action<Product>(logger.log);

            Box box1 = wrapFactory.WrapProduct(func1,actionlog);
            Console.WriteLine(box1.Product.Name);

            Box box2 = wrapFactory.WrapProduct(func2,actionlog);
            Console.WriteLine(box2.Product.Name);

        }
        class Logger
        {
            public void log(Product product)
            {
                Console.WriteLine("Produc {0} has producted at {1},price is {2}.",product.Name,DateTime.UtcNow,product.Price);
                //utcNow,无时区时间
            }
        }

        class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }

        class Box
        {
            public Product Product{get;set;}
        }
        /// <summary>
        /// 模板方法和回调方法是委托常用的两种形式，提高了程序的复用性
        /// </summary>
        class WrapFactory
        {
            public Box WrapProduct(Func<Product> getProduct,Action<Product>logCallBack)
            {
                Box box =new Box();
                Product product=getProduct.Invoke(); //模板方法
                if (product.Price>50)
                {
                    logCallBack.Invoke(product);//回调方法
                }
                box.Product=product;
                return box;
            }
        }

        class ProductFactory
        {
            public Product MakePizza()
            {
                Product product = new Product
                {
                    Name = "pizza",
                    Price = 53
                };
                return product;
            }
            
            public Product MakeToycar()
            {
                Product product = new Product();
                product.Name = "Toycar";
                product.Price = 51;
                return product;
            }
        }
    }
}
