using System;
class Solutions {
  static void Main() {
      
      int[] nums = {5,6,7,8,9,11,13,15,18,19,20};
      int target = 18;
      
      int result1 = LinearSearch(nums, target);
      int result2 = BinarySearch(nums, target);
      
      if(result1 > -1 && result2 > -1)
      {
          Console.WriteLine(result1);
          Console.WriteLine(result2);
      }
      else{
          Console.WriteLine("Element not found");
      }
      
  }
  
  public static int LinearSearch(int[] arr, int target)
  {
      int steps = 0;
      for(int i = 0; i < arr.Length; i++)
      {
          steps++;
          if(arr[i] == target)
          {
              Console.WriteLine("steps by LinearSearch: " + steps);
              return i;
          }
      }
      return -1;
  }
  
  public static int BinarySearch(int[] nums, int target)
  {
      int steps = 0;
      int left = 0;
      int right = nums.Length -1;
      
      while(left <= right)
      {
          steps++;
          int mid = (left + right) / 2;
          
          if(nums[mid] == target)
          {
              Console.WriteLine("steps taken by Binary: " + steps);
              return mid;
          }
          else if(nums[mid] < target){
              left = mid + 1;
          }
          else{
              right = mid - 1;
          }
      }
      return -1;
  }
}
