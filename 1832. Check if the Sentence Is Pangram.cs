// Author : Ahmed 
// Link Problem : https://leetcode.com/problems/check-if-the-sentence-is-pangram
public class Solution {
    public bool CheckIfPangram(string sentence) {
        char[] chars = sentence.ToCharArray();
    HashSet<char> visited = new HashSet<char>();   
    foreach (char c in chars)
    {
        visited.Add(c);
    }
    return visited.Count == 26;
    }
}
