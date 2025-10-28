namespace Leetcode.Problems.DotNet._127_Word_Ladder;

/// <summary>
/// Problem description: https://leetcode.com/problems/word-ladder/description/
/// A transformation sequence from word beginWord to word endWord using a dictionary wordList is a sequence of words beginWord -> s1 -> s2 -> ... -> sk such that:
/// Every adjacent pair of words differs by a single letter.
/// Every si for 1 <= i <= k is in wordList. Note that beginWord does not need to be in wordList.
/// sk == endWord
/// Given two words, beginWord and endWord, and a dictionary wordList, return the number of words in the shortest transformation sequence from beginWord to endWord, or 0 if no such sequence exists.
/// </summary>
public class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        //if (HasConvertion(beginWord, endWord)) return 2;

        int n = wordList.Count;
        short [,] map = new short [n + 2, n + 2];

        int endIndex = -1;
        int beginIndex = -1;
        for(int i = 0; i < wordList.Count; i++) {
            if (wordList[i] == endWord) {
                endIndex = i;                
            }

            if (wordList[i] == beginWord) {
                beginIndex = i;
            }
        }

        if (beginIndex == -1) {
            wordList.Add(beginWord);
            beginIndex = wordList.Count - 1;
        }

        for (int i = 0; i < wordList.Count; i++) {
            for (int j = 0; j < wordList.Count; j++) {
                map[i, j] = HasConvertion(wordList[i], wordList[j]) ? (short)1 : short.MaxValue;
            }
        }

        if (endIndex == -1) return 0;

        var distance = Calculate(wordList.Count, beginIndex + 1, endIndex + 1, map);

        return distance == short.MaxValue ? 0 : distance + 1;
    }

    public bool HasConvertion(string s1, string s2) {
        int count = 0;

        for(int i = 0; i < s1.Length; i++) {
            if (s1[i] != s2[i]) count++;
        }

        return count == 1 ? true : false; 
    }

    public static int Calculate(int n, int from, int to, short [,] map)
    {
        int [] d = new int [n];
        bool[] used = new bool [n];
        
        // Дейкстра из from кратчайший путь в остальные
        for (int i = 0; i < n; i++)
        {
            used[i] = false;
            d[i] = short.MaxValue;
        }
        d[from-1] = 0;

        for (int i = 0; i < n; i++)
        {
            int v = -1;
            for (int j = 0; j < n; j++)
            {
                if (!used[j] && (v == -1 || d[j] < d[v]))
                {
                    v = j;
                }
            }
            if (d[v] == short.MaxValue) break;
            used[v] = true;
			
            for (int e = 0; e < n; e++)
            {
                if (map[v, e] == short.MaxValue) continue;
                if (d[v] + map[v, e] < d[e])
                {
                    d[e] = d[v] + map[v, e];
                }
            }
        }

        return d[to-1];
    }
}
