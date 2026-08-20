using System;

namespace Assignment
{
    class ExceptionPropagation
    {
        public void Method1()
        {
            int number = 10;
            int zero = 0;

            // Exception is created at runtime
            int result = number / zero;
        }

        public void Method2()
        {
            Method1();
        }

        public void Run()
        {
            try
            {
                Method2();
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Handled exception in Main");
            }
        }
    }
}