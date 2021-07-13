﻿/*
Status: Wrong Answer
Runtime: N/A
Memory: N/A
URL: http://leetcode.com/submissions/detail/520968367/
Submission DateTime: July 11, 2021 4:23:25 PM
*/
public class Solution {
    public string MinRemoveToMakeValid(string s) 
    {
      // stack will store positions of all unpared brackets
      var bracketPos = new Stack<int>();      
      
      for(int p = 0; p < s.Length; p++)
      {
        if(s[p] == '(')
          bracketPos.Push(p);
        else if(s[p] == ')')
        {
          if(bracketPos.Count > 0)
          {
            if(s[bracketPos.Peek()] == '(')
              bracketPos.Pop();
            else
              bracketPos.Push(p);
          }
          else
            bracketPos.Push(p);            
        }
      }
      
      if(bracketPos.Count == 0)
        return s;
      
      var result = new List<char>();
      for(int p = 0; p < s.Length; p++)
      {
        if(bracketPos.Count > 0 && bracketPos.Peek() == p)        
          bracketPos.Pop();
        else
          result.Add(s[p]);
      }
      
      return String.Concat(result);
      
    }
}
