using System;


namespace GenericCollectionsMyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,int> myDictionary = new MyDictionary<int,int>();
            myDictionary.Add(1, 1);
            myDictionary.Add(1, 2);
            myDictionary.PrintAll();

            MyDictionary<string,bool> myDictionary1 = new MyDictionary<string, bool>();
            myDictionary1.Add("Ankara", true);
            myDictionary1.Add("İstanbul", false);
            myDictionary1.PrintAll();

        }
    }
}
