// See: https://leetcode.com/problems/palindrome-number/description/

// Example 1:
//
// Input: x = 121
// Output: true
// Explanation: 121 reads as 121 from left to right and from right to left.

// Example 2:
//
// Input: x = -121
// Output: false
// Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

// Example 3:
//
// Input: x = 10
// Output: false
// Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

public class Program
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        
        if (x < 10) return true;

        if (x % 10 == 0) return false;
        
        int reversedNumber = 0;

        while (x > reversedNumber)
        {
            int digit = x % 10;
            reversedNumber = reversedNumber * 10 + digit;
            x = x / 10;
        }
        
        return x == reversedNumber || x == reversedNumber / 10;
    }
    
    public static void Main()
    {
        var solution = new Program();
        
        Console.WriteLine($"121: {solution.IsPalindrome(121)}");      // true
        Console.WriteLine($"-121: {solution.IsPalindrome(-121)}");    // false
        Console.WriteLine($"10: {solution.IsPalindrome(10)}");        // false
        Console.WriteLine($"12321: {solution.IsPalindrome(12321)}");  // true
    }
}