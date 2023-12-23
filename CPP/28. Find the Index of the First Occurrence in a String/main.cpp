class Solution {
public:
    int strStr(string haystack, string needle) {
        int h_len = haystack.length();
        int n_len = needle.length();

        if (n_len == 0) {
            return 0; 
        }

        for (int i = 0; i <= h_len - n_len; ++i) {
            if (haystack.substr(i, n_len) == needle) {
                return i;
            }
        }

        return -1; 
    }
};
