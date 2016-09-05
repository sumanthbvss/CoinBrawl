class Solution {
public:
    char findTheDifference(string s, string t) {
        sort(s.begin(), s.end());
        sort(t.begin(), t.end());
        int pos = 0;
        while(pos < s.size() && pos < t.size()){
            if(s[pos] == t[pos])
                pos++;
            else
                break;
        }
        return t[pos];
    }
};
