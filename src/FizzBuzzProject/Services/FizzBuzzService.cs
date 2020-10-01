using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzProject.Services
{
    public static class FizzBuzzService
    {
        public static void ExecuteFizzBuzz(IList<string> result, int length = 100)
        {
            for (int i = 1; i <= length; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                    continue;
                }
                if (i % 3 == 0)
                {
                    result.Add("Fizz");
                    continue;
                }
                if (i % 5 == 0)
                {
                    result.Add("Buzz");
                    continue;
                }

                result.Add(Convert.ToString(i));
            }
        }
    }
}
