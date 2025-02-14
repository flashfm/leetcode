// Copyright (c) 2024 Alexey Filatov
// 394 - Decode String (https://leetcode.com/problems/decode-string)
// Date solved: 10/24/2024 10:46:34 PM +00:00
// Memory: 38.4 MB
// Runtime: 0 ms


public class Solution {
    public string DecodeString(string s) {
        var (result, _) = Decode(s, 0);
        return result;
    }

    private (string, int) Decode(string s, int start)
    {
        var sb = new StringBuilder();
        var repeat = 0;
        var i = start;
        while(i<s.Length) {
            var c = s[i++];
            if (c>='0' && c<='9') {
                repeat = repeat*10 + (c-'0');
            }
            else if (c==']') {
                break;
            }
            else if (c=='[') {
                var (decoded, next) = Decode(s, i);
                i = next;
                for(var j=0; j<repeat; j++) {
                    sb.Append(decoded);
                }
                repeat = 0;
            }
            else {
                sb.Append(c);
                repeat = 0;
            }
        }

        return (sb.ToString(), i);
    }
}
