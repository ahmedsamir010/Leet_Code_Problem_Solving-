//Author : Ahmed Samir
//https://leetcode.com/problems/palindrome-number/
public class Solution
{
    public bool IsPalindrome(int x)
    {
        string str = x.ToString();
        string reverse = new string(str.Reverse().ToArray());

        return reverse.Equals(str);


    }
}
