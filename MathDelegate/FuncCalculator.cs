using System;
namespace MathDelegate
{
    class FuncCalculator
    {
        public int Execute(Func<int ,int> calculate, int input)
        {
            return calculate(input);
            //return calculate.Invoke(input);
        }
        
        public int Execute(Func<int, int, int> calculate, int input, int input2)
        {
            return calculate(input,input2);
            //return calculate.Invoke(input);
        }
    }
}
