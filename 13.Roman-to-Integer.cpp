class Solution {
public:
    int romanToInt(string s) {
        int dec = 0;
        int len = s.length();
        for(int i=0; i < len ; i++)
        {
            if(s[i] == 'I')
            {
                if(s[i+1] == 'V')
                {
                    dec += 4;
                    i++;
                }
                else if(s[i+1] == 'X')
                {
                     dec += 9;
                     i++;
                }
                else
                    dec += 1;
            }
            else if(s[i]== 'X')
            {
                if(s[i+1] == 'L')
                {
                    dec += 40;
                    i++;
                }
                else if(s[i+1] == 'C')
                {
                    dec += 90;
                    i++;
                }
                else
                    dec += 10;
            }
            else if(s[i] == 'V')
            {
                dec += 5;
            }
            else if(s[i] == 'L')
                dec += 50;
            else if(s[i] == 'C')
            {
                if(s[i+1]== 'D')
                {
                     dec += 400;
                     i++;
                }
                else if(s[i+1] == 'M')
                {
                    dec += 900;
                    i++;
                }
                else 
                    dec += 100;
            }
            else if(s[i] == 'D')
                dec += 500;
            else if(s[i] == 'M')
                dec += 1000;
        }
        return dec;
    }
};
