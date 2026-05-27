using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = {10,20,7,23,14,40,21,37,17, 40, 23, 14};

        int[] uniqueNums = new HashSet<int>(nums).ToArray();
        
        foreach(int n in uniqueNums)
        {
            Console.Write(n + "," );
        }
    }
}
