using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathDelegate;
namespace MathDelegate
{
    public delegate int MathDelegate(int a, int b);
    class Program
    {
        static int square(int input) => (input * input);
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            MathDelegate mathDelegate;
            mathDelegate = calculation.Add;
            Console.WriteLine("Sum of Two Numbers :" + mathDelegate(10, 5));

            mathDelegate = calculation.Sub;
            Console.WriteLine("Substraction of Two Numbers :" + mathDelegate(10, 5));

            //Or using Func instead
            Func<int, int, int> func;
            func = (n1, n2) => (n1 - n2);
            Console.WriteLine("Func: Substraction of Two Numbers = {0}:", func(15, 5));

            func = (n1, n2) => (n1 + n2);
            Console.WriteLine("Func: Add of Two Numbers = {0}:", func(15, 5));

            func =  calculation.Sub;
            Console.WriteLine("Func: Substraction of Two Numbers = {0}:", func(5, 3));

            //Delegate from class
            Calculator calculator = new Calculator();
            //Calculator.Calculate calc = square;
            //var result = calculator.Execute(calc, 5);
            var result = calculator.Execute(square, 5);
            Console.WriteLine("Delegate from class: = {0}:", result);

            //Func from class
            FuncCalculator funcCalculator = new FuncCalculator();
            var Funcresult = funcCalculator.Execute(square, 2);
            Console.WriteLine("Func from class: = {0}:", Funcresult);

            //Lambda fit in most popular!!!
            Funcresult = calculator.Execute((x) => x + x,3);
            Console.WriteLine("Delegate from class: = {0}:", Funcresult);

            Funcresult = funcCalculator.Execute((x) => x + x, 3);
            Console.WriteLine("Func from class: = {0}:", Funcresult);

            Funcresult = funcCalculator.Execute((x,y) => x + y, 3,30);
            Console.WriteLine("Func from class: = {0}:", Funcresult);

            Funcresult = calculator.Execute((a,b) => a + b, 1,10);
            Console.WriteLine("Func3 from class: = {0}:", Funcresult);

            Console.ReadLine();
        }
    }
}
