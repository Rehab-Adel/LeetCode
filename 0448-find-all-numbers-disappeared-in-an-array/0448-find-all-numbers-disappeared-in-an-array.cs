using System;
using System.Collections.Generic;

public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        IList<int> result = new List<int>();
        foreach (int num in nums) {
            int index = Math.Abs(num) - 1;
            
            if (nums[index] > 0) {
                nums[index] = -nums[index];
            }
        }
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > 0) {
                result.Add(i + 1);
            }
        }
        return result;
    }
}
