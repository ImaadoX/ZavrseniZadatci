using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string input = "babucaraka";
        int result = LengthOfLongestSubstring(input);
        Console.WriteLine($"Duzina najduzeg podstringa koji nema ponavljajućih znakova je: {result}");
    }

    public static int LengthOfLongestSubstring(string s)
    {
        HashSet<char> charSet = new HashSet<char>();
        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (charSet.Contains(s[right]))
            {
                charSet.Remove(s[left]);
                left++;
            }

            charSet.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
