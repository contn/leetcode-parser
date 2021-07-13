﻿/*
Status: Wrong Answer
Runtime: N/A
Memory: N/A
URL: http://leetcode.com/submissions/detail/488035326/
Submission DateTime: May 2, 2021 5:27:46 PM
*/
public class Solution {
    public string MinRemoveToMakeValid(string s) {
        var stack = new Stack<int>(); // strore indexes of '('
        var ignoreCharIndexes = new HashSet<int>();        
        for (int i = 0; i < s.Length; i++)
        {          
          if(s[i] == '(')
          {
            stack.Push(i);
            ignoreCharIndexes.Add(i);
          }
          else if(s[i] == ')')
          {
            if(stack.Count > 0)
            {
              var igi = stack.Pop();
              ignoreCharIndexes.Remove(igi);
            }
            else
              ignoreCharIndexes.Add(i);
          }
                                  
        }
        if(stack.Count > 0) 
        {     
          var result = new StringBuilder();
          for (int i = 0; i < s.Length; i++)
          {
            if(!ignoreCharIndexes.Contains(i))
              result.Append(s[i]);
          }
          return result.ToString();  
        }
        else
          return s;
        
    }
}
