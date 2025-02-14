// Copyright (c) 2020 Alexey Filatov
// 310 - Minimum Height Trees (https://leetcode.com/problems/minimum-height-trees)
// Date solved: 11/5/2020 8:01:34 AM +00:00
// Memory: 439.4 MB
// Runtime: 692 ms


// each edge A to B contains height of tree if going from A to B
// which is MAX of (all such heights from B, excluding B->A) + 1
// then, having a node X, go through all its edges and choose MAX - it will be a "height" if X is root
// then find a MIN of those and return all nodes having this height
public class Solution {
    int n;
    int[][] heights;
    List<int>[] connected;
    public IList<int> FindMinHeightTrees(int n, int[][] edges) {
        this.n = n;
        heights = new int[n][];
        connected = new List<int>[n];
        for(var i=0; i<n; i++) connected[i] = new List<int>(); 
        foreach(var edge in edges) {
            connected[edge[0]].Add(edge[1]);
            connected[edge[1]].Add(edge[0]);
        }
        
        //for(var i=0; i<n; i++) {
            //Console.WriteLine(i+":"+string.Join(",",connected[i]));
        //}
            
        for(var i=0; i<n; i++) heights[i] = new int[n];
        for(var i=0; i<n; i++) {
            foreach(var j in connected[i]) {
                CalcHeight(i, j);
            }            
        }
        var result = new List<int>();
        var min = int.MaxValue;
        for(var i=0; i<n; i++) {
            var maxHeight = int.MinValue;
            foreach(var h in heights[i]) {
                maxHeight = Math.Max(maxHeight, h);
            }
            if (maxHeight<min) {
                result.Clear();
                min = maxHeight;
            }
            if (maxHeight==min) {
                result.Add(i);
            }
        }
        return result;
    }
    int CalcHeight(int i, int j)
    {
        if (i==j) return 0;
        if (heights[i][j]!=0) return heights[i][j];
        var max = 0;
        foreach(var k in connected[j]) {
            if (k!=i) {
                max = Math.Max(max, CalcHeight(j,k));
            }
        }
        heights[i][j] = max+1;
        return heights[i][j];
    }
}
