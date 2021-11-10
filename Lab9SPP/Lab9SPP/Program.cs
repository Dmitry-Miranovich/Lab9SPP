using System;
using static System.Console;

namespace Lab9SPP
{
    class Program
    {
        static void Main()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("Hi");
            list.Add("Pleasure to meet you!");
            list.Add("Im tom");
            
            foreach(string s in list)
            {
                WriteLine(s);
            }
        }
    }
}
