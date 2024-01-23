class Solution {
public:
    bool isPalindrome(std::string s) {
        std::string cleanStr;
        for (char c : s) {
            if (std::isalnum(c)) {
                cleanStr += std::tolower(c);
            }
        }

        int left = 0, right = cleanStr.length() - 1;
        while (left < right) {
            if (cleanStr[left] != cleanStr[right]) {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
};