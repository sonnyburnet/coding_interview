namespace Algorithms.ReverseLinkedList;


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
//  */
// public class Solution
// {
//     public ListNode ReverseList(ListNode head)
//     {
//         ListNode go(ListNode old_list, ListNode new_list)
//         {
//             if(old_list == null) { return new_list; }
//             if (new_list == null)
//             {
//                 var tmp = new ListNode(old_list.val);
//                 return go(old_list.next, tmp);
//             }
//             else
//             {
//                 var tmp = new ListNode(old_list.val);
//                 tmp.next = new_list;
//                 go(old_list.next, tmp);
//             }
//         };
//         return head == null ? null : go(head, null);
//     }
// }

