// 125. Valid Palindrome
// Easy
// https://leetcode.com/problems/valid-palindrome/description/
// 15ms Beats 74.31%


public class Solution {
    public bool IsPalindrome(string s) {
        string ss = s.ToLower().Trim();
        int left = 0;
        int right = ss.Length - 1;
        bool flag = true;
        while(left<right) {
            if(!char.IsLetterOrDigit(ss[left])) {
                left++;
                continue;
            } 
            if(!char.IsLetterOrDigit(ss[right])) {
                right--;
                continue;
            }

            if(ss[left] == ss[right]) {
                left++;
                right--;
                continue;
            }

            flag = false;
            break;
        }

        return flag;
    }
}