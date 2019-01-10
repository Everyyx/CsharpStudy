using System.Threading;

namespace MyDelegate
{
    public delegate void NoParaNoReturnOutClass();//可以在类外面实例化
    public class  MyDelegate    
    {
        public delegate void NoParaNoReturn();//本质是个类型
        public delegate int NoParaWithReturn();
        public delegate void WithParaNoReturn(string name,int id);
        public delegate MyDelegate WithParaWithReturn(string name,int id);

        public static void show()
        {
            #region lesson1
                // NoParaNoReturn method=new NoParaNoReturn(ShowSomething);//委托的实例化
                // method.Invoke();//method(ShowSomething)
            #endregion

            NoParaWithReturn noParaWithReturn=new NoParaWithReturn(GetSomething);
            System.Console.WriteLine("getsomething_first_invoke:{0}",noParaWithReturn.Invoke());
            #region test2
            // System.Console.WriteLine("getsomething_second_invoke:{0}",noParaWithReturn());
            #endregion

            #region lesson2
            //多播委托
            noParaWithReturn+=GetSomething;
            noParaWithReturn+=GetSomething;
            noParaWithReturn+=GetSomething;
            noParaWithReturn+=GetSomething;

            noParaWithReturn-=GetSomething;
            #endregion
        }
        #region lesson1
        // public static void ShowSomething()
        // {
        //     System.Console.WriteLine("method.Showsomething");
        // }
        #endregion

        public static int GetSomething()
        {
            #region test2
                // System.Console.WriteLine("method.GetSomething");
                // return System.DateTime.Now.Millisecond;
            #endregion
            System.Console.WriteLine("method.GetSomething");
            Thread.Sleep(1000);
            return 11;
        }
    }
}