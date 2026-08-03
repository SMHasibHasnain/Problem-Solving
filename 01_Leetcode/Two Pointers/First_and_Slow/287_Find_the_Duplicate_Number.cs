// 287. Find the Duplicate Number
// https://leetcode.com/problems/find-the-duplicate-number/
// Medium
// TC = O(n)
// 4ms Beats 71.15%


public class Solution {
    public int FindDuplicate(int[] nums) {
        int left = 0;
        int right = 0;
        while(true) {
            left = nums[left];
            right = nums[nums[right]];

            if(left == right) {
                right = 0;
                break;
            }
        }

        while(true) {
            left = nums[left];
            right = nums[right];

            if(left == right) {
                break;
            }
        }

        return left;
    }
}