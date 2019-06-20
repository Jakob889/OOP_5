using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLtoC
{
    public class Number
    {
        private double n;

        public Number(double number)
        {
            n = number;
        }

        public double GetNumber()
        {
            return n;
        }
    }
}
