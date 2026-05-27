using System;

public class Program
{
    public static void Main(string[] args)
    {
        string s = "Kaustubh";
        string reverse = string.Empty;
        for(int i = s.Length - 1; i >= 0; i--)
        {
            reverse += s[i];
        }
        Console.WriteLine(reverse);
    }
}
