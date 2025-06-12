namespace FaultyPalindromeChecker.TestUtility {
    public static class TestRunner {
        public static void Run(IEnumerable<TestCase> testColletion) {
            foreach(TestCase test in testColletion) {
                Run(test);
            }
        }


        public static void Run(TestCase test) {
            try {
                test.Results = PalindromeChecker.IsPalindrome(test.Palindrome);
            }
            catch(Exception ex) {
                test.error = ex;
            }
        }


        public static void Render(IEnumerable<TestCase> testCollection) {
            for(int i = 0; i < testCollection.Count(); i++) {
                Render(testCollection.ElementAt(i), i + 1);
            }
        }


        public static void Render(TestCase test, int itter) {
            Console.WriteLine($"***** * Test {itter} * *****");
            Console.WriteLine($"Palindrome: \"{test.Palindrome}\"");
            Console.WriteLine($"Expected result: {test.Expected}");
            if(test.error is null) {
                Console.WriteLine($"Test results: {test.Results}");
            }

            else {
                Console.WriteLine("Error!");
                Console.WriteLine(test.error.Message);
                Console.WriteLine(test.error.StackTrace);
            }


            Console.WriteLine();
            if(test.IsValid()) {
                Console.WriteLine("\tTest passed!");
            }
            else {
                Console.WriteLine("\tTest failed!");
            }
            Console.WriteLine();
            
            Console.WriteLine("***********************");
            Console.WriteLine();
        }
    }
}
