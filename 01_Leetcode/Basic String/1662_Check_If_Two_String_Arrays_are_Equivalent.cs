/*
    * 1662. Check If Two String Arrays are Equivalent
    * https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/description/
    * Easy
    * Runtime: 0ms Beats 100.00%
    * TC: O(n)
*/

public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string one = "";
        string two = "";
        for(int i=0; i<word1.Length; i++) {
            one += word1[i];
        }

        for(int i=0; i<word2.Length; i++) {
            two += word2[i];
        }

        if(one == two) return true;
        return false;
    }
}