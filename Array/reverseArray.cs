public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = {10,20,7,23,14,40,21,37,17};
        
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            Console.Write(nums[i] + ", ");
        }
    }
}
