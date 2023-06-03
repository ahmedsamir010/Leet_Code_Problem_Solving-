// Author : Ahmed Samir 
// Link Problem : https://leetcode.com/problems/valid-parentheses/

public class Solution {
  public bool IsValid(string s)
{
    Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
    {
        { '(', ')' },
        { '{', '}' },
        { '[', ']' }
    };

    Stack<char> stack = new Stack<char>();

    foreach (char c in s)
    {
        if (bracketPairs.ContainsKey(c))
        {
            stack.Push(c);
        }
        else if (bracketPairs.ContainsValue(c))
        {
            if (stack.Count == 0 || bracketPairs[stack.Pop()] != c)
            {
                return false;
            }
        }
    }

    return stack.Count == 0;
}

}
