/*
    * 1967. Number of Strings That Appear as Substrings in Word
    * https://leetcode.com/problems/number-of-strings-that-appear-as-substrings-in-word/description/
    * Easy
*/

public class Solution {
    public int NumOfStrings(string[] patterns, string word) {
        int result = 0;
        foreach(var item in patterns) {
            if(word.Contains(item)) result++;
        }

        return result;
    }
}