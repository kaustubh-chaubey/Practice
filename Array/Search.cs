using System;
using System.Linq;


public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = {10,20,7,23,14,40,21,37,17};
        
        string input = Console.ReadLine();
        
        if(int.TryParse(input, out int number))
        {
            if(nums.Contains(number))
            {
                Console.WriteLine("Exists");
            }
            else
            {
                Console.WriteLine("Does not exsits");
            }
        }
        else
        {
            Console.WriteLine("No number found");
        }
    }
}
