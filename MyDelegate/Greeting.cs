namespace MyDelegate
{
    public class Greeting
    {
        public delegate void SayHiHandler(string name);
        public enum Country
        {
            Chinese,
            American
        }
        //非委托形式，拓展性差
        public static void SayHi(string name,Country country)
        {
            if (country==Country.Chinese)
            {
                System.Console.WriteLine($"早上好，{name}");
            }
            else if(country==Country.American)
            {
                System.Console.WriteLine($"Morning,{name}");
            }
        }

        public static void SayHiDelegate(string name,SayHiHandler sayhi)
        {
            //sayhi(name);
            sayhi.Invoke(name);

            //SayHiDelegate方法中传入两个参数，一个委托，一个string
        }

        public static void SayHiChinese(string name)
        {
            System.Console.WriteLine($"早上好,{name}");
        }
        public static void SayHiAmerican(string name)
        {
            System.Console.WriteLine($"Morning,{name}");
        }
    }
}