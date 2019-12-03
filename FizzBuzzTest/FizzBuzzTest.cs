using System.Collections.Generic;
using System.Security.Policy;
using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzzTest
{
    //给你一个整数n. 从 1 到 n 按照下面的规则打印每个数：
    //如果这个数被3整除，打印fizz.
    //如果这个数被5整除，打印buzz. 
    //如果这个数能同时被3和5整除，打印fizz buzz.
    //比如 n = 15, 返回一个字符串数组：
    //[
    //"1", "2", "fizz",
    //"4", "buzz", "fizz",
    //"7", "8", "fizz",
    //"buzz", "11", "fizz",
    //"13", "14", "fizz buzz"
    //]


    // 1 -> ["1"]
    // 2 -> ["1", "2"]
    // 3 -> ["1", "2", "fizz"]
    // 4 -> ["1", "2", "fizz", 4]
    // 5 -> ["1", "2", "fizz", 4, "buzz"]
    // 15 -> [ "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizz buzz"]

    [TestFixture]
    public class FizzBuzzTest
    {
        [TestCase(1, new string[] {"1"})]
        [TestCase(2, new string[] {"1", "2"})]
        [TestCase(3, new string[] {"1", "2", "fizz"})]
        [TestCase(4, new string[] {"1", "2", "fizz", "4"})]
        [TestCase(5, new string[] {"1", "2", "fizz", "4", "buzz"})]
        [TestCase(15, new string[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizz buzz" })]
        public void Input2_ExceptedResult_12(int number, string[] excepted)
        {
            var fb = new FizzBuzz.FizzBuzz();
            string[] result = fb.Resolve(number);
            Assert.AreEqual(excepted, result);
        }
    }


}
