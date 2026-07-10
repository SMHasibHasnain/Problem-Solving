// 977. Squares of a Sorted Array
// https://leetcode.com/problems/squares-of-a-sorted-array/description/
// Easy
// TC: O(n)
// RT: 2ms Beats 41.80%
// Mem: 50.65%

public class Solution {
    public int[] SortedSquares(int[] nums) {
        int left = 0;
        int right = nums.Count() - 1;
        int[] arr = new int[nums.Count()];
        int ptr = arr.Count() - 1;

        while(left<=right) {
            if(nums[left] * nums[left] >= nums[right] * nums[right]) {
                arr[ptr--] = nums[left] * nums[left];
                left++;
            } else if(nums[right] * nums[right] > nums[left] * nums[left]) {
                arr[ptr--] = nums[right] * nums[right];
                right--;
            }
        }
        return arr;
    }
}