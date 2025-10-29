namespace Leetcode.Problems.DotNet._433_Minimum_Genetic_Mutation;

/// <summary>
/// Problem description: https://leetcode.com/problems/minimum-genetic-mutation/description/
/// A gene string can be represented by an 8-character long string, with choices from 'A', 'C', 'G', and 'T'.
/// Suppose we need to investigate a mutation from a gene string startGene to a gene string endGene where one mutation is
/// defined as one single character changed in the gene string.
/// There is also a gene bank that records all the valid gene mutations. A gene must be in bank to make it a valid gene
/// string.
/// Given the two gene strings startGene and endGene and the gene bank, return the minimum number of mutations needed to
/// mutate from startGene to endGene. If there is no such a mutation, return -1.
/// Note that the starting point is assumed to be valid, so it might not be included in the bank.
/// </summary>
public class Solution
{
    public int MinMutation(string startGene, string endGene, string[] bank)
    {
        var beginWord = startGene;
        var endWord = endGene;
        var wordList = new List<string>(bank);

        var n = wordList.Count;
        var map = new short [n + 2, n + 2];

        var endIndex = -1;
        var beginIndex = -1;
        for (var i = 0; i < wordList.Count; i++)
        {
            if (wordList[i] == endWord)
            {
                endIndex = i;
            }

            if (wordList[i] == beginWord)
            {
                beginIndex = i;
            }
        }

        if (beginIndex == -1)
        {
            wordList.Add(beginWord);
            beginIndex = wordList.Count - 1;
        }

        for (var i = 0; i < wordList.Count; i++)
        for (var j = 0; j < wordList.Count; j++)
            map[i, j] = HasConvertion(wordList[i], wordList[j]) ? (short)1 : short.MaxValue;

        if (endIndex == -1) return -1;

        var distance = Calculate(wordList.Count, beginIndex + 1, endIndex + 1, map);

        return distance == short.MaxValue ? -1 : distance;
    }

    public bool HasConvertion(string s1, string s2)
    {
        var count = 0;

        for (var i = 0; i < s1.Length; i++)
            if (s1[i] != s2[i])
                count++;

        return count == 1 ? true : false;
    }

    public static int Calculate(int n, int from, int to, short[,] map)
    {
        var d = new int [n];
        var used = new bool [n];

        // Dijkstra from 'from' to find shortest paths
        for (var i = 0; i < n; i++)
        {
            used[i] = false;
            d[i] = short.MaxValue;
        }

        d[from - 1] = 0;

        for (var i = 0; i < n; i++)
        {
            var v = -1;
            for (var j = 0; j < n; j++)
                if (!used[j] && (v == -1 || d[j] < d[v]))
                {
                    v = j;
                }

            if (d[v] == short.MaxValue) break;
            used[v] = true;

            for (var e = 0; e < n; e++)
            {
                if (map[v, e] == short.MaxValue) continue;
                if (d[v] + map[v, e] < d[e])
                {
                    d[e] = d[v] + map[v, e];
                }
            }
        }

        return d[to - 1];
    }
}