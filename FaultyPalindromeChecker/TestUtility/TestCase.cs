namespace FaultyPalindromeChecker.TestUtility {
    public class TestCase {
        public required string Palindrome { get; set; }
        public required bool Expected { get; set; }
        public bool? Results { get; set; } = null;
        public Exception? error { get; set; } = null;
    }
}
