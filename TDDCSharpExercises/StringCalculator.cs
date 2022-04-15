using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCSharpExercises
{
    // https://tddmanifesto.com/exercises/
    public class StringCalculator
    {
        public static int Run(string inputValues)
        {
            if (inputValues.Length == 0) return 0;
            if (inputValues.Length == 1) return int.Parse(inputValues);
            var values = inputValues.Split(',');
            return values.Aggregate(0, (sum, next) => sum += int.Parse(next));
        }
    }
}
