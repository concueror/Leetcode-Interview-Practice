namespace Leetcode.Problems.DotNet._2_Add_Two_Numbers;

/// <summary>
/// Definition for singly-linked list.
/// </summary>
public class ListNode
{
    public int Val;
    public ListNode Next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.Val = val;
        this.Next = next;
    }
}

/// <summary>
/// Problem description: https://leetcode.com/problems/add-two-numbers/
/// You are given two non-empty linked lists representing two non-negative integers.
/// The digits are stored in reverse order, and each of their nodes contains a single digit.
/// Add the two numbers and return the sum as a linked list.
/// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
/// </summary>
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var start = new ListNode();

        NewMethod(l1, l2, start);

        return start;
    }

    private static void NewMethod(ListNode l1, ListNode l2, ListNode start)
    {
        var cursor = start;
        var add = 0;
        while (l1 != null || l2 != null || add > 0)
        {
            var l1Val = l1?.Val ?? 0;
            var l2Val = l2?.Val ?? 0;

            cursor.Val = l1Val + l2Val + add;
            if (cursor.Val > 9)
            {
                add = 1;
                cursor.Val -= 10;
            }
            else
            {
                add = 0;
            }

            l1 = l1?.Next;
            l2 = l2?.Next;

            if (l2 != null || l1 != null || add > 0)
            {
                cursor.Next = new ListNode();
                cursor = cursor.Next;
            }
        }

        cursor.Next = null;
    }
}