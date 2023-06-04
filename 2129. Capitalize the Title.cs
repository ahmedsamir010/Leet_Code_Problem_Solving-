// Author : Ahmed Samir
// Link Problem : https://leetcode.com/problems/capitalize-the-title/description/
public class Solution {
  public string CapitalizeTitle(string title)
{
    string[] words = title.Split(' ');

    for (int i = 0; i < words.Length; i++)
    {
        string word = words[i];
        if (word.Length <= 2)
        {
            words[i] = word.ToLower();
        }
        else
        {
            words[i] = char.ToUpper(word[0]) + word.Substring(1).ToLower();
        }
    }

    return string.Join(" ", words);
}
}
