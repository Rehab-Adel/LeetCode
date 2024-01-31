public class Solution {
    public bool ValidPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while (left < right) {
            if (s[left] != s[right]) {
                return IsPalindrome(s, left + 1, right) || IsPalindrome(s, left, right - 1);
            }
            left++;
            right--;
        }
        return true;
    }

    private bool IsPalindrome(string s, int start, int end) {
        while (start < end) {
            if (s[start] != s[end]) {
                return false;
            }

            start++;
            end--;
        }

        return true;
    }
}
