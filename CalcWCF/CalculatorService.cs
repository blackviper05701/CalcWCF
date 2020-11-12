using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWCF
{
    public class CalculatorService : ICalcutorService
    {
        public double Add(int[] numbers)
        {
            double result = numbers.Sum();
            return result;
        }

        public double Multifly(int[] numbers)
        {
            double result=1.0;
            foreach(int number in numbers)
            {
                result = result * number;
            }
            return result;
        }
    }
}
