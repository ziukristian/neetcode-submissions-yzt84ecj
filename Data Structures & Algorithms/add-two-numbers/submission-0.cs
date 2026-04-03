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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var num1 = "";
        var num2 = "";

        var current = l1;
        while(current != null){
            num1 = current.val.ToString() + num1;
            current = current.next;
        }

        current = l2;
        while(current != null){
            num2 = current.val.ToString() + num2;
            current = current.next;
        }

        var sum = (int.Parse(num1) + int.Parse(num2)).ToString();

        var newHead = new ListNode();
        current = newHead;
        for(var i = sum.Length -1;i>=0;i--){
            current.val = int.Parse(sum[i].ToString());
            if (i > 0)
            {
                current.next = new ListNode();
                current = current.next;
            }
        }


        return newHead;

    }
}
