/* 
    * 2379. Minimum Recolors to Get K Consecutive Black Blocks
    * https://leetcode.com/problems/minimum-recolors-to-get-k-consecutive-black-blocks/description/
    * Easy
    * TC = n(O)
    * Runtime: 0 ms Beats 100.00%
*/

public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        char[] arr = blocks.ToCharArray();
        int left = 0;
        int right = 0;
        int totalW = 0;
        while(right < k) {
            if(arr[right] == 'W') totalW++;
            right++;
        }

        int calc = totalW;
        while(right < arr.Length) {
            
            if(arr[left] == 'W') calc--;
            left++;
            
            if(arr[right] == 'W') calc++;
            right++;

            if(totalW > calc) {
                totalW = calc;
            }
        }
        return totalW;
    }
}