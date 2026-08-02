/*
    * 1108. Defanging an IP Address
    * https://leetcode.com/problems/defanging-an-ip-address/description/
    * 75ms Beats 9.42%
*/

public class Solution {
    public string DefangIPaddr(string address) {
        string result = "";
        foreach(var letter in address) {
            if(letter == '.') {
                result += "[.]";
            } else {
                result += letter;
            }
        }
        return result;
    }
}
