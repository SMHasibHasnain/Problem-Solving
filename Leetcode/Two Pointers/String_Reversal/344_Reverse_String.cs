// 344. Reverse String
// Easy
// https://leetcode.com/problems/reverse-string/description/
// TC = O(n)
// Runtime 0ms Beats 100%


public class Solution {
    public void ReverseString(char[] s) {
        int left = 0;
        int right = s.Length - 1;
        while(left < right) {
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            left++;
            right--;
        }
    }
}