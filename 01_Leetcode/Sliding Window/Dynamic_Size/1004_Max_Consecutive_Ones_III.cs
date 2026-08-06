/*
    * 1004. Max Consecutive Ones III
    * https://leetcode.com/problems/max-consecutive-ones-iii/description/
    * Medium
*/

public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int left = 0;
        int right = 0;
        int result = 0;
        int kBag = 0;
        
        while(right < nums.Length) {
            if(nums[right] == 0) kBag++;
            while(nums[right] == 0 && kBag > k) {
                if(nums[left] == 0) {
                    kBag--;
                }
                left++;
            }

            result = Math.Max(result, right - left + 1);
            right++;
        }

        return result;
    }
}