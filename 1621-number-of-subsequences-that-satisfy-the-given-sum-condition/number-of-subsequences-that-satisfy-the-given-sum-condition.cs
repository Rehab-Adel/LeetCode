public class Solution {
    private const int MOD = 1000000007;
    public int NumSubseq(int[] nums, int target) {
        int n = nums.Length;
        Array.Sort(nums);
        
        int[] pow = new int[n];
        pow[0] = 1;
        for (int i = 1; i < n; i++) {
            pow[i] = (2 * pow[i - 1]) % MOD;
        }
        int result = 0;
        int left = 0, right = n - 1;
        while (left <= right) {
            if (nums[left] + nums[right] <= target) {
                result = (result + pow[right - left]) % MOD;
                left++;
            } else {
                right--;
            }
        }
        return result;
    }
}