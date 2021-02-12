using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "Sezer");
            myDictionary.Add(2, "Celal");
            myDictionary.Add(3, "Bekir");
            myDictionary.Add(3, "Metin ");

            myDictionary.ToList();
        }
    }
}
