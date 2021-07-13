﻿/*
Status: Time Limit Exceeded
Runtime: N/A
Memory: N/A
URL: http://leetcode.com/submissions/detail/450303378/
Submission DateTime: January 31, 2021 5:09:21 PM
*/
public class Solution {
    public int FindMin(int[] nums)
        {
            // --- Pivot point is min value - so search in part contains pivot
            // ----
            int left = 0;
            int right = nums.Length - 1;
            int mid = 0;            
            while (left < right)
            {
                mid = left + (right - left) / 2;
                
                if (nums[right] > nums[mid])
                    right = mid;
                else if (nums[right] < nums[mid])
                    left = mid;
                else
                    right--;
            }
            return nums[mid];
        }
}
