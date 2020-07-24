using System;
using System.Collections.Generic;

namespace YieldReturnPrac
{
    class YieldClass
    {
        static Random rand = new Random();
        static public IEnumerable<int> GetRandomNumbers(int count)
        {

            for (int i = 0; i < count; i++)
                yield return rand.Next();
        }
    }
    //What the compilier does
    //Same Result:
    class NoYieldClass
    {
        static Random rand = new Random();

        List<int> ints = new List<int>();
        public List<int> tempList()
        {
            ints.Add(rand.Next());
            return ints;
        }
    }

    class Program
    { 
        static void Main(string[] args)
        {
            foreach (int num in YieldClass.GetRandomNumbers(10))
                Console.WriteLine(num);
        }
    }
}
