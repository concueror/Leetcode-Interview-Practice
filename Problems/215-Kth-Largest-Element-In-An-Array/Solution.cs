namespace Leetcode.Problems.DotNet._215_Kth_Largest_Element_In_An_Array;

/// <summary>
/// Problem description: https://leetcode.com/problems/kth-largest-element-in-an-array/description/
/// Given an integer array nums and an integer k, return the kth largest element in the array.
/// Note that it is the kth largest element in the sorted order, not the kth distinct element.
/// Can you solve it without sorting?
/// </summary>
public class Solution {
    public int FindKthLargest(int[] nums, int k) {        
        var arr = nums;

        // Build heap (rearrange array)
		for (var i = arr.Length / 2 - 1; i >= 0; i--)
			HeapifyMax(arr, arr.Length, i);

		// One by one extract elements from heap
		for (var i = arr.Length - 1; i >= 0 && i >= arr.Length - k ; i--)
		{
			// Move current root to end
			Swap(ref arr[0], ref arr[i]);

			// Call heapify on the reduced heap
			HeapifyMax(arr, i, 0);
		}

        return arr[arr.Length - k];
    }
    
    public void HeapifyMax(int[] arr, int n, int i)
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

            // Continue processing subtree iteratively
            i = largest;
        }
    }

    public void Swap<T>(ref T a, ref T b)
    {
        (a, b) = (b, a);
    }
}
