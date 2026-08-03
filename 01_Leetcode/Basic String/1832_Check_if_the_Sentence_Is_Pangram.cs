/*
    * 1832. Check if the Sentence Is Pangram
    * https://leetcode.com/problems/check-if-the-sentence-is-pangram/description/
    * Easy
    * Runtime: 1ms Beats 68.59%
    * O(n)
*/


public class Solution {
    public bool CheckIfPangram(string sentence) {
        HashSet<char> set = new HashSet<char>();
        for(int i=0; i<sentence.Length; i++) {
            set.Add(sentence[i]);
        }
        if(set.Count() == 26) return true;
        return false;
    }
}