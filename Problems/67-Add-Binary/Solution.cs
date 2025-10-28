using System.Text;

namespace Leetcode.Problems.DotNet._67_Add_Binary;

/// <summary>
/// Problem description: https://leetcode.com/problems/add-binary/description/
/// Given two binary strings a and b, return their sum as a binary string.
/// </summary>
public class Solution
{
    public string AddBinary(string a, string b)
    {
        var c = 0;
        var res = 0;
        var max = a.Length > b.Length ? a.Length : b.Length;
        var al = a.Length;
        var bl = b.Length;

        var str = new StringBuilder(max + 1);

        for (var i = 0; i < max; i++)
        {
            var ai = GetArrValue(al, i);
            var bi = GetArrValue(bl, i);
            var av = ai >= 0 && a[ai] == '1' ? 1 : 0;
            var bv = bi >= 0 && b[bi] == '1' ? 1 : 0;

            res = (av + bv + c) % 2;
            str.Insert(0, res.ToString());

            c = av + bv + c > 1 ? 1 : 0;
        }

        if (c > 0) str.Insert(0, c.ToString());

        return str.ToString();
    }

    public int GetArrValue(int len, int index)
    {
        return len - index - 1;
    }
}