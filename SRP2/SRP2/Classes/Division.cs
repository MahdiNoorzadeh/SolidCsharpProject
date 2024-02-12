using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP2.Classes
{
    public class Division
    {       
        public double Divide(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0 || firstNumber == 0)
            {
                throw new ArgumentException("Division by zero is not allowed!");
            }

            return (double)firstNumber / secondNumber;
        }

    }
}
