using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzz2
    {
        public string[] Resolve(int number)
        {
            List<string> result = new List<string>();
            for (int i = 1; i <= number; i++)
            {
                var t = i.ToString();
                if (i % 3 == 0 || t.Contains("3"))
                {
                    t = i % 5 == 0 ? "fizz buzz" : "fizz";
                }
                else if (i % 5 == 0 || t.Contains("5"))
                {
                    t = "buzz";
                }
                result.Add(t);
            }
            return result.ToArray();
        }
    }
}
