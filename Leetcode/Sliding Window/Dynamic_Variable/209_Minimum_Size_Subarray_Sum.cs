/*
    * 209. Minimum Size Subarray Sum
    * https://leetcode.com/problems/minimum-size-subarray-sum/description/
    * Medium
    * Runtime: 0 ms Beats 100.00%
    * TC: O(n)
*/

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0;
        int right = 0;

        int windowSum = 0;
        int result = nums.Length + 1;

        while(right < nums.Length) {
            windowSum += nums[right];

            while(windowSum >= target) {
                result = Math.Min(result, right-left+1);
                windowSum -= nums[left++];
            }

            right++;
        }

        return result == nums.Length + 1 ? 0 : result;

    }
}