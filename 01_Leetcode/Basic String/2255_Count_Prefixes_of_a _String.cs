/*
    * 2255. Count Prefixes of a Given String
    * https://leetcode.com/problems/count-prefixes-of-a-given-string/description/
    * Easy
*/

public class Solution {
    public int CountPrefixes(string[] words, string s) {
        int result = 0;
        for(int i=0; i<words.Length; i++) {
            if (s.StartsWith(words[i])) {
                result++;
            }
        }
        return result;
    }
}