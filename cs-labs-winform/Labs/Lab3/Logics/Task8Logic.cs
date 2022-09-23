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
        public int Calculate_with_Fact(int n)
        {
            int result = Factorial(n);
            int buffer = result;

            for (int i = n; i > 1; i--) 
            {
                result += buffer / i;
                buffer /= i;
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
