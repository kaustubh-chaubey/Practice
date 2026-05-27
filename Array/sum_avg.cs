using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = {10,20,7,23,14,40,21,37,17};
        int sum = 0; double avg = 0;
        
        for(int i =0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        
        avg = sum/nums.Length;
        
        Console.WriteLine(sum);
        Console.WriteLine(avg);
    }
}
