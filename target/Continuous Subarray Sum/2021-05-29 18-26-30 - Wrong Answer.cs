﻿/*
Status: Wrong Answer
Runtime: N/A
Memory: N/A
URL: http://leetcode.com/submissions/detail/500074792/
Submission DateTime: May 29, 2021 6:26:30 PM
*/
public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) 
    {
      // the similar as to find continues subarray with sum == k
      // sum(a[0] mod k....a[i] mod k) == sum(a[0] mod k....a[j] mod k) then sum(a[i]...a[j]) mod k == 0 so range [i,j]
      var sumMods = new HashSet<int>(nums.Length);
      int sum = 0;
      for(int i = 0; i < nums.Length; i++)
      {
        sum += nums[i];
        int mod = sum;
        if (k != 0)
          mod = sum % k;
        if(sumMods.Contains(mod))
          return true;
        
        sumMods.Add(mod);          
      }
      
      return false;
      
    }
}
