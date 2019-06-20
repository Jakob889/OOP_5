using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLtoC
{
    public class Master:ICanCreateSum
    {
        private List<Number> numbers = new List<Number>();

        public void AddNumber(Number number)
        {
            numbers.Add(number);
        }

        public int CreateSum()
        {
            var sum = 0d;

            foreach (var number in numbers)
            {
                sum += number.GetNumber();
            }

            return (int)sum;
        }
    }
}
