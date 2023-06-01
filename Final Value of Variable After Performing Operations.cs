// Link Problem : https://leetcode.com/problems/final-value-of-variable-after-performing-operations
// Author : Ahmed Samir
public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
                   int result = 0;

            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i] == "X++" || operations[i] == "++X")
                    result++;
                else result--;

            }

            return result; 
    }
}
