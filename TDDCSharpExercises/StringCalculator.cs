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
        private static List<char> delimiters = new List<char> { ',', '\n' };

        public static int Run(string input)
        {
            input = ExtractDelimitorFrom(input);
            if (input.Length == 0) return 0;
            if (delimiters.Contains(input.Last())) throw new SeparatorAtEndException();
            if (input.Length == 1) return int.Parse(input);

            var values = input.Split(delimiters.ToArray());
            return values.Aggregate(0, (sum, next) => sum += int.Parse(next));
        }

        private static string ExtractDelimitorFrom(string input) 
        {
            if (!input.StartsWith("//")) return input;
            delimiters.Add(input[2]);
            return input.Substring(3);
        }

        public class SeparatorAtEndException : Exception
        {
        }
    }
}
