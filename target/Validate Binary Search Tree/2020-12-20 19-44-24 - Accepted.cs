﻿/*
Status: Accepted
Runtime: 96 ms
Memory: 27.1 MB
URL: http://leetcode.com/submissions/detail/432778963/
Submission DateTime: December 20, 2020 7:44:24 PM
*/
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsValidBST(TreeNode root) {
      return Traverse(root, null, null);          
    }
  
    public bool Traverse(TreeNode node, int? min, int? max)
    {
      if(node == null)
        return true;      
      
      if(min != null && node.val >= min)
          return false;                      
      
      if(max != null && node.val <= max)      
          return false;                      
      
      if(!Traverse(node.left, node.val, max))
          return false;      
      if(!Traverse(node.right, min, node.val))
          return false;
                      
      return true;
    }
  
    
}
