using System;

namespace Mygeneric
{
    public class People
    {
        public int id{get;set;}
        public int age{get;set;}
        public string name{get;set;}
        public void SayHi()=>System.Console.WriteLine($"{this.name}说，早上好");


    }

    public class Chinese:People
    {
        public string tool{get;set;}
        public string changzheng{get;set;}
    }
}