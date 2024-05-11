public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }

        int n = nums.Length;
        int index = 0;
        int count = 1;

        for (int i = 1; i < n; i++) {
            if (nums[i] == nums[index]) {
                if (count < 2) {
                    index++;
                    nums[index] = nums[i];
                    count++;
                }
            } else {
                index++;
                nums[index] = nums[i];
                count = 1;
            }
        }

        return index + 1;
    }
}
