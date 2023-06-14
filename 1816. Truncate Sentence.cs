// Author : Ahmed Samir
// Link Problem : https://leetcode.com/problems/truncate-sentence
public class Solution {
    public string TruncateSentence(string s, int k) {
           string[] words = s.Split(' ');
    string truncateString = string.Join(' ', words.Take(k));
    return truncateString;  
 
    }
}
