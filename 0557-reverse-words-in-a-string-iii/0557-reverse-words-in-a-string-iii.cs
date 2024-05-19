public class Solution {
    public string ReverseWords(string s) {
        string[] words = s.Split(' ');
        
        StringBuilder result = new StringBuilder();
        
        foreach (string word in words) {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new string(charArray);
            
            result.Append(reversedWord + " ");
        }
        if (result.Length > 0) {
            result.Length--;
        }
        return result.ToString();
    }
}