﻿/*
Status: Accepted
Runtime: 372 ms
Memory: 46.1 MB
URL: http://leetcode.com/submissions/detail/495410970/
Submission DateTime: May 19, 2021 12:46:22 PM
*/
public class SparseVector {
    
    private Dictionary<int, int> values = new Dictionary<int, int>();
  
    public SparseVector(int[] nums) {
            
      if(nums != null)
      {        
        for(int i = 0; i < nums.Length; i++)
        {
          if(nums[i] != 0)
            values[i] = nums[i];
        }
      }
    }
      
    
    // Return the dotProduct of two sparse vectors
    public int DotProduct(SparseVector vec) {
      int result = 0;
      foreach(var p in values)
      {
        if(vec.values.ContainsKey(p.Key))
          result += p.Value * vec.values[p.Key];
      }
      
      return result;
    }
  
  
}

// Your SparseVector object will be instantiated and called as such:
// SparseVector v1 = new SparseVector(nums1);
// SparseVector v2 = new SparseVector(nums2);
// int ans = v1.DotProduct(v2);
