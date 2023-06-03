// Author : Ahmed Samir 
// Link Problem : https://leetcode.com/problems/count-items-matching-a-ru
public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
                    int count = 0;
            foreach (var item in items)
            {
                if (ruleKey.ToLower() == "type")
                {
                    if (item[0] == ruleValue)
                    {
                        count++;
                    }
                }
                else if (ruleKey.ToLower() == "color")
                {
                    if (item[1] == ruleValue)
                    {
                        count++;
                    }
                }
                else if (ruleKey.ToLower() == "name")
                {
                    if (item[2] == ruleValue)
                    {
                        count++;
                    }
                }
            }

            return count;
    }
}
