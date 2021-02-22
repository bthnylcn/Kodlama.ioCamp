using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cityList = new MyDictionary<int, string>();

            cityList.Add(33, "Mersin");
            cityList.Add(34, "İstanbul");
            cityList.Add(35, "İzmir");
            cityList.Add(06, "Ankara");
            cityList.Add(01, "Adana");
        }
    }
}
