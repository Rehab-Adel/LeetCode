class Solution {
public:
    string addBinary(string a, string b) {
        string result = "";
        int carry = 0;

        int i = a.length() - 1;
        int j = b.length() - 1;

        while (i >= 0 || j >= 0 || carry > 0) {
            int bitA = (i >= 0) ? a[i--] - '0' : 0;
            int bitB = (j >= 0) ? b[j--] - '0' : 0;

            int sum = bitA + bitB + carry;
            carry = sum / 2;

            result = to_string(sum % 2) + result;
        }
        return result;
    }
};
