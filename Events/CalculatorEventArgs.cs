using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class CalculatorEventArgs
    {
        public string Name { get; set; }
        public CalculatorEventArgs()
        {

        }
        public CalculatorEventArgs(string name)
        {
            Name = name;
        }
    }
}
