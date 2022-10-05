using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CSharpLabs.Supports
{
    internal static class ArrayModifier
    {
        public static double[] Split(this double[] array, bool take_right = false) 
        {
            int skip = take_right ? (int)Math.Ceiling(array.Length / 2.0) : 0;
            if (array.Length <= 1) return (!take_right) ? array : new double[] { }; 

            return array.Skip<double>(skip).Take<double>((int)Math.Ceiling(array.Length / 2.0)).ToArray();
        }
    }
}
