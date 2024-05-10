public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        Dictionary<int, int> nextGreaterMap = new Dictionary<int, int>();
        Stack<int> stack = new Stack<int>();
        foreach (int num in nums2) {
            while (stack.Count > 0 && stack.Peek() < num) {
                nextGreaterMap[stack.Pop()] = num;
            }
            stack.Push(num);
        }
        int[] result = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++) {
            result[i] = nextGreaterMap.ContainsKey(nums1[i]) ? nextGreaterMap[nums1[i]] : -1;
        }
        
        return result;
    }
}
