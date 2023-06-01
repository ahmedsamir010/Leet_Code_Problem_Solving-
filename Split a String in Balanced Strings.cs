
//Author : Ahmed Samir
//Link Problem : https://leetcode.com/problems/split-a-string-in-balanced-stri
public class Solution
{
    public int BalancedStringSplit(string s)
    {
        int l = 0, r = 0, counter = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'R')
            {
                r++;
            }
            else
            {
                l++;
            }

            if (l == r) counter++;

        }
        return counter;

    }
}
