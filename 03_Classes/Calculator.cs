using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    class Calculator
    {
        // Add 
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public double Add(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        // Subtract

        public int Subtract(int numOne, int numTwo)
        {
            int sum = numOne - numTwo;
            return sum;
        }

        // Multiply

        public int Multiply(int numOne, int numTwo)
        {
            int sum = numOne * numTwo;
            return sum;
        }

        // Divide

        public int Divide(int numOne, int numTwo)
        {
            int sum = numOne / numTwo;
            return sum;
        }

        // Calculate Remainder

        public int Remainder(int numOne, int numTwo)
        {
            int sum = numOne % numTwo;
            return sum;
        }
            
    }
}
