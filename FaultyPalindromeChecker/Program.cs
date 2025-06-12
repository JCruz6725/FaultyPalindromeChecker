using FaultyPalindromeChecker.TestUtility;

namespace FaultyPalindromeChecker {
    internal class Program
    {
        static void Main(string[] args)
        {
            TestCase[] testCases = {
                new(){Palindrome = "A man, a plan, a canal: Panama", Expected =  true },
                new(){Palindrome = "racecar!", Expected =  true },
                new(){Palindrome = "empty", Expected =  false },
                new(){Palindrome = "a", Expected =  true },
                new(){Palindrome = "", Expected =  true },
                new(){Palindrome = "Ma..da?m!", Expected =  true },
            };
            TestRunner.Run(testCases);
            TestRunner.Render(testCases);   
        }
    }
}
