
using System.Collections.Generic;
using System.Xml.XPath;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public List<string> Resolve(int i)
        {
            var result = new List<string>();
            for (int value = 1; value <= i; value++)
            {
                var t = value.ToString();
                if (value % 3 == 0)
                {
                    t = value % 5 == 0 ? "fizz buzz" : "fizz";
                }
                else if (value % 5 == 0)
                {
                    t = "buzz";
                }
                result.Add(t);
            }
            return result;
        }
    }


}
