using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP2.Classes
{
    
    public class ReadInput
    {
        public (int, int) ReadNumbers()
        {
            Console.WriteLine("enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter secound number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            return (firstNumber, secondNumber);
        }
    }
}
