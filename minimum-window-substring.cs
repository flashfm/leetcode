// Minimum Window Substring
// https://leetcode.com/problems/minimum-window-substring
// Date solved: 04/22/2020 07:54:11 +00:00

    public class Solution {
        public string MinWindow(string s, string t) {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return "";
                        
            var current = new Dictionary<char, int>();
            var orig = new Dictionary<char, int>();
            foreach (var c in t) {
                orig.TryGetValue(c, out var count);
                orig[c] = count+1;
            }
                        
            var n = s.Length;
            var l = 0;
            var r = 0;
            var minLen = int.MaxValue;
            int minl = 0;
            var uniqueCharsFound = 0;
            var needCharsFound = orig.Count;
            
            var filteredS = new List<(char Char, int Index)>();
            for(var i=0;i<n;i++) {
                if (orig.ContainsKey(s[i])) {
                    filteredS.Add((s[i], i));
                }
            }

            
            // left does not move
            // then right stops when we find last letter
            // then left moves to decrease substring while it can,
            // then it moves a bit more (looses a letter) and we continue
            while(r<filteredS.Count) {
                
                var c = filteredS[r].Char;
                
                current.TryGetValue(c, out var count);
                current[c] = count+1;
                
                if (orig.ContainsKey(c) && current[c]==orig[c]) {
                    uniqueCharsFound++;
                }
                
                while(l<=r && uniqueCharsFound==needCharsFound) {           
                    var len = filteredS[r].Index-filteredS[l].Index+1;
                    if (len<minLen) {
                        minLen = len;
                        minl = filteredS[l].Index;
                    }
                    
                    c = filteredS[l].Char;
                    current[c] = current[c] - 1;
                    
                    if (orig.ContainsKey(c) && current[c] < orig[c]) {
                        uniqueCharsFound--;
                    }
                    
                    l++;
                }
                r++;
            }
        
            return minLen==int.MaxValue ? "" : s.Substring(minl, minLen);
        }
    }

