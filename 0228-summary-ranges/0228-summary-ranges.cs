public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        IList<string> result = new List<string>();
        
        if (nums.Length == 0) {
            return result;
        }
        
        int start = nums[0];
        
        for (int i = 1; i <= nums.Length; i++) {
            if (i == nums.Length || nums[i] != nums[i - 1] + 1) {
                if (start == nums[i - 1]) {
                    result.Add(start.ToString());
                } else {
                    result.Add($"{start}->{nums[i - 1]}");
                }
                if (i < nums.Length) {
                    start = nums[i];
                }
            }
        }
        
        return result;
    }
}
