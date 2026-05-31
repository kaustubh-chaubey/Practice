using System;
class HelloWorld {
  static void Main() {
      
      int[] nums = {6,5,2,8,9,4};
      int size = nums.Length;
      int temp = 0;
      
      Console.WriteLine("after sorting");
      foreach(int num in nums)
      {
          Console.Write(num + " ");
      }
      
      for(int i = 0; i<size; i++)
      {
          for(int j = 0; j < size - i - 1; j++) // size of j should end before the last value as it is already sorted
          {
              if(nums[j] > nums[j + 1])
              {
                  temp = nums[j];
                  nums[j] = nums[j+1];
                  nums[j+1] = temp;
              }
          }
        foreach(int num in nums) // code to see all the iterations happening for sorting
        {
            Console.Write(num + " ");
        }
      }
      
      Console.WriteLine();
      Console.WriteLine("before sorting");
      foreach(int num in nums)
      {
          Console.Write(num + " ");
      }
  }

  
  
  
  
}
