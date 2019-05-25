using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSection
{
    class Program
    {
        static float n1 = 432, n2 = 543;
        private static void Main(string[] args)
        {
            var addition = Add();
            var subtraction = Subtract();
            var multiply = Multiply();
            var division = Divide();

            Console.WriteLine(addition);
            Console.WriteLine(subtraction);
            Console.WriteLine(multiply);
            Console.WriteLine(division);

            Console.ReadLine();
        }

        // Add 2 values
        private static float Add()
        {
            float result;
            result = n1 + n2;

            return result;
        }

        // Subtract 2 values
        private static float Subtract()
        {
            return n1 - n2;
        }

        // Multiply 2 values
        private static float Multiply()
        {
            return n1 * n2;
        }

        // Divide 2 values
        private static float Divide()
        {
            return n1 / n2;
        }
    }
}
