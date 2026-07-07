// 202. Happy Number
// https://leetcode.com/problems/happy-number/description/
// Medium
// 0ms Bets 100%
// TC = O(log n) 

public class Solution {
    public bool IsHappy(int n) {

        int slow = n;
        int fast = n;

        while(true) {
            slow = Calculate(slow);
            fast = Calculate(Calculate(fast));

            if(slow == fast) {
                break;
            }
        }

        return fast == 1;
    }

    public int Calculate(int n) {
        int sum = 0;
        while(n != 0) {
            int temp = n % 10;
            sum = sum + temp * temp;
            n = n / 10;
        }
        return sum; 
    }


}