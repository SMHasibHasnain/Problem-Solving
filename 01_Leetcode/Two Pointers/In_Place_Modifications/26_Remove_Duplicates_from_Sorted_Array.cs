// 26. Remove Duplicates from Sorted Array
// Easy
// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
// TC = O(n)
// RT 0ms Beats 100%
// Memory Beats 10.78%

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int write = 1;
        for(int read=1; read<nums.Length; read++) {
            if(nums[read] != nums[read-1]) {
                nums[write++] = nums[read];
            }
        }
        return write;
    }
}