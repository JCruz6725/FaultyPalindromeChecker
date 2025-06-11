# FaultyPalindromeChecker

## Debugging Challenge: Faulty Palindrome Checker (C#)
### Submission Rules
1. Modify only the provided function
 - Only edit code within the IsPalindrome method
 - Do NOT change method signature (public static bool IsPalindrome(string s))
2. Allowed Fixes
 - Add/remove character handling logic
 - Modify condition checks
 - Add new variables
 - **Forbidden**: Complete rewrites, AI-generated code, or external libraries beyond System.Text.RegularExpressions
3.  Validation Requirement
Solution MUST pass all 5 test cases:
```Text
("A man, a plan, a canal: Panama") -> true
("racecar!") -> true
("empty") -> false
("a") -> true
("") -> true
```