using System;

namespace Mygeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("===============一般方法================");
            MethodShow.ShowInt(123);
            MethodShow.ShowLong(21312421);

            System.Console.WriteLine("===============Object方法==============");
            MethodShow.ShowObject("asdf");
            MethodShow.ShowObject('s');

            System.Console.WriteLine("===============泛型方法================");
            MethodShow.ShowGeneric<int>(213);
            MethodShow.ShowGeneric('c');
            Chinese personA=new Chinese
            {
                id=1,
                age=23,
                name="安文瑞",
                tool="筷子"
            };
            MethodShow.ShowHiGeneric<Chinese>(personA);
        }
    }

    public class MethodShow
    {
        public static void ShowInt(int iParameter) => Console.WriteLine("这里是Methodshow.showint{0}类型为{1}", iParameter, iParameter.GetType());
        public static void ShowLong(long lParameter) => Console.WriteLine("这里是Methodshow.showlong{0}类型为{1}", lParameter, lParameter.GetType());
        

        //缺陷：1.装箱、拆箱消耗性能
        //     2.无类型检查
        public static void ShowObject(object oParameter) => Console.WriteLine("这里是Methodshow.showobject{0}类型为{1}", oParameter, oParameter.GetType());
        //T作为类型参数用来检查参数类型
        public static void ShowGeneric<T>(T tParameter) =>System.Console.WriteLine("这里是Methodshow.showgeneric{0}类型为{1}", tParameter, tParameter.GetType());

        public static void ShowHiGeneric<T>(T tParameter) where T:People
        {
            tParameter.SayHi();
            System.Console.WriteLine("{0},{1},{2}",tParameter.name,tParameter.id,tParameter.age);
        }
    }
}
