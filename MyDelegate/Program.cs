using System;
using static MyDelegate.Greeting;

namespace MyDelegate
{
    public delegate int Calc(int x, int y);

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

            #region 刘铁猛:系统自带委托的学习 2019/5/4

            //委托是一种类，而类是一种数据类型
            Type type = typeof(Action);
            Console.WriteLine(type.IsClass);

            Calculate calculate = new Calculate();
            //action return a value
            Action action = new Action(calculate.Report);
            action.Invoke();


            //function return a vlaue 
            Func<int, int, int> func1 = new Func<int, int, int>(calculate.Add);

            Func<int, int, int> func2 = new Func<int, int, int>(calculate.Sub);

            Console.WriteLine("func1:" + func1.Invoke(2, 3));
            Console.WriteLine("func2:" + func2.Invoke(4, 3));

            #endregion

            #region 申明调用自己的委托

            Console.WriteLine("============using my delegate==============");
            myCalculate myCalculate = new myCalculate();
            Calc calc1 = new Calc(myCalculate.Add);
            Calc calc2 = new Calc(myCalculate.Sub);
            Calc calc3 = new Calc(myCalculate.Mul);
            Calc calc4 = new Calc(myCalculate.Div);

            int x = 2;
            int y = 4;
            Console.WriteLine(calc1.Invoke(x,y));
            Console.WriteLine(calc2.Invoke(x,y));
            Console.WriteLine(calc3.Invoke(x,y));
            Console.WriteLine(calc4.Invoke(x,y));
            #endregion
        }

        class Calculate
        {
            public void Report()
            {
                Console.WriteLine("I have three methods!");
            }

            public int Add(int a,int b)
            {
                return a + b;
            }
            public int Sub(int a, int b)
            {
                return a - b;
            }
        }
    }

    class myCalculate
    {
        public int Add(int x, int y) => x + y;
        public int Sub(int x, int y) => x - y;
        public int Mul(int x, int y) => x * y;
        public int Div(int x, int y) => x / y;


    }
}
