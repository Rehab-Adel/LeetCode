public class Solution {
    public int ThirdMax(int[] nums) {
        HashSet<int> distinctNums = new HashSet<int>(nums);
        
        List<int> sortedNums = distinctNums.ToList();
        sortedNums.Sort((a, b) => b.CompareTo(a));
        
        if (sortedNums.Count >= 3) {
            return sortedNums[2];
        } else {
            return sortedNums[0]; 
        }
    }
}
