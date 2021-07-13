﻿/*
Status: Wrong Answer
Runtime: N/A
Memory: N/A
URL: http://leetcode.com/submissions/detail/519946422/
Submission DateTime: July 9, 2021 3:21:12 PM
*/
public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
      // sliding window
      var wordSet = new HashSet<string>(wordDict);
      int b = 0;          
      for (int e = 0; e < s.Length; e++)        
      {
        var sub = s.Substring(b, e - b + 1);
        if(wordSet.Contains(sub))          
        {          
          b = e + 1;
        }
      }
      return b == s.Length;
    }
}
