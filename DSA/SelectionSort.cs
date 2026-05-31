using System;
class HelloWorld {
  static void Main() {
      
      int[] nums = {6,5,2,8,9,4};
      int size = nums.Length;
      int temp = 0;
      int midIndex = -1;
      Console.WriteLine("after sorting");
      foreach(int num in nums)
      {
          Console.Write(num + " ");
      }
      
      for(int i = 0; i < size - 1; i++) // -1 from size is to remove the last step of swapping which is already not needed
      {
          midIndex = i;
          for(int j = i + 1; j < size; j++)
          {
              if(nums[midIndex] > nums[j])
              {
                  midIndex = j;
              }
          }
          
          temp = nums[midIndex];
          nums[midIndex] = nums[i];
          nums[i] = temp;
          
        //   Console.WriteLine();
        //   foreach(int num in nums) // to see the iterations between the code
        //   {
        //       Console.Write(num + " ");
        //   }
      }
      
      
      Console.WriteLine();
      Console.WriteLine("before sorting");
      foreach(int num in nums)
      {
          Console.Write(num + " ");
      }
  }
 
}
