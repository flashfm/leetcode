// Palindrome Partitioning
// https://leetcode.com/problems/palindrome-partitioning
// Date solved: 02/08/2020 20:32:14 +00:00

public class Solution {
    private List<IList<string>> result = new List<IList<string>>();
    public IList<IList<string>> Partition(string s) {
        if (s==null || s.Length==0) return result;
        var curList = new List<string>();
        Backtrack(s, 0, curList);
        return result;
    }
    
    private void Backtrack(string s, int start, List<string> curList)
    {
        if (start==s.Length) {
            result.Add(curList.ToArray());
            return;
        }       
        for(var i=start;i<s.Length;i++) {
            if (IsPalindrome(s, start, i)) {
                var pal = s.Substring(start, i-start+1);
                curList.Add(pal);
                Backtrack(s, i+1, curList);
                curList.RemoveAt(curList.Count-1);
            }            
        }        
    }
    
    private bool IsPalindrome(string s, int l, int r)
    {
        while(l<=r) {
            if (s[l]!=s[r]) return false;
            l++;
            r--;
        }
        return true;
    }
}
