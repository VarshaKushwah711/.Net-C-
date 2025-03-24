using System;

class Program
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "hello";

        bool areEqual = string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine("Are the strings equal? " + areEqual);
    }
}
