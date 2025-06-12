namespace FaultyPalindromeChecker {
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string s)
        {        
            s = s.Trim().Replace(" ", "").ToLower();
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
