// 876. Middle of the Linked List
// https://leetcode.com/problems/middle-of-the-linked-list/description/
// Easy
// TC = O(n)

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode MiddleNode(ListNode head) {
        ListNode left = head;
        ListNode right = head;
        while(left?.next != null && right?.next != null) {
            left = left.next;
            right = right?.next?.next;
        } 
        return left;
    }
}