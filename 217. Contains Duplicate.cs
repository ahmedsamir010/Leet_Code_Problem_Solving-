// Auhtor : Ahmed Samir
// Link Problem : https://leetcode.com/problems/contains-duplicate
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
         HashSet<int> numbers = new HashSet<int>();
            numbers.UnionWith(nums);
            int HashsetLength= numbers.Count();
                      return !(HashsetLength == nums.Length);

    }
}
