namespace Algorithms.ValidParentheses;

using Coll = System.Collections;

// https://leetcode.com/problems/valid-parentheses/
// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
// An input string is valid if:
// Open brackets must be closed by the same type of brackets.
// Open brackets must be closed in the correct order.
// Every close bracket has a corresponding open bracket of the same type.
public class Solution
{
    // "()[]{}"
    public bool IsValid(string s)
    {
        var stack = new Coll.Stack();
        var regular = "()";
        var curly = "{}";
        var square = "[]";
        foreach (var parenthesis in s)
        {   
            var first = stack.Count > 0 ? stack.Peek() : null;
            if (first != null &&
               ((first.ToString() + parenthesis.ToString() == regular) ||
               (first.ToString() + parenthesis.ToString() == curly) ||
               (first.ToString() + parenthesis.ToString() == square)))
            {
                stack.Pop();
            }
            else
                stack.Push(parenthesis);

        }
        return !(stack.Count > 0);
    }
}
