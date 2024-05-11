class Solution {
public:
    bool wordPattern(string pattern, string s) {
        unordered_map<char, string> patternToWord;
        unordered_map<string, char> wordToPattern;
        
        istringstream ss(s);
        string word;
        
        for (char c : pattern) {
            if (!(ss >> word)) {
                return false;
            }
            
            if (patternToWord.find(c) == patternToWord.end() && wordToPattern.find(word) == wordToPattern.end()) {
                patternToWord[c] = word;
                wordToPattern[word] = c;
            } else {
                if (patternToWord[c] != word || wordToPattern[word] != c) {
                    return false;
                }
            }
        }
        
        return !(ss >> word); // More words than pattern characters
    }
};
