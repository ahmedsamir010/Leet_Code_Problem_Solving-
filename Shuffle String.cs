// Author : Ahmed Samir
//Link Problem : https://leetcode.com/problems/shuffle-string/
public class Solution {
    public string RestoreString(string s, int[] indices) {
 char[] res = new char[s.Length];

            for (int i = 0; i <s.Length; i++)
            {
                res[indices[i]] = s[i];
            }

            return new string(res);
    }
}
