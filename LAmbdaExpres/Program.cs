using System;
using System.Collections.Generic;

namespace LambdaExpres
{
    class Program
    {
        /// <summary>
        /// Lambda are used as Actions, Funcs and predicates that make the delegate code simpler,
        /// And for creating expressions list
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Yakov");
            names.Add("Yizhak");
            names.Add("Avi");

            string result = names.Find
                (
                delegate (string name)
                {
                    return name.Equals("Avi");
                }
                );

         
            // Same thing as above
            // We're droping the delegate and the temporary string
            string result2 = names.Find(name => name.Equals("Avi"));
        }
    }
}
