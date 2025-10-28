using FluentAssertions;
using NUnit.Framework;

namespace Leetcode.Problems.DotNet._2_Add_Two_Numbers;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        var result = solution.AddTwoNumbers(l1, l2);

        // проверь, что результат соответствует [7,0,8]
        result.Val.Should().Be(7);
        result.Next.Val.Should().Be(0);
        result.Next.Next.Val.Should().Be(8);
        result.Next.Next.Next.Should().BeNull();
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var l1 = new ListNode(0);
        var l2 = new ListNode(0);
        var result = solution.AddTwoNumbers(l1, l2);
        
        result.Val.Should().Be(0);
        result.Next.Should().BeNull();
    }

    [Test]
    public void Case3()
    {
        var solution = new Solution();
        var l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
        var l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
        var result = solution.AddTwoNumbers(l1, l2);
        
        result.Val.Should().Be(8);
        result.Next.Val.Should().Be(9);
        result.Next.Next.Val.Should().Be(9);
        result.Next.Next.Next.Val.Should().Be(9);
        result.Next.Next.Next.Next.Val.Should().Be(0);
        result.Next.Next.Next.Next.Next.Val.Should().Be(0);
        result.Next.Next.Next.Next.Next.Next.Val.Should().Be(0);
        result.Next.Next.Next.Next.Next.Next.Next.Val.Should().Be(1);
        result.Next.Next.Next.Next.Next.Next.Next.Next.Should().BeNull();
    }
}