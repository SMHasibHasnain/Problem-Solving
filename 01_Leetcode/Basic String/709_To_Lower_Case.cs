/*
    * 709. To Lower Case
    * https://leetcode.com/problems/to-lower-case/description/
    * 0ms Beats 100%;
    * TC: O(n)
*/


public class Solution {
    public string ToLowerCase(string s) {
        string result = "";
        for(int i=0; i<s.Length; i++) {
            if((int)s[i] <= 90 && (int)s[i] >= 65) {
                result = result + (char)(32 + (int)s[i]);
            } else {
                result += s[i];
            }
        } 

        return result;
    }
}