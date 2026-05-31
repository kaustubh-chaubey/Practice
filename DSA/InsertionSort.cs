using System;
class HelloWorld {
  static void Main() {
      
      int[] nums = {6,5,2,8,9,4};

      Console.WriteLine("after sorting");
      foreach(int num in nums)
      {
          Console.Write(num + " ");
      }
      
      for(int i = 1; i < nums.Length; i++)
      {
          int key = nums[i];
          int j = i - 1;
          
          while(j >= 0 && nums[j] > key)
          {
              nums[j + 1] = nums[j];
              j-- ;
          }
          nums[j+1] = key;
      }
      
      
      Console.WriteLine();
      Console.WriteLine("before sorting");
      foreach(int num in nums)
      {
          Console.Write(num + " ");
      }
  }
 
}
