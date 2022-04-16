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
    }
}