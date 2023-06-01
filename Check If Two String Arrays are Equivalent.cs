//Author : Ahmed Samir
//Link Problem : https://leetcode.com/problems/palindrome-number/
public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
           var c1 = "";
            var c2="";
            for (int i = 0; i < word1.Length; i++)
            {
                c1 += word1[i];
            }
            for (int i = 0; i < word2.Length; i++)
            {
                c2 += word2[i];
            }




            return c1==c2;

    }
}
