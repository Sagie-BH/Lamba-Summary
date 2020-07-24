using System;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService mathService = new MathService();
            mathService.MathPerformed += OnMathPerformed;

            mathService.MultiplyNumbers(15.6, 77.8);
        }

        private static void OnMathPerformed(object sender, MathPerformedEventArgs e)
        {
            Console.WriteLine($"Result is : {e.Result}");
        }
    }
}
