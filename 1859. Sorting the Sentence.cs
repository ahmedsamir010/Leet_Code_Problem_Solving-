// Author : Ahmed Samir
// Link Problem : https://leetcode.com/problems/sorting-the-sentence
public class Solution {
    public string SortSentence(string s) {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        StringBuilder sb = new StringBuilder();

        var result = new List<string>();

        foreach (char ch in s)
        {
            if (char.IsDigit(ch))
            {
                if (!dict.ContainsKey(ch))
                {
                    int i = (int)Char.GetNumericValue(ch);
                    dict[i] = sb.ToString().Trim();
                    sb.Clear();
                }

            }
            else
            {
                sb.Append(ch);
            }
        }

        foreach (KeyValuePair<int, string> data in dict.OrderBy(key => key.Key))
        {
            result.Add(data.Value);
        }

       return String.Join(" ",result);
    }
}
