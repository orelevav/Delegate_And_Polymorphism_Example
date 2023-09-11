using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDelegate
{
    public class Calculator
    {
        public delegate int Calculate (int input);
        public delegate int Calculate2(int input,int input2);

        public int Execute(Calculate calculate , int input)
        {
            return calculate(input);
            //return calculate.Invoke(input);
        }
        public int Execute(Calculate2 calculate, int input, int input2)
        {
            return calculate(input,input2);
        }
    }
}
