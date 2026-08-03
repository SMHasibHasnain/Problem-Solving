/*
    * 1456. Maximum Number of Vowels in a Substring of Given Length
    * https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/description/
    * Medium
    * TC: O(n)
    * Runtime: 7ms Beats 84.38%
*/


public class Solution {
    public int MaxVowels(string s, int k) {
        char[] arr = s.ToCharArray();

        int ptr = 0;
        int i = 0;

        int max = 0;
        for(; i<k; i++) {
            if(isVowel(arr[i])) max++;
        }

        int subtotal = max;
        for(; i<arr.Length; i++) {
            if(isVowel(arr[ptr])) subtotal--;
            ptr++;

            if(isVowel(arr[i])) subtotal++;

            if(subtotal > max) {
                max = subtotal;
            } 
        }

        return max;
    }

    public bool isVowel(char letter) {
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u') return true;
        return false;
    }
}