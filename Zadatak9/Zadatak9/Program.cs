using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] heights = { 9, 4, 6, 2, 5, 6, 1, 9, 3 };
        int maxArea = MaxArea(heights);
        Console.WriteLine($"Maximalna povrsina je: {maxArea}");
    }

    public static int MaxArea(int[] heights)
    {
        int left = 0;
        int right = heights.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            int width = right - left;
            int height = Math.Min(heights[left], heights[right]);

            int area = width * height;

            maxArea = Math.Max(maxArea, area);

            if (heights[left] < heights[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}
