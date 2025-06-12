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
                //Skip non-letter characters
                while(!char.IsLetter(s[left])) {
                    left++;
                }
                while(!char.IsLetter(s[right])) {
                    right--;
                } 
                
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
