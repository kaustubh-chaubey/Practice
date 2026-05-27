// using bubble sort logic
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = {10,20,7,23,14,40,21,37,17};
        
        for(int i = 0; i < nums.Length - 1; i++)
        {
            for(int j = 0; j < nums.Length - i - 1; j++)
            {
                if(nums[j] > nums[j+1])
                {
                    int temp = nums[j];
                    nums[j] = nums[j+ 1];
                    nums[j +1] = temp;
                }
            }
        }
        
        foreach(int n in nums)
        {
            Console.Write(n + " ");
        }
    }
}
