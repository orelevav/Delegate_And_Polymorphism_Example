using System;
using MathDelegate;
namespace Events
{
    public delegate string MyDel(string str);
    class EventProgram
    {
        event MyDel MyEvent;

        public EventProgram()
        {
            //this.MyEvent += new MyDel(this.WelcomeUser);
            MyEvent = WelcomeUser;
        }
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }

        static void Main(string[] args)
        {
            EventProgram obj1 = new EventProgram();
            string result = obj1.MyEvent("Tutorials Point");
            Console.WriteLine(result);

            //Calculator Event Args
            Calculator calculator = new Calculator();
            calculator.Calculate += Calculator_Calculator;
            calculator.RaiseEvent("Test Name");

            Calculator calculator2 = new Calculator();
            calculator2.Calculate += (obj, arg) => Console.WriteLine(arg.Name);
            calculator.RaiseEvent("Test Name2");
            calculator.RaiseEvent("Test Name3");
            Console.ReadLine();

        }
        private static void Calculator_Calculator(object arg1, CalculatorEventArgs arg2)
        {
            Console.WriteLine(arg2.Name);
        }
    }
}
