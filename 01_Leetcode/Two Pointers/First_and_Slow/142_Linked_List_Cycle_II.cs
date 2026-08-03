// 142. Linked List Cycle II
// https://leetcode.com/problems/linked-list-cycle-ii/description/
// Medium
// TC = O(n)
// 96ms Beats 34.49%

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */

public class Solution {
    public ListNode DetectCycle(ListNode head) {
        ListNode left = head;
        ListNode right = head;
        bool flag = false;

        while(right != null && right.next != null) {
            left = left.next;
            right = right.next.next;

            if(left == right) {
                right = head;
                flag = true;
                break;
            }
        }

        while(flag) {
            if(left == right) return right;
            left = left.next;
            right = right.next;
        }

        return null;
    }
}