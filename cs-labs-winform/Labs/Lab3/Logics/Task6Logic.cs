using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Math;

namespace CSharpLabs.Lab3.Logics
{
    public class Task6Logic : object, IEnumerable<KeyValuePair<int, double>>
    {
        private Dictionary<int, double> calculated_values = new();

        public int ValuesCount { get => this.calculated_values.Count; }
        public int ValueRoundUp { get; set; } = 1;
        public double this[int x] { get => this.calculated_values[x]; }

        public Task6Logic(int left, int right)
        {
            for (int i = left; i <= right; i++) this.calculated_values.Add(i, this.CalculateFunction(i));
        }
        public Task6Logic() : this(default, default) { }

        private double CalculateFunction(double x) 
            => Round((2 * (Pow(x, 2) + 3) / (Pow(x, 2) - 2 * x + 5)) - 1.5, this.ValueRoundUp);

        public double GetSummary()
        {
            System.Double result = default;
            foreach (var value in this.calculated_values) result += value.Value;

            return Round(result, this.ValueRoundUp);
        }

        public IEnumerator<KeyValuePair<int, double>> GetEnumerator() 
            => this.calculated_values.GetEnumerator();
  
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
