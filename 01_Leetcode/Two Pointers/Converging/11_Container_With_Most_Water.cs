// 11. Container With Most Water
// https://leetcode.com/problems/container-with-most-water/description/
// Medium
// TC: O(n)
// Runtime: 1ms Beats 99.62%

public class Solution {
    public int MaxArea(int[] height) {
        int max = 0;
        int left = 0;
        int right = height.Length - 1;

        while(left < right) {
            int cal = Math.Min(height[left], height[right]) * (right-left);
            if (height[left] <= height[right]) {
                left++;
            } else {
                right--;
            }
            
            if(cal > max) {
                max = cal;
            }
        }

        return max;
        
    }
}