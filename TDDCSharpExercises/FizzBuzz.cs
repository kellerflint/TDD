using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCSharpExercises
{
    public class FizzBuzz
    {
        public static string Run(int number)
        {
            string output = "";
            if (number % 3 == 0) output += "Fizz";
            if (number % 5 == 0) output += "Buzz";
            return output == "" ? number.ToString() : output;
        }

        // LeetCode solution
        public static IList<string> FizzBuzzLeet(int n)
        {
            var list = new List<string>();
            for (var i = 1; i <= n; i++) list.Add(GetFizzBuzzValue(i));
            return list;
        }

        private static string GetFizzBuzzValue(int i)
        {
            string output = "";
            if (i % 3 == 0) output += "Fizz";
            if (i % 5 == 0) output += "Buzz";
            return output == "" ? i.ToString() : output;
        }
    }
}