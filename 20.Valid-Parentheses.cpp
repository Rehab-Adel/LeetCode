class Solution {
public:
    bool isValid(std::string s) {
        std::stack<char> st;

        for (char c : s) {
            if (c == '(' || c == '[' || c == '{') {
                st.push(c);
            } else {
                if (st.empty()) {
                    return false; 
                }

                char openBracket = st.top();
                st.pop();

                if ((c == ')' && openBracket != '(') ||
                    (c == ']' && openBracket != '[') ||
                    (c == '}' && openBracket != '{')) {
                    return false; 
                }
            }
        }

        return st.empty(); 
    }
};
