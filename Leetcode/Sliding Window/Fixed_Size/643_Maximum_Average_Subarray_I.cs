/*
* 643. Maximum Average Subarray I
* https://leetcode.com/problems/maximum-average-subarray-i/description/

    * Runtime: 3ms Beats 59.79%
    * Easy
    * TC: O(n)

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
*/


/*
    * Runtime: 2ms Beats 100.00%
    * Memory: 59.90 MB Beats 81.76%
    * Easy
*/    

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int ptr = 0;
        int i;
        
        int total = 0;

        for(i = 0; i<k; i++) {
            total = nums[i] + total;
        } 

        int subTotal = total;

        for(int j = i; j<nums.Length; j++) {
            subTotal = subTotal - nums[ptr];
            ptr++;

            subTotal = subTotal + nums[j];

            if(subTotal > total) {
                total = subTotal;
            }
        }

        return (double) total/k;

    }
}