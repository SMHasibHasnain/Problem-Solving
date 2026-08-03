// 345. Reverse Vowels of a String
// Easy
// https://leetcode.com/problems/reverse-vowels-of-a-string/description/
// TC = O(n) 

public class Solution {
    public string ReverseVowels(string s) {
        char[] chars = s.ToCharArray();
        int left = 0;
        int right = s.Length - 1;
        
        while (left < right) {

            if (!IsVowel(chars[left])) {
                left++;
            }

            if (!IsVowel(chars[right])) {
                right--;
            }

            if(IsVowel(chars[right]) && IsVowel(chars[left])) {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                
                left++;
                right--;
            }
        }
        
        return new string(chars);
    }

    bool IsVowel(char c) {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
               c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
    }
}