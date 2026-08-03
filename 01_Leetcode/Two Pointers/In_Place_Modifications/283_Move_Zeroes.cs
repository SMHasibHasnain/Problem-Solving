// 283. Move Zeroes
// Easy
// https://leetcode.com/problems/move-zeroes/description/
// TC = O(n)
// Runtime 1ms Beats 97.44%
// Memory Beats 7.63%


public class Solution {
    public void MoveZeroes(int[] nums) {
        int write = 0;
        for(int read = 0; read < nums.Length; read++) {
            if(nums[write] == 0 && nums[read] != 0) {
                nums[write++] = nums[read];
                nums[read] = 0;
            } else if(nums[write] != 0) {
                write++;
            }

            
        }
    }
}