using Events;
using System;

namespace MathDelegate
{
    class Calculator
    {
        public event Action<object, CalculatorEventArgs> Calculate;

        public void RaiseEvent(string name)
        {
            //Calculate?.Invoke(this,new CalculatorEventArgs() { Name = name});
            //Calculate?.Invoke(this, new CalculatorEventArgs(name) );
            Calculate(this, new CalculatorEventArgs(name));
        }
            
        public int Execute(Func<int,int> calculate , int input)
        {
            return calculate(input);
            //return calculate.Invoke(input);
        }
    }
}
