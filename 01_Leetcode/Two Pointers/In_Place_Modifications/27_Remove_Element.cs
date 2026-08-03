// 27. Remove Element
// Easy
// https://leetcode.com/problems/remove-element/description/
// TC = O(n)
// RT 0ms Beats 100%
// Mem 46.89MB Beats 42.79%

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int writer = 0;        
        for(int reader = 0; reader < nums.Length; reader++) {
            if(nums[writer] == val) {
                if(nums[reader] != val) {
                    nums[writer++] = nums[reader];
                    nums[reader] = val;
                }
            } else {
                writer++;
            }
        }

        return writer;
    }
}