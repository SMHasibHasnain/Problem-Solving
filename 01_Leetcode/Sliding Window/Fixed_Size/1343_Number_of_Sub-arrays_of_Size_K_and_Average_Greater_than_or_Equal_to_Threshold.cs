/*
    * 1343. Number of Sub-arrays of Size K and Average Greater than or Equal to Threshold
    * https://leetcode.com/problems/number-of-sub-arrays-of-size-k-and-average-greater-than-or-equal-to-threshold/description/
    * Medium

    * TC: O(n)
    * Runtime: 2ms Beats 87.23%
*/

public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int ptr = 0;
        int i;
        int count = 0; 

        int total = 0;
        for(i = 0; i < k; i++) {
            total += arr[i];
        }

        if((total / k) >= threshold) count++;

        for(; i < arr.Length; i++) {
            total -= arr[ptr];
            ptr++;
            total += arr[i];

            if((total / k) >= threshold) count++;
        } 

        return count;
    }
}