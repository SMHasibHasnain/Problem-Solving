// 643. Maximum Average Subarray I
// https://leetcode.com/problems/maximum-average-subarray-i/description/
// Runtime: 3ms Beats 59.79%
// Easy
// TC: O(n)

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int step = 0;
        double total = 0;
        while(step < k) {
            total = total + nums[step];
            step++;
        }

        double max = total / k;

        int left = 0;
        int right = k;
        while(right < nums.Length) {
            total = total - nums[left] + nums[right];
            double avg = total / k;
            if(avg > max) {
                max = avg;
            }
            left++;
            right++;
        }

        return max;

    }
}