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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {

        var dict = new Dictionary<int,ListNode>();
        var counter = 1;
        var current = head;

        do {
            dict.Add(counter, current);
            current = current.next;
            counter++;
        }
        while(current is not null);

        if(!dict.ContainsKey(counter -1 - n)){
            return head.next;
        }
        var previousToTarget = dict[counter -1 - n];

        if(!dict.ContainsKey(counter +1 - n)){
            previousToTarget.next = null;
            return head;
        }
        var nextToTarget = dict[counter +1 - n];

        previousToTarget.next = nextToTarget;


        return head;
        
    }
}
