/*
    * 713. Subarray Product Less Than K
    * https://leetcode.com/problems/subarray-product-less-than-k/description/
    * Medium
    * 3ms Beats 100%
    * TC: O(n)
*/

public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {

        if(k == 1) return 0;

        int left = 0;
        int right = 0;
        
        int windowProduct = 1;
        int result = 0;

        while(right < nums.Length) {
            windowProduct *= nums[right];
            while(windowProduct >= k) {
                windowProduct /= nums[left];
                left++;
            }
            result += right - left + 1;
            right++;
        }
        return result;
    }
}