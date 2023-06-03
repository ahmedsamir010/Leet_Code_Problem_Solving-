// Author : Ahmed Samir 
// Link Problem :https://leetcode.com/problems/longest-substring-without-repeating-characters/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
             int maxLength = 0;
            int left = 0;
            int right = 0;
            HashSet<char> subStringChars = new HashSet<char>();

            while(right < s.Length)
            {
                if (!subStringChars.Contains(s[right]))
                {
                    subStringChars.Add(s[right]);
                    maxLength=Math.Max(maxLength,subStringChars.Count());
                                        right++;
                }
                else
                {
                    subStringChars.Remove(s[left]);
                    left++;
                }

            }

            return maxLength;
    }
}
