// Author : Ahmed Samir
// Link Problem : https://leetcode.com/problems/number-of-good-pairs
public class Solution {
    public int NumIdenticalPairs(int[] nums) {
         Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
            int count = 0;

            foreach (int num in nums)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    count += frequencyMap[num];
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            return count;
    }
}
