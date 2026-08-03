// 167. Two Sum II - Input Array Is Sorted
// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/
// 1ms Beats 27.01%

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Count()-1;


        int i = 0;
        int j = 0;

        while(left<right) {
            int sum = numbers[left] + numbers[right];
            if(sum > target) {
                right--;
            } else if(sum < target) {
                left++;
            } else {
                i = left + 1;
                j = right + 1;
                break;
            }
        }

        return new int[] {i, j};
    }
}