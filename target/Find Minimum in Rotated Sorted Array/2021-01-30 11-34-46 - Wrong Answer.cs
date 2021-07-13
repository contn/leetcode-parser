﻿/*
Status: Wrong Answer
Runtime: N/A
Memory: N/A
URL: http://leetcode.com/submissions/detail/449747151/
Submission DateTime: January 30, 2021 11:34:46 AM
*/
public class Solution {
    public int FindMin(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        int mid = 0;
        while(left < right)
        {
          mid = left + (right - left) / 2;
          if(nums[mid] > nums[mid + 1])
            return nums[mid + 1];
          if(nums[mid - 1] > nums[mid])
            return nums[mid];
          if(nums[left] > nums[mid]) // left part has pivot point
            right = mid - 1;
          else // right part has pivot point
            left = mid + 1;
        }
        return -1;
    }
}
