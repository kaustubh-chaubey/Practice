using System;
class HelloWorld {
  static void Main() {
      
      int[] nums = {6,5,2,8,9,4};

      Console.WriteLine("after sorting");
      foreach(int num in nums)
      {
          Console.Write(num + " ");
      }
      
      QuickSort(nums,0, nums.Length - 1);
      
      
      Console.WriteLine();
      Console.WriteLine("before sorting");
      foreach(int num in nums)
      {
          Console.Write(num + " ");
      }
  }
  
  private static void QuickSort(int[] arr, int low, int high)
  {
      if(low < high)
      {
          int pi = Partition(arr, low, high);
          
          QuickSort(arr, low, pi - 1);
          QuickSort(arr, pi + 1 ,high);
      }
  }
  
  private static int Partition(int[] arr, int low, int high)
  {
      int pivot = arr[high];
      int i = low - 1;
      
      for(int j = low; j < high; j++)
      {
          if(arr[j] < pivot)
          {
              i++ ;
              int temp = arr[i];
              arr[i] = arr[j];
              arr[j] = temp;
          }
      }
      
      int temp2 = arr[i + 1];
      arr[i + 1] = arr[high];
      arr[high] = temp2;
      
      return i + 1;
  }
 
}
