// Copyright (c) 2020 Alexey Filatov
// 437 - Path Sum III (https://leetcode.com/problems/path-sum-iii)
// Date solved: 8/11/2020 7:12:15 AM +00:00
// Memory: 26.3 MB
// Runtime: 84 ms


/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    private int result;
    private int target;
    private Dictionary<int, int> cache = new Dictionary<int, int>();
    // it's number of times we can make this sum going from top
    
    public int PathSum(TreeNode root, int sum) {   
        if (root==null) {
            return 0;
        }
        this.target = sum;
        cache[0] = 1;
        Traverse(root, 0);
        return result;
    }
    private void Traverse(TreeNode node, int currentSum)
    {
        if (node==null) {
            return;
        }
        
        currentSum += node.val;
        
        // if we can reach a some sum since root, and someSumSinceRoot + target == currentSum, then
        // we found a target!
        // i.e. 10 -> 5 -> 3, 
        // at 3 our currentSum is 18, and someSumSinceRoot = 18-8=10 - we can find it!
        // i.e. it's 5+3 and then 10.
        // but it could be 5+3+10+1+-11, then we would have 10 in cache 2 times, i.e. we could start
        // at -11 and with 3.
        
        var someSumSinceRoot = currentSum - target;
        
        result += cache.TryGetValue(someSumSinceRoot, out var count) ? count : 0;
        
        cache[currentSum] = (cache.TryGetValue(currentSum, out var oldVal) ? oldVal : 0) + 1;
        
        Traverse(node.left, currentSum);
        Traverse(node.right, currentSum);
        
        cache[currentSum]--; 
    }
}
