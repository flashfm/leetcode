// Copyright (c) 2020 Alexey Filatov
// 76 - Minimum Window Substring (https://leetcode.com/problems/minimum-window-substring)
// Date solved: 4/22/2020 7:25:34 AM +00:00
// Memory: 25.5 MB
// Runtime: 276 ms


    public class Solution {
        private Dictionary<char, int> orig = new Dictionary<char, int>();
        private Dictionary<char, int> current = new Dictionary<char, int>();
    
        void Unuse(char c) {
            if (!current.TryGetValue(c, out var count)) {
                return;
            }
            count--;
            if (count == 0)
                current.Remove(c);
            else {
                current[c] = count;
            }
        }

        void Use(char c)
        {
            current.TryGetValue(c, out var count);
            current[c] = count+1;
        }

        bool TFound() {
            foreach (var pair in orig) {
                current.TryGetValue(pair.Key, out var count);
                if (count < pair.Value) return false;
            }

            return true;
        }
        
        public string MinWindow(string s, string t) {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return "";

            foreach (var c in t) {
                orig.TryGetValue(c, out var count);
                orig[c] = count+1;
            }
            
            var n = s.Length;
            var l = 0;
            var r = 0;
            var minLen = int.MaxValue;
            int minl = 0;
            // left does not move
            // then right stops when we find last letter
            // then left moves to decrease substring while it can,
            // then it moves a bit more (looses a letter) and we continue
            while(l<n && r<n) {
                var found = false;
                while(r<n) {
                    Use(s[r++]);
                    if (TFound()) {
                        found = true;
                        break;
                    }
                }
                if (!found) {
                    break;
                }
                while(l<r) {           
                    var len = r-l+1;
                    if (len<minLen) {
                        minLen = len;
                        minl = l;
                    }
                    Unuse(s[l++]);
                    if (!TFound()) {
                        break;
                    }
                }
            }
        
            return minLen==int.MaxValue ? "" : s.Substring(minl, minLen-1);
        }
    }

