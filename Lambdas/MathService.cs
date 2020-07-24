using System;
using System.Timers;

namespace Lambdas
{
    class MathService
    {
        public event EventHandler<MathPerformedEventArgs> MathPerformed;

        public void MultiplyNumbers(double value1, double value2)
        {
            MathPerformed?.Invoke(this, new MathPerformedEventArgs() { Result = value1 * value2 });

            //if (MathPerformed != null)
            //MathPerformed(this, new MathPerformedEventArgs() { Result = value1 * value2 });
        }
    }
}
