// Author : Ahmed Samir
// Link Problem : https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number
public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        
            int[] count = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j] && i != j) count[i]++;
                }

            }

            return count;

    }
}
