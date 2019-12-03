
using System.Collections.Generic;
using System.Globalization;
using System.Xml.XPath;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string[] Resolve(int number)
        {
            List<string> result = new List<string>();
            for (int i = 1; i <= number; i++)
            {
                var t = i.ToString();
                if (i % 3 == 0)
                {
                    t = i % 5 == 0 ? "fizz buzz" : "fizz";
                }
                else if (i % 5 == 0)
                {
                    t = "buzz";
                }
                result.Add(t);
            }
            return result.ToArray();
        }
    }


}
