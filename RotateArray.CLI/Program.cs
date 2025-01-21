using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums1 = { 1, 2, 3, 4, 5, 6, 7 };
        int k1 = 3;
        Console.WriteLine("Testcase 1:");
        TestRotate(nums1, k1);

        // Testfall 2
        int[] nums2 = { -1, -100, 3, 99 };
        int k2 = 2;
        Console.WriteLine("Testcase 2:");
        TestRotate(nums2, k2);
    }

    private static void TestRotate(int[] nums, int k)
    {
        Console.WriteLine("Originales Array: " + string.Join(", ", nums));
        Rotate(nums, k);
        Console.WriteLine($"After {k} Rotationen: " + string.Join(", ", nums));
        Console.WriteLine();
    }

    public static void Rotate(int[] nums, int k)
    {
        if (nums != null && nums.Length > 0 && k > 0)
        {
            k = k % nums.Length;
            Array.Reverse(nums);
            Helper(nums, 0, k - 1);
            Helper(nums, k, nums.Length - 1);
        }
    }

    private static void Helper(int[] array, int start, int end)
    {
        while (start < end)
        {
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;
            start++;
            end--;
        }
    }
}