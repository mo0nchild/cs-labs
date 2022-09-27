using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Labs.Lab3.Logics
{
    internal class Task5Logic
    {
        
        public double calculate_row(float EPS)
        {
            double result = default;
            
            for (int i = 1; true; i++)
            {
                double current_row = 1.0 / Math.Sqrt(Factorial(i));
                if (current_row < EPS) return result;
                result += current_row;
            }
               
        }
        private int Factorial(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }


    }
}
