/*
    * 904. Fruit Into Baskets
    * https://leetcode.com/problems/fruit-into-baskets/description/
    * Medium
*/

public class Solution {
    public int TotalFruit(int[] fruits) {
        Dictionary<int, int> bag = new Dictionary<int, int>();
        int left = 0;
        int right = 0;
        int result = 0;

        while(right < fruits.Length) {
            bag[fruits[right]] = bag.GetValueOrDefault(fruits[right]) + 1;

            while(bag.Count > 2) {
                bag[fruits[left]]--;
                if(bag[fruits[left]] == 0) {
                    bag.Remove(fruits[left]);
                }

                left++;  
            }

            result = Math.Max(result, right - left + 1);

            right++;

        }
        return result;
    }
}