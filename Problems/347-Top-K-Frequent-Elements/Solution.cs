namespace Leetcode.Problems.DotNet._347_Top_K_Frequent_Elements;

/// <summary>
/// Problem description: https://leetcode.com/problems/top-k-frequent-elements/description/
/// Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any
/// order.
/// </summary>
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dic = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
            if (dic.ContainsKey(nums[i]))
            {
                dic[nums[i]] += 1;
            }
            else
            {
                dic[nums[i]] = 1;
            }

        var arr = new int [nums.Length];
        for (var i = 0; i < nums.Length; i++) arr[i] = dic[nums[i]];

        // Build heap (rearrange array)
        for (var i = arr.Length / 2 - 1; i >= 0; i--)
            HeapifyMax(nums, arr, arr.Length, i);

        var list = new HashSet<int>();
        list.Add(nums[0]);

        // One by one extract elements from heap
        for (var i = arr.Length - 1; i >= 0 && list.Count < k; i--)
        {
            // Move current root to end
            Swap(ref arr[0], ref arr[i]);
            Swap(ref nums[0], ref nums[i]);

            list.Add(nums[i]);

            // Call heapify on the reduced heap
            HeapifyMax(nums, arr, i, 0);
        }

        return list.ToArray();
    }

    public void HeapifyMax(int[] nums, int[] arr, int n, int i)
    {
        while (true)
        {
            var largest = i;

            // Initialize largest as root
            var l = 2 * i + 1; // left = 2*i + 1
            var r = 2 * i + 2; // right = 2*i + 2

            // If left child is larger than root
            if (l < n && arr[l] > arr[largest])
            {
                largest = l;
            }

            // If right child is larger than largest so far
            if (r < n && arr[r] > arr[largest])
            {
                largest = r;
            }

            if (largest == i)
            {
                // If heap is ordered, exit loop
                break;
            }

            // If largest is not root
            Swap(ref arr[i], ref arr[largest]);
            Swap(ref nums[i], ref nums[largest]);

            // Continue processing subtree iteratively
            i = largest;
        }
    }

    public void Swap<T>(ref T a, ref T b)
    {
        (a, b) = (b, a);
    }
}