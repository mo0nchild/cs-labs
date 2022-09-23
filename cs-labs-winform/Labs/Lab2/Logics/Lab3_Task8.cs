using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Labs.Lab2.Logics
{
        class Calculate_Task8
        {
            public int Calculate_with_Fact(int n)
            {
                int result = (int)default;

                for (int i = 0; i < n; i++) result += Factorial(i);

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
