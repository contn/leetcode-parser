﻿/*
Status: Runtime Error
Runtime: N/A
Memory: N/A
URL: http://leetcode.com/submissions/detail/494498759/
Submission DateTime: May 17, 2021 12:48:23 PM
*/
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
      if( k >= 1 || k < nums.Length)                            
        QSelectMax(nums, 0, nums.Length - 1, k);      
      return nums.Take(k).Min();
    }
  
    private void QSelectMax(int[] nums, int l, int r, int k)
    {
      int p = Pivot(nums, l-1, l, r);
      if(p == k)
        return;
      else if(p < k)
        QSelectMax(nums, p + 1, r, k);      
      else
        QSelectMax(nums, l, p - 1, k);
    }
  
    private int Pivot(int[] nums, int i, int j, int p)
    {
      for(; j < p; j++)
      {
        if(nums[j] >= nums[p])
        {
          i++;
          if(i != j)
            (nums[i], nums[j]) = (nums[j], nums[i]);
        }        
      }
      i++;
      (nums[i], nums[p]) = (nums[p], nums[i]);
      
      return i;
    }
}
