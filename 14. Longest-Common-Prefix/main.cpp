class Solution {
public:
    string longestCommonPrefix(vector<string>& strs) {
        if (strs.empty()) {
            return ""; // If the input vector is empty, there's no common prefix.
        }

        string commonPrefix = strs[0]; // Initialize the common prefix with the first string.

        for (int i = 1; i < strs.size(); ++i) {
            // Compare the current common prefix with the next string.
            int j = 0;
            while (j < commonPrefix.length() && j < strs[i].length() && commonPrefix[j] == strs[i][j]) {
                ++j;
            }

            commonPrefix = commonPrefix.substr(0, j); // Update the common prefix.

            if (commonPrefix.empty()) {
                return ""; // If the common prefix becomes empty, there's no common prefix.
            }
        }

        return commonPrefix;
    }
};
