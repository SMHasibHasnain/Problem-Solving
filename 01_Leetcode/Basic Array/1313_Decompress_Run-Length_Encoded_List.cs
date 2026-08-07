/*
    * 1313. Decompress Run-Length Encoded List
    * https://leetcode.com/problems/decompress-run-length-encoded-list/description/
    * Easy
*/

public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        List<int> list = new List<int>();
        int left = 0;
        int right = 1;
        while(right < nums.Length) {
            int freq = nums[left];
            while(freq != 0) {
                list.Add(nums[right]);
                freq--;
            }
            left += 2;
            right += 2;
        }
        return list.ToArray();
    }
}