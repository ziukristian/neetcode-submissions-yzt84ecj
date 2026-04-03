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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {

        var temp = new ListNode(0);

        var current = temp;

        var first = list1;

        var second = list2;

        while(first != null && second !=null){
            if(first.val <= second.val) {
                current.next = first;
                first = first.next;
                current = current.next;
            } else {
                current.next = second;
                second = second.next;
                current = current.next;
            }
        }

        current.next = first ?? second;

        return temp.next;
        
    }
}