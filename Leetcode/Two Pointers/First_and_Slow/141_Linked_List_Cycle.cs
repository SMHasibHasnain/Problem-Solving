// 141. Linked List Cycle
// https://leetcode.com/problems/linked-list-cycle/description/
// Easy
// TC = O(n)

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
    public bool HasCycle(ListNode head) {
        ListNode left = head;
        ListNode right = head;
        bool flag = false;

        while(left?.next != null && right?.next != null) {
            left = left?.next;
            right = right?.next?.next;

            if(left == right) {
                flag = true;
                break;
            }
        }
        return flag;
    }
}