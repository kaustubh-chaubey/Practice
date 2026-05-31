using System;
class HelloWorld {
  static void Main() {
    
    int result = fact(10);
    Console.WriteLine(result);
  }
  
  public static int fact(int i)
  {
      if(i != 0)
      {
          return i * fact(i - 1);
      }
      
      return 1;
  }
}
