using System;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
        {
            return FindMedianSortedArrays(nums2, nums1);
        }

        int m = nums1.Length;
        int n = nums2.Length;
        int left = 0, right = m;
        int halfLen = (m + n + 1) / 2;

        while (left <= right)
        {
            int i = (left + right) / 2;
            int j = halfLen - i;

            if (i < m && nums2[j - 1] > nums1[i])
            {
                left = i + 1;
            }
            else if (i > 0 && nums1[i - 1] > nums2[j])
            {
                right = i - 1;
            }
            else
            {
                int maxOfLeft;
                if (i == 0) { maxOfLeft = nums2[j - 1]; }
                else if (j == 0) { maxOfLeft = nums1[i - 1]; }
                else { maxOfLeft = Math.Max(nums1[i - 1], nums2[j - 1]); }

                if ((m + n) % 2 == 1)
                {
                    return maxOfLeft; 
                }

                int minOfRight;
                if (i == m) { minOfRight = nums2[j]; }
                else if (j == n) { minOfRight = nums1[i]; }
                else { minOfRight = Math.Min(nums1[i], nums2[j]); }

                return (maxOfLeft + minOfRight) / 2.0;
            }
        }

        throw new ArgumentException("Input arrays are not valid.");
    }
}
