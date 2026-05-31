using System;
class HelloWorld {
  static void Main() {
    
    int[] arr = {3, 5, 1, 4, 6, 2};
    
    
    Console.WriteLine("before sorting");
    foreach(int num in arr)
    {
        Console.Write(num + " ");
    }
    
    MergeSort(arr, 0, arr.Length - 1);
    
    
    Console.WriteLine();
    Console.WriteLine("after sorting");
    foreach(int num in arr)
    {
        Console.Write(num + " ");
    }
    
  }
  
  private static void MergeSort(int[] arr, int l, int r)
  {
      if(l < r)
      {
          int mid = (l + r) / 2;
          MergeSort(arr, l, mid);
          MergeSort(arr, mid + 1, r);
          
          Merge(arr, l, mid, r);
      }
  }
  
  private static void Merge(int[] arr, int l, int mid, int r)
  {
      int n1 = mid - l + 1;
      int n2 = r - mid;
      
      int[] lArr = new int[n1];
      int[] rArr = new int[n2];
      
      for(int x = 0; x < n1; x++)
      {
          lArr[x] = arr[l + x];
      }
      
      for(int x = 0; x < n2; x++)
      {
          rArr[x] = arr[mid + 1 + x];
      }
      
      int i = 0;
      int j = 0;
      int k = l;
      
      while(i < n1 && j < n2)
      {
          if(lArr[i] <= rArr[j])
          {
              arr[k] = lArr[i];
              i++ ;
          }
          else{
              arr[k] = rArr[j];
              j++ ;
          }
          k++ ;
      }
      
      while(i < n1)
      {
          arr[k] = lArr[i];
          i++;
          k++;
      }
      
      while(j < n2)
      {
          arr[k] = rArr[j];
          j++;
          k++;
      }
  }
  
  
}
