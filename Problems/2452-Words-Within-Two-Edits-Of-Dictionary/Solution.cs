namespace Leetcode.Problems.DotNet._2452_Words_Within_Two_Edits_Of_Dictionary;

/// <summary>
/// Problem description: https://leetcode.com/problems/words-within-two-edits-of-dictionary/description/
/// You are given two string arrays, queries and dictionary. All words in each array comprise of lowercase English letters
/// and have the same length.
/// In one edit you can take a word from queries, and change any letter in it to any other letter. Find all words from
/// queries that, after a maximum of two edits, equal some word from dictionary.
/// Return a list of all words from queries, that match with some word from dictionary after a maximum of two edits.
/// Return the words in the same order they appear in queries.
/// </summary>
public class Solution
{
    public IList<string> TwoEditWords(string[] queries, string[] dictionary)
    {
        var result = new List<string>(queries.Length);

        for (var i = 0; i < queries.Length; i++)
        for (var j = 0; j < dictionary.Length; j++)
        {
            var y = HasConvertion(queries[i], dictionary[j]);

            if (y)
            {
                result.Add(queries[i]);
                break;
            }
        }

        return result;
    }

    public bool HasConvertion(string s1, string s2)
    {
        var count = 0;

        for (var i = 0; i < s1.Length && count < 3; i++)
            if (s1[i] != s2[i])
                count++;

        return count < 3 ? true : false;
    }
}