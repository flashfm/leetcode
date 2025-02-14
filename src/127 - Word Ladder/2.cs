// Copyright (c) 2020 Alexey Filatov
// 127 - Word Ladder (https://leetcode.com/problems/word-ladder)
// Date solved: 2/8/2020 4:14:48 AM +00:00
// Memory: 60 MB
// Runtime: 604 ms


public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        var n = wordList.Count;
        var mx = new bool[n,n];
        for(var i=0;i<n;i++)
            for(var j=i+1;j<n;j++)
                    if (IsOneLetterDiff(wordList[i], wordList[j])) mx[i,j] = mx[j,i] = true;

        var q = new Queue<int>();
        var len = new int[n];
        var target = -1;
        for(var i=0;i<n;i++) {
            if (wordList[i]==endWord) target = i;
            if (IsOneLetterDiff(beginWord, wordList[i])) {
                q.Enqueue(i);
                len[i] = 2;
            }
        }
        if (target==-1) return 0;
        if (IsOneLetterDiff(beginWord, endWord)) return 2;
        
        while(q.Count>0) {
            var c = q.Dequeue();
            for(var i=0;i<n;i++) {
                if (mx[c, i] && len[i]==0) {
                    if (i==target) return len[c]+1;
                    q.Enqueue(i);
                    len[i] = len[c]+1;
                }
            }            
        }
        
        return 0;
    }
    private bool IsOneLetterDiff(string a, string b)
    {
        var diff = 0;
        for(var i=0;i<a.Length;i++)  {
            if (a[i]!=b[i]) {
                if (diff==1) return false;
                diff++;
            }
        }
        return true;
    }
}
