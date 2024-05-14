public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        IList<int> duplicates = new List<int>();
        
        foreach (int num in nums) {
            int index = Math.Abs(num) - 1;
            
            if (nums[index] < 0) {
                duplicates.Add(index + 1);
            } else {
                nums[index] = -nums[index];
            }
        }
        return duplicates;
    }
}