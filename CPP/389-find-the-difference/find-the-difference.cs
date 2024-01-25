public class Solution {
    public char FindTheDifference(string s, string t) {
        int charCode = 0;
        foreach (char c in s + t) {
            charCode ^= c;
        }
        return (char)charCode;
    }
}
