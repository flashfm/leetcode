// Copyright (c) 2020 Alexey Filatov
// 131 - Palindrome Partitioning (https://leetcode.com/problems/palindrome-partitioning)
// Date solved: 2/8/2020 7:52:04 PM +00:00
// Memory: 34 MB
// Runtime: 272 ms


public class Solution {
    private List<IList<string>> result;
    private HashSet<string> allResults = new HashSet<string>();
    public IList<IList<string>> Partition(string s) {
        
        result = new List<IList<string>>();
        
        // 1. split by letters
        
        // 2. find all same pairs of letters having
        // a) nothing between them
        // b) 1 letter between them
        // c) palyndrome between them (i.e. 2+ leters)
        // 3. make a new subpalyndrom
        
        // 4. each such pair -> add to answer, go to 2 again
        
        var arr = s.Select(c => c.ToString()).ToList();
        result.Add(arr);
        Merge(arr);
        return result;
    }
    
    private bool AddResult(List<string> arr)
    {
        var s = string.Join("|", arr);
        if (allResults.Contains(s)) return false;
        allResults.Add(s);
        return true;
    }
    
    private void Merge(List<string> arr)
    {
        for(var i=0;i<arr.Count-1;i++) {
            if (arr[i]==arr[i+1]) {
                var n = new List<string>();
                for(var j=0;j<arr.Count;j++) if (j==i) { n.Add(arr[i]+arr[i+1]);j++; } else n.Add(arr[j]);
                if (AddResult(n)) {
                    result.Add(n);
                    Merge(n);
                }
            }
            if (i<arr.Count-2 && arr[i]==arr[i+2]) {
                var n = new List<string>();
                for(var j=0;j<arr.Count;j++) if (j==i) { n.Add(arr[i]+arr[i+1]+arr[i+2]);j+=2; } else n.Add(arr[j]);
                if (AddResult(n)) {
                    result.Add(n);
                    Merge(n);
                }
            }
        }
    }
}
