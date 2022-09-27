using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Lab3.Logics
{
    public class Task7Logic: object
    {
        public int InstalledValue { get; private set; } = default;

        public Task7Logic(int value) 
        {
            if(value <= 0) throw new Exception("Неверное значение");
            this.InstalledValue = value;
        }

        public int FixErrorOptimazed() 
        {
            int buffer = this.InstalledValue, result = 0, digit_index = 1;
            int lastdigit_value = buffer % 10;

            while (buffer > 0)
            {
                var current_digit = buffer / 10 % 10;
                if (current_digit != 5 && current_digit != 0) 
                {
                    result += (current_digit * (int)Math.Pow(10, digit_index));
                    digit_index++;
                }
                buffer /= 10;
            }

            if (lastdigit_value != 5 && lastdigit_value != 0) result += (lastdigit_value);
            else { result /= 10; }
            return result;
        }

        public int FixError() 
        {
            int result = default(int), digit_index = default(int);
            string value_str = this.InstalledValue.ToString();

            for (int index = value_str.Length - 1; index >= 0; index--)
            {
                var digit_value = (int)char.GetNumericValue(value_str[index]);
                if (digit_value != 5 && digit_value != 0)
                {
                    result += (int)(digit_value * Math.Pow(10, digit_index++));
                }
            }
            return result;
        }
    }
}
