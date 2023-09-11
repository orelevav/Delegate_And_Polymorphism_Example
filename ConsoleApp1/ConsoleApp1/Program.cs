using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegateAppl;

delegate int NumberChanger(int n);
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDelegate testDelegate = new TestDelegate();
            NumberChanger nc1 = new NumberChanger(testDelegate.AddNum);
            NumberChanger nc2 = new NumberChanger(testDelegate.MultNum);
            testDelegate.AddNum(1);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", testDelegate.getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", testDelegate.getNum());
            Console.ReadKey();
        }
    }
}
