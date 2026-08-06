/*
    * 771. Jewels and Stones
    * https://leetcode.com/problems/jewels-and-stones/description/
    * Easy
*/

public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int result = 0;
        foreach(char item in stones) {
            if(jewels.Contains(item)) result++;
        }
        return result;
    }
}