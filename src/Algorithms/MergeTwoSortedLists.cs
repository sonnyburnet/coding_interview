namespace Algorithms.MergeTwoSortedLists;

// https://leetcode.com/problems/merge-two-sorted-lists/


public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var list = new ListNode();

        ListNode doNothing(ListNode list) { return list; }

        ListNode firstCase(int fval, int sval, ListNode node)
        {
            var new_node = new ListNode();
            if (fval > sval) { new_node.val = sval; }
            else { new_node.val = fval; }
            new_node.next = node;
            return new_node;
        }

        ListNode secondAndThirdCase(int fval, int sval, ListNode? node)
        {
            var new_node_f = new ListNode();
            var new_node_s = new ListNode();
            if (fval > sval)
            {
                new_node_f.val = sval;
                new_node_s.val = fval;
                new_node_f.next = new_node_s;
                new_node_s.next = node;
                return new_node_s;
            }
            else
            {
                new_node_f.val = fval;
                new_node_s.val = sval;
                new_node_s.next = new_node_f;
                new_node_f.next = node;
                return new_node_f;
            }
        }

        ListNode go(ListNode list, ListNode first, ListNode second)
        {
            ListNode generalCase(ListNode flist, ListNode slist, ListNode list)
            {
                var new_node = new ListNode();
                if (flist.val > slist.val)
                {
                    new_node.val = slist.val;
                    list.next = new_node;
                    return go(new_node, flist, slist.next);
                }
                else
                {
                    new_node.val = flist.val;
                    list.next = new_node;
                    return go(new_node, flist.next, slist);
                }
            }
            ListNode rest = (first, second, list) switch
            {
                (null, null, _) => null,
                (ListNode { val: 0, next: null },
                 ListNode { val: 0, next: null },
                 ListNode { val: _, next: var node }) => 
                 doNothing(list),
                (ListNode { val: var fval, next: null },
                 ListNode { val: var sval, next: null },
                 ListNode { val: _, next: var node }) =>
                 firstCase(fval, sval, node),
                (ListNode { val: var fval, next: null },
                 ListNode { val: var sval, next: var node }, _) =>
                 secondAndThirdCase(fval, sval, node),
                (ListNode { val: var fval, next: var node },
                 ListNode { val: var sval, next: null }, _) =>
                secondAndThirdCase(fval, sval, node),
                (ListNode { val: var fval, next: var fnode },
                 ListNode { val: var sval, next: var snode },
                 ListNode { val: _, next: var node }) =>
                 generalCase(first, second, list),
                _ => doNothing(list)
            };
            return rest;
        }
        go(list, list1, list2);
        return list;
    }
}