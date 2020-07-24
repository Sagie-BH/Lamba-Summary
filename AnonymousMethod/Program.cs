using System;

namespace AnonymousMethod
{
    /// <summary>
    /// Anonymous methods are nameless methods that help build delegates
    /// Used only inside their classes
    /// they have faster performance due to not declaring their name
    /// </summary>
    class Program
    {
        #region Normal method
        //Declaring a delegate that will point to the Add function
        delegate int PointToAddFunction(int num1, int num2);


        //Simple Add Function 
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        #endregion 


        static void Main(string[] args)
        {
            //creating an object to able pointing the delegate to the Add method
            PointToAddFunction pointToAdd = Add;

            Console.WriteLine("Using Add method:");
            Console.WriteLine(pointToAdd(2,3));

            //Creating an object with an anonymous method   
            //Does the same thing as Add function above without declaring a name
            PointToAddFunction pointToAnonymous = delegate (int num1, int num2)
            {
                return num1 + num2;
            };


            Console.WriteLine("Using an anonymous method");
            Console.WriteLine(pointToAnonymous(4,5));
        }

    }
}
