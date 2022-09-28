using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Lab3.Logics
{
    class Task8Logic
    {
        public int Calculate(int n)
        {
            int result = default;
            int buffer = 1;

            for (int i = 1; i <= n; i++)
            {
                buffer *= i;
                result += buffer;
            }

            return result;
        }

        private int Factorial(int value)
        {
            if (value == 0) return 0;
            if (value == 1) return 1;

            return value * Factorial(value - 1);
        }
    }
}
