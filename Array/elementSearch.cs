using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = {10,20,7,23,14,40,21,37,17};
        int max = 0, secondMax = 0, thirdMax = 0;
        
        int min = nums[0];
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] > max)
            {
                thirdMax = secondMax;
                secondMax = max;
                max = nums[i];
            }
            else if(nums[i] < max && nums[i] > secondMax)
            {
                thirdMax = secondMax;
                secondMax = nums[i];
            }
            else if(nums[i] < max && nums[i] < secondMax && nums[i] > thirdMax)
            {
                thirdMax = nums[i];
            }
            
            if(nums[i] < min)
            {
                min = nums[i];
            }
        }
        
        Console.WriteLine(max);
        Console.WriteLine(secondMax);
        Console.WriteLine(thirdMax);
        
        Console.WriteLine(min);
    }
}
