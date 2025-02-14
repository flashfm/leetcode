// Copyright (c) 2020 Alexey Filatov
// 310 - Minimum Height Trees (https://leetcode.com/problems/minimum-height-trees)
// Date solved: 11/6/2020 8:14:20 AM +00:00
// Memory: 40.9 MB
// Runtime: 296 ms


// each edge A to B contains height of tree if going from A to B
// which is MAX of (all such heights from B, excluding B->A) + 1
// then, having a node X, go through all its edges and choose MAX - it will be a "height" if X is root
// then find a MIN of those and return all nodes having this height
public class Solution {
    public IList<int> FindMinHeightTrees(int n, int[][] edges) {
        var connected = new List<int>[n];
        for(var i=0; i<n; i++) connected[i] = new List<int>(); 
        foreach(var edge in edges) {
            connected[edge[0]].Add(edge[1]);
            connected[edge[1]].Add(edge[0]);
        }
        var queue = new Queue<int>();
        for(var i=0; i<n; i++) {
            if (connected[i].Count==1) {
                queue.Enqueue(i);
            }
        }
        var removed = new bool[n];
        var k = n;
        while (k>2) {
            var newQueue = new Queue<int>();
            while(queue.Count>0) {
                //Console.WriteLine(string.Join(",",queue.ToArray()));
                var a = queue.Dequeue();
                removed[a] = true;
                k--;
                var b = connected[a][0];
                connected[a].Remove(b);
                var bconns = connected[b];
                bconns.Remove(a);
                if (bconns.Count==1) {
                    newQueue.Enqueue(b);
                }
            }
            queue = newQueue;
        }
        var result = new List<int>();
        for(var i=0; i<n; i++) {
            if (!removed[i]) {
                result.Add(i);
            }
        }
        
        return result.ToArray();
    }
}
