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